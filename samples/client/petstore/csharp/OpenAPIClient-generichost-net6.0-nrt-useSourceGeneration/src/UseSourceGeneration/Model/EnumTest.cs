// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// EnumTest
    /// </summary>
    public partial class EnumTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// </summary>
        /// <param name="enumInteger">enumInteger</param>
        /// <param name="enumIntegerOnly">enumIntegerOnly</param>
        /// <param name="enumNumber">enumNumber</param>
        /// <param name="enumString">enumString</param>
        /// <param name="enumStringRequired">enumStringRequired</param>
        /// <param name="outerEnumDefaultValue">outerEnumDefaultValue</param>
        /// <param name="outerEnumInteger">outerEnumInteger</param>
        /// <param name="outerEnumIntegerDefaultValue">outerEnumIntegerDefaultValue</param>
        /// <param name="outerEnum">outerEnum</param>
        [JsonConstructor]
        public EnumTest(EnumIntegerEnum enumInteger, EnumIntegerOnlyEnum enumIntegerOnly, EnumNumberEnum enumNumber, EnumStringEnum enumString, EnumStringRequiredEnum enumStringRequired, OuterEnumDefaultValue outerEnumDefaultValue, OuterEnumInteger outerEnumInteger, OuterEnumIntegerDefaultValue outerEnumIntegerDefaultValue, OuterEnum? outerEnum = default)
        {
            EnumInteger = enumInteger;
            EnumIntegerOnly = enumIntegerOnly;
            EnumNumber = enumNumber;
            EnumString = enumString;
            EnumStringRequired = enumStringRequired;
            OuterEnumDefaultValue = outerEnumDefaultValue;
            OuterEnumInteger = outerEnumInteger;
            OuterEnumIntegerDefaultValue = outerEnumIntegerDefaultValue;
            OuterEnum = outerEnum;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines EnumInteger
        /// </summary>
        public enum EnumIntegerEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumIntegerEnum EnumIntegerEnumFromString(string value)
        {
            if (value.Equals((1).ToString()))
                return EnumIntegerEnum.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return EnumIntegerEnum.NUMBER_MINUS_1;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerEnum? EnumIntegerEnumFromStringOrDefault(string value)
        {
            if (value.Equals((1).ToString()))
                return EnumIntegerEnum.NUMBER_1;

            if (value.Equals((-1).ToString()))
                return EnumIntegerEnum.NUMBER_MINUS_1;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumIntegerEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int EnumIntegerEnumToJsonValue(EnumIntegerEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [JsonPropertyName("enum_integer")]
        public EnumIntegerEnum EnumInteger { get; set; }

        /// <summary>
        /// Defines EnumIntegerOnly
        /// </summary>
        public enum EnumIntegerOnlyEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_MINUS_2 for value: -2
            /// </summary>
            NUMBER_MINUS_2 = -2
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerOnlyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumIntegerOnlyEnum EnumIntegerOnlyEnumFromString(string value)
        {
            if (value.Equals((2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_2;

            if (value.Equals((-2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_MINUS_2;

            throw new NotImplementedException($"Could not convert value to type EnumIntegerOnlyEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumIntegerOnlyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumIntegerOnlyEnum? EnumIntegerOnlyEnumFromStringOrDefault(string value)
        {
            if (value.Equals((2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_2;

            if (value.Equals((-2).ToString()))
                return EnumIntegerOnlyEnum.NUMBER_MINUS_2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumIntegerOnlyEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int EnumIntegerOnlyEnumToJsonValue(EnumIntegerOnlyEnum value)
        {
            return (int) value;
        }

        /// <summary>
        /// Gets or Sets EnumIntegerOnly
        /// </summary>
        [JsonPropertyName("enum_integer_only")]
        public EnumIntegerOnlyEnum EnumIntegerOnly { get; set; }

        /// <summary>
        /// Defines EnumNumber
        /// </summary>
        public enum EnumNumberEnum
        {
            /// <summary>
            /// Enum NUMBER_1_DOT_1 for value: 1.1
            /// </summary>
            NUMBER_1_DOT_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1_DOT_2 for value: -1.2
            /// </summary>
            NUMBER_MINUS_1_DOT_2 = 2
        }

        /// <summary>
        /// Returns a <see cref="EnumNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumNumberEnum EnumNumberEnumFromString(string value)
        {
            if (value.Equals("1.1"))
                return EnumNumberEnum.NUMBER_1_DOT_1;

            if (value.Equals("-1.2"))
                return EnumNumberEnum.NUMBER_MINUS_1_DOT_2;

            throw new NotImplementedException($"Could not convert value to type EnumNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumNumberEnum? EnumNumberEnumFromStringOrDefault(string value)
        {
            if (value.Equals("1.1"))
                return EnumNumberEnum.NUMBER_1_DOT_1;

            if (value.Equals("-1.2"))
                return EnumNumberEnum.NUMBER_MINUS_1_DOT_2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumNumberEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double EnumNumberEnumToJsonValue(EnumNumberEnum value)
        {
            if (value == EnumNumberEnum.NUMBER_1_DOT_1)
                return 1.1;

            if (value == EnumNumberEnum.NUMBER_MINUS_1_DOT_2)
                return -1.2;

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [JsonPropertyName("enum_number")]
        public EnumNumberEnum EnumNumber { get; set; }

        /// <summary>
        /// Defines EnumString
        /// </summary>
        public enum EnumStringEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3,

            /// <summary>
            /// Enum ValuewithTab for value: Value\twith tab
            /// </summary>
            ValuewithTab = 4,

            /// <summary>
            /// Enum ValueWithQuote for value: Value with \&quot; quote
            /// </summary>
            ValueWithQuote = 5,

            /// <summary>
            /// Enum ValueWithEscapedQuote for value: Value with escaped \&quot; quote
            /// </summary>
            ValueWithEscapedQuote = 6,

            /// <summary>
            /// Enum Duplicatevalue for value: Duplicate\nvalue
            /// </summary>
            Duplicatevalue = 7,

            /// <summary>
            /// Enum Duplicatevalue2 for value: Duplicate\r\nvalue
            /// </summary>
            Duplicatevalue2 = 8
        }

        /// <summary>
        /// Returns a <see cref="EnumStringEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumStringEnum EnumStringEnumFromString(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringEnum.Lower;

            if (value.Equals(""))
                return EnumStringEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringEnum.Duplicatevalue2;

            throw new NotImplementedException($"Could not convert value to type EnumStringEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumStringEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringEnum? EnumStringEnumFromStringOrDefault(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringEnum.Lower;

            if (value.Equals(""))
                return EnumStringEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringEnum.Duplicatevalue2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumStringEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringEnumToJsonValue(EnumStringEnum value)
        {
            if (value == EnumStringEnum.UPPER)
                return "UPPER";

            if (value == EnumStringEnum.Lower)
                return "lower";

            if (value == EnumStringEnum.Empty)
                return "";

            if (value == EnumStringEnum.ValuewithTab)
                return "Value\twith tab";

            if (value == EnumStringEnum.ValueWithQuote)
                return "Value with \" quote";

            if (value == EnumStringEnum.ValueWithEscapedQuote)
                return "Value with escaped \" quote";

            if (value == EnumStringEnum.Duplicatevalue)
                return "Duplicate\nvalue";

            if (value == EnumStringEnum.Duplicatevalue2)
                return "Duplicate\r\nvalue";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonPropertyName("enum_string")]
        public EnumStringEnum EnumString { get; set; }

        /// <summary>
        /// Defines EnumStringRequired
        /// </summary>
        public enum EnumStringRequiredEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            Empty = 3,

            /// <summary>
            /// Enum ValuewithTab for value: Value\twith tab
            /// </summary>
            ValuewithTab = 4,

            /// <summary>
            /// Enum ValueWithQuote for value: Value with \&quot; quote
            /// </summary>
            ValueWithQuote = 5,

            /// <summary>
            /// Enum ValueWithEscapedQuote for value: Value with escaped \&quot; quote
            /// </summary>
            ValueWithEscapedQuote = 6,

            /// <summary>
            /// Enum Duplicatevalue for value: Duplicate\nvalue
            /// </summary>
            Duplicatevalue = 7,

            /// <summary>
            /// Enum Duplicatevalue2 for value: Duplicate\r\nvalue
            /// </summary>
            Duplicatevalue2 = 8
        }

        /// <summary>
        /// Returns a <see cref="EnumStringRequiredEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EnumStringRequiredEnum EnumStringRequiredEnumFromString(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringRequiredEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringRequiredEnum.Lower;

            if (value.Equals(""))
                return EnumStringRequiredEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringRequiredEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringRequiredEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringRequiredEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue2;

            throw new NotImplementedException($"Could not convert value to type EnumStringRequiredEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EnumStringRequiredEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumStringRequiredEnum? EnumStringRequiredEnumFromStringOrDefault(string value)
        {
            if (value.Equals("UPPER"))
                return EnumStringRequiredEnum.UPPER;

            if (value.Equals("lower"))
                return EnumStringRequiredEnum.Lower;

            if (value.Equals(""))
                return EnumStringRequiredEnum.Empty;

            if (value.Equals("Value\twith tab"))
                return EnumStringRequiredEnum.ValuewithTab;

            if (value.Equals("Value with \" quote"))
                return EnumStringRequiredEnum.ValueWithQuote;

            if (value.Equals("Value with escaped \" quote"))
                return EnumStringRequiredEnum.ValueWithEscapedQuote;

            if (value.Equals("Duplicate\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue;

            if (value.Equals("Duplicate\r\nvalue"))
                return EnumStringRequiredEnum.Duplicatevalue2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EnumStringRequiredEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string EnumStringRequiredEnumToJsonValue(EnumStringRequiredEnum value)
        {
            if (value == EnumStringRequiredEnum.UPPER)
                return "UPPER";

            if (value == EnumStringRequiredEnum.Lower)
                return "lower";

            if (value == EnumStringRequiredEnum.Empty)
                return "";

            if (value == EnumStringRequiredEnum.ValuewithTab)
                return "Value\twith tab";

            if (value == EnumStringRequiredEnum.ValueWithQuote)
                return "Value with \" quote";

            if (value == EnumStringRequiredEnum.ValueWithEscapedQuote)
                return "Value with escaped \" quote";

            if (value == EnumStringRequiredEnum.Duplicatevalue)
                return "Duplicate\nvalue";

            if (value == EnumStringRequiredEnum.Duplicatevalue2)
                return "Duplicate\r\nvalue";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EnumStringRequired
        /// </summary>
        [JsonPropertyName("enum_string_required")]
        public EnumStringRequiredEnum EnumStringRequired { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumDefaultValue")]
        public OuterEnumDefaultValue OuterEnumDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumInteger
        /// </summary>
        [JsonPropertyName("outerEnumInteger")]
        public OuterEnumInteger OuterEnumInteger { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnumIntegerDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumIntegerDefaultValue")]
        public OuterEnumIntegerDefaultValue OuterEnumIntegerDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets OuterEnum
        /// </summary>
        [JsonPropertyName("outerEnum")]
        public OuterEnum? OuterEnum { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumIntegerOnly: ").Append(EnumIntegerOnly).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  EnumStringRequired: ").Append(EnumStringRequired).Append("\n");
            sb.Append("  OuterEnumDefaultValue: ").Append(OuterEnumDefaultValue).Append("\n");
            sb.Append("  OuterEnumInteger: ").Append(OuterEnumInteger).Append("\n");
            sb.Append("  OuterEnumIntegerDefaultValue: ").Append(OuterEnumIntegerDefaultValue).Append("\n");
            sb.Append("  OuterEnum: ").Append(OuterEnum).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="EnumTest" />
    /// </summary>
    public class EnumTestJsonConverter : JsonConverter<EnumTest>
    {
        /// <summary>
        /// Deserializes json to <see cref="EnumTest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EnumTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            EnumTest.EnumIntegerEnum? enumInteger = default;
            EnumTest.EnumIntegerOnlyEnum? enumIntegerOnly = default;
            EnumTest.EnumNumberEnum? enumNumber = default;
            EnumTest.EnumStringEnum? enumString = default;
            EnumTest.EnumStringRequiredEnum? enumStringRequired = default;
            OuterEnumDefaultValue? outerEnumDefaultValue = default;
            OuterEnumInteger? outerEnumInteger = default;
            OuterEnumIntegerDefaultValue? outerEnumIntegerDefaultValue = default;
            OuterEnum? outerEnum = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "enum_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumInteger = (EnumTest.EnumIntegerEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_integer_only":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumIntegerOnly = (EnumTest.EnumIntegerOnlyEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enumNumber = (EnumTest.EnumNumberEnum)utf8JsonReader.GetInt32();
                            break;
                        case "enum_string":
                            string? enumStringRawValue = utf8JsonReader.GetString();
                            enumString = enumStringRawValue == null
                                ? null
                                : EnumTest.EnumStringEnumFromStringOrDefault(enumStringRawValue);
                            break;
                        case "enum_string_required":
                            string? enumStringRequiredRawValue = utf8JsonReader.GetString();
                            enumStringRequired = enumStringRequiredRawValue == null
                                ? null
                                : EnumTest.EnumStringRequiredEnumFromStringOrDefault(enumStringRequiredRawValue);
                            break;
                        case "outerEnumDefaultValue":
                            string? outerEnumDefaultValueRawValue = utf8JsonReader.GetString();
                            outerEnumDefaultValue = outerEnumDefaultValueRawValue == null
                                ? null
                                : OuterEnumDefaultValueValueConverter.FromStringOrDefault(outerEnumDefaultValueRawValue);
                            break;
                        case "outerEnumInteger":
                            string? outerEnumIntegerRawValue = utf8JsonReader.GetString();
                            outerEnumInteger = outerEnumIntegerRawValue == null
                                ? null
                                : OuterEnumIntegerValueConverter.FromStringOrDefault(outerEnumIntegerRawValue);
                            break;
                        case "outerEnumIntegerDefaultValue":
                            string? outerEnumIntegerDefaultValueRawValue = utf8JsonReader.GetString();
                            outerEnumIntegerDefaultValue = outerEnumIntegerDefaultValueRawValue == null
                                ? null
                                : OuterEnumIntegerDefaultValueValueConverter.FromStringOrDefault(outerEnumIntegerDefaultValueRawValue);
                            break;
                        case "outerEnum":
                            string? outerEnumRawValue = utf8JsonReader.GetString();
                            outerEnum = outerEnumRawValue == null
                                ? null
                                : OuterEnumValueConverter.FromStringOrDefault(outerEnumRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (enumInteger == null)
                throw new ArgumentNullException(nameof(enumInteger), "Property is required for class EnumTest.");

            if (enumIntegerOnly == null)
                throw new ArgumentNullException(nameof(enumIntegerOnly), "Property is required for class EnumTest.");

            if (enumNumber == null)
                throw new ArgumentNullException(nameof(enumNumber), "Property is required for class EnumTest.");

            if (enumString == null)
                throw new ArgumentNullException(nameof(enumString), "Property is required for class EnumTest.");

            if (enumStringRequired == null)
                throw new ArgumentNullException(nameof(enumStringRequired), "Property is required for class EnumTest.");

            if (outerEnumDefaultValue == null)
                throw new ArgumentNullException(nameof(outerEnumDefaultValue), "Property is required for class EnumTest.");

            if (outerEnumInteger == null)
                throw new ArgumentNullException(nameof(outerEnumInteger), "Property is required for class EnumTest.");

            if (outerEnumIntegerDefaultValue == null)
                throw new ArgumentNullException(nameof(outerEnumIntegerDefaultValue), "Property is required for class EnumTest.");

            return new EnumTest(enumInteger.Value, enumIntegerOnly.Value, enumNumber.Value, enumString.Value, enumStringRequired.Value, outerEnumDefaultValue.Value, outerEnumInteger.Value, outerEnumIntegerDefaultValue.Value, outerEnum);
        }

        /// <summary>
        /// Serializes a <see cref="EnumTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EnumTest enumTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, enumTest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="EnumTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, EnumTest enumTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("enum_integer", EnumTest.EnumIntegerEnumToJsonValue(enumTest.EnumInteger));
            writer.WriteNumber("enum_integer_only", EnumTest.EnumIntegerOnlyEnumToJsonValue(enumTest.EnumIntegerOnly));
            writer.WriteNumber("enum_number", EnumTest.EnumNumberEnumToJsonValue(enumTest.EnumNumber));

            var enumStringRawValue = EnumTest.EnumStringEnumToJsonValue(enumTest.EnumString);
            if (enumStringRawValue != null)
                writer.WriteString("enum_string", enumStringRawValue);
            else
                writer.WriteNull("enum_string");

            var enumStringRequiredRawValue = EnumTest.EnumStringRequiredEnumToJsonValue(enumTest.EnumStringRequired);
            if (enumStringRequiredRawValue != null)
                writer.WriteString("enum_string_required", enumStringRequiredRawValue);
            else
                writer.WriteNull("enum_string_required");

            var outerEnumDefaultValueRawValue = OuterEnumDefaultValueValueConverter.ToJsonValue(enumTest.OuterEnumDefaultValue);

            if (outerEnumDefaultValueRawValue != null)
                writer.WriteString("outerEnumDefaultValue", outerEnumDefaultValueRawValue);
            else
                writer.WriteNull("outerEnumDefaultValue");

            var outerEnumIntegerRawValue = OuterEnumIntegerValueConverter.ToJsonValue(enumTest.OuterEnumInteger);
            writer.WriteNumber("outerEnumInteger", outerEnumIntegerRawValue);
            var outerEnumIntegerDefaultValueRawValue = OuterEnumIntegerDefaultValueValueConverter.ToJsonValue(enumTest.OuterEnumIntegerDefaultValue);
            writer.WriteNumber("outerEnumIntegerDefaultValue", outerEnumIntegerDefaultValueRawValue);

            if (enumTest.OuterEnum == null)
                writer.WriteNull("outerEnum");
            else
            {
                var outerEnumRawValue = OuterEnumValueConverter.ToJsonValue(enumTest.OuterEnum.Value);
                if (outerEnumRawValue != null)
                    writer.WriteString("outerEnum", outerEnumRawValue);
                else
                    writer.WriteNull("outerEnum");
            }
        }
    }

    /// <summary>
    /// The EnumTestSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(EnumTest))]
    public partial class EnumTestSerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The EnumTestSerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public EnumTestSerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// EnumTestDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(EnumTest))]
    public partial class EnumTestDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// EnumTestDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public EnumTestDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
