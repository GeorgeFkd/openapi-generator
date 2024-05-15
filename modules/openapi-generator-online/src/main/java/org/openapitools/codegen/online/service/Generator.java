/*
 * Copyright 2018 OpenAPI-Generator Contributors (https://openapi-generator.tech)
 * Copyright 2018 SmartBear Software
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package org.openapitools.codegen.online.service;

import com.fasterxml.jackson.databind.JsonNode;
import io.swagger.parser.OpenAPIParser;
import io.swagger.v3.oas.models.OpenAPI;
import io.swagger.v3.oas.models.Operation;
import io.swagger.v3.oas.models.PathItem;
import io.swagger.v3.oas.models.Paths;
import io.swagger.v3.parser.core.models.AuthorizationValue;
import io.swagger.v3.parser.core.models.ParseOptions;
import org.openapitools.codegen.CliOption;
import org.openapitools.codegen.ClientOptInput;
import org.openapitools.codegen.CodegenConfig;
import org.openapitools.codegen.CodegenConfigLoader;
import org.openapitools.codegen.DefaultGenerator;
import org.openapitools.codegen.online.model.GeneratorInput;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.web.server.ResponseStatusException;

import java.io.File;
import java.nio.file.Files;
import java.util.*;
import java.util.stream.Collectors;

public class Generator {
    private static Logger LOGGER = LoggerFactory.getLogger(Generator.class);

    public static Map<String, CliOption> getOptions(String language) {
        CodegenConfig config;
        try {
            config = CodegenConfigLoader.forName(language);
        } catch (Exception e) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, String.format(Locale.ROOT,"Unsupported target %s supplied. %s",
                    language, e));
        }
        Map<String, CliOption> map = new LinkedHashMap<>();
        for (CliOption option : config.cliOptions()) {
            map.put(option.getOpt(), option);
        }
        return map;
    }

    public enum Type {
        CLIENT("client"), SERVER("server");

        private String name;

        Type(String name) {
            this.name = name;
        }

        String getTypeName() {
            return name;
        }
    }

    public static String generateClient(String language, GeneratorInput opts) {
        return generate(language, opts, Type.CLIENT);
    }

    public static String generateServer(String language, GeneratorInput opts) {
        return generate(language, opts, Type.SERVER);
    }

    private static String generate(String language, GeneratorInput opts, Type type) {
        LOGGER.debug(String.format(Locale.ROOT,"generate %s for %s", type.getTypeName(), language));
        if (opts == null) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "No options were supplied");
        }
        JsonNode node = opts.getSpec();
        if (node != null && "{}".equals(node.toString())) {
            LOGGER.debug("ignoring empty spec");
            node = null;
        }
        OpenAPI openapi;
        ParseOptions parseOptions = new ParseOptions();
        parseOptions.setResolve(true);
        if (node == null) {
            if (opts.getOpenAPIUrl() != null) {
                if (opts.getAuthorizationValue() != null) {
                    List<AuthorizationValue> authorizationValues = new ArrayList<>();
                    authorizationValues.add(opts.getAuthorizationValue());
                    openapi = new OpenAPIParser().readLocation(opts.getOpenAPIUrl(), authorizationValues, parseOptions).getOpenAPI();
                } else {
                    openapi = new OpenAPIParser().readLocation(opts.getOpenAPIUrl(), null, parseOptions).getOpenAPI();
                }
            } else {
                throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "No OpenAPI specification was supplied");
            }
        } else if (opts.getAuthorizationValue() != null) {
            List<AuthorizationValue> authorizationValues = new ArrayList<>();
            authorizationValues.add(opts.getAuthorizationValue());
            openapi = new OpenAPIParser().readContents(node.toString(), authorizationValues, parseOptions).getOpenAPI();

        } else {
            openapi = new OpenAPIParser().readContents(node.toString(), null, parseOptions).getOpenAPI();
        }
        if (openapi == null) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "The OpenAPI specification supplied was not valid");
        }

        String destPath = null;

        if (opts.getOptions() != null) {
            destPath = opts.getOptions().get("outputFolder");
        }
        if (destPath == null) {
            destPath = language + "-" + type.getTypeName();
        }
        //my addition
        Paths existingPaths = openapi.getPaths();
        Paths newPaths = (Paths) existingPaths.clone();
        List<String> operationsSelectedByUser = opts.getOperationsSelected();
        for(Map.Entry<String, PathItem> entry : existingPaths.entrySet()) {
            System.out.println("Path: " + entry.getKey() + " Value: " + entry.getValue());
            PathItem pathItem = entry.getValue();
            List<Operation> allOperations = Arrays.asList(pathItem.getGet(), pathItem.getPost(), pathItem.getPut(), pathItem.getDelete(), pathItem.getOptions(), pathItem.getHead(), pathItem.getPatch(), pathItem.getTrace());
            List<Operation> selectedOperations = allOperations.stream().filter(Objects::nonNull).filter(operation -> operationsSelectedByUser.contains(operation.getOperationId())).collect(Collectors.toList());
            if(selectedOperations.isEmpty()) {
                newPaths.remove(entry.getKey());
            }else {
                //TODO do it better
                //0->get, 1->post, 2->put, 3->delete, 4->options, 5->head, 6->patch, 7->trace
                for(int i = 0; i < allOperations.size(); i++){
                    Operation o = allOperations.get(i);
                    if(o == null) { continue;}
                    if(!operationsSelectedByUser.contains(o.getOperationId())) {
                        switch (i){
                            case 0:
                                pathItem.setGet(null);
                                break;
                            case 1:
                                pathItem.setPost(null);
                                break;
                            case 2:
                                pathItem.setPut(null);
                                break;
                            case 3:
                                pathItem.setDelete(null);
                                break;
                            case 4:
                                pathItem.setOptions(null);
                                break;
                            case 5:
                                pathItem.setHead(null);
                                break;
                            case 6:
                                pathItem.setPatch(null);
                                break;
                            case 7:
                                pathItem.setTrace(null);
                                break;
                        }

                    }
                }
                newPaths.put(entry.getKey(), pathItem);
            }

        }
        openapi.setPaths(newPaths);

        ClientOptInput clientOptInput = new ClientOptInput();
        String outputFolder = getTmpFolder().getAbsolutePath() + File.separator + destPath;
        String outputFilename = outputFolder + "-bundle.zip";

        clientOptInput.openAPI(openapi);

        CodegenConfig codegenConfig;
        try {
            codegenConfig = CodegenConfigLoader.forName(language);
        } catch (RuntimeException e) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Unsupported target " + language + " supplied");
        }

        if (opts.getOptions() != null) {
            codegenConfig.additionalProperties().putAll(opts.getOptions());
            codegenConfig.additionalProperties().put("openAPI", openapi);
        }

        codegenConfig.setOutputDir(outputFolder);

        clientOptInput.config(codegenConfig);

        try {
            List<File> files = new DefaultGenerator().opts(clientOptInput).generate();
            if (files.size() > 0) {
                List<File> filesToAdd = new ArrayList<>();
                LOGGER.debug("adding to {}", outputFolder);
                filesToAdd.add(new File(outputFolder));
                ZipUtil zip = new ZipUtil();
                zip.compressFiles(filesToAdd, outputFilename);
            } else {
                throw new ResponseStatusException(HttpStatus.BAD_REQUEST,
                        "A target generation was attempted, but no files were created!");
            }
            for (File file : files) {
                try {
                    file.delete();
                } catch (Exception e) {
                    LOGGER.error("unable to delete file " + file.getAbsolutePath(), e);
                }
            }
            try {
                new File(outputFolder).delete();
            } catch (Exception e) {
                LOGGER.error("unable to delete output folder " + outputFolder, e);
            }
        } catch (Exception e) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Unable to build target: " + e.getMessage(), e);
        }
        return outputFilename;
    }

    private static File getTmpFolder() {
        try {
            File outputFolder = Files.createTempDirectory("codegen-tmp").toFile();
            outputFolder.deleteOnExit();
            return outputFolder;
        } catch (Exception e) {
            e.printStackTrace();
            throw new RuntimeException("Cannot access tmp folder");
        }
    }
}
