// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Inference
{
    /// <summary>
    /// Defines the response format for chat completions as JSON with a given schema.
    /// The AI model will need to adhere to this schema when generating completions.
    /// </summary>
    internal partial class ChatCompletionsResponseFormatJsonSchemaDefinition
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsResponseFormatJsonSchemaDefinition"/>. </summary>
        /// <param name="name"> A name that labels this JSON schema. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. </param>
        /// <param name="schema">
        /// The definition of the JSON schema. See https://json-schema.org/overview/what-is-jsonschema.
        /// Note that AI models usually only support a subset of the keywords defined by JSON schema.
        /// Consult your AI model documentation to determine what is supported.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="schema"/> is null. </exception>
        public ChatCompletionsResponseFormatJsonSchemaDefinition(string name, IDictionary<string, BinaryData> schema)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(schema, nameof(schema));

            Name = name;
            Schema = schema;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsResponseFormatJsonSchemaDefinition"/>. </summary>
        /// <param name="name"> A name that labels this JSON schema. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. </param>
        /// <param name="schema">
        /// The definition of the JSON schema. See https://json-schema.org/overview/what-is-jsonschema.
        /// Note that AI models usually only support a subset of the keywords defined by JSON schema.
        /// Consult your AI model documentation to determine what is supported.
        /// </param>
        /// <param name="description"> A description of the response format, used by the AI model to determine how to generate responses in this format. </param>
        /// <param name="strict">
        /// If set to true, the service will error out if the provided JSON schema contains keywords
        /// not supported by the AI model. An example of such keyword may be `maxLength` for JSON type `string`.
        /// If false, and the provided JSON schema contains keywords not supported by the AI model,
        /// the AI model will not error out. Instead it will ignore the unsupported keywords.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionsResponseFormatJsonSchemaDefinition(string name, IDictionary<string, BinaryData> schema, string description, bool? strict, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Schema = schema;
            Description = description;
            Strict = strict;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsResponseFormatJsonSchemaDefinition"/> for deserialization. </summary>
        internal ChatCompletionsResponseFormatJsonSchemaDefinition()
        {
        }

        /// <summary> A name that labels this JSON schema. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. </summary>
        public string Name { get; }
        /// <summary>
        /// The definition of the JSON schema. See https://json-schema.org/overview/what-is-jsonschema.
        /// Note that AI models usually only support a subset of the keywords defined by JSON schema.
        /// Consult your AI model documentation to determine what is supported.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> Schema { get; }
        /// <summary> A description of the response format, used by the AI model to determine how to generate responses in this format. </summary>
        public string Description { get; set; }
        /// <summary>
        /// If set to true, the service will error out if the provided JSON schema contains keywords
        /// not supported by the AI model. An example of such keyword may be `maxLength` for JSON type `string`.
        /// If false, and the provided JSON schema contains keywords not supported by the AI model,
        /// the AI model will not error out. Instead it will ignore the unsupported keywords.
        /// </summary>
        public bool? Strict { get; set; }
    }
}
