// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A set of resources that are used by the `file_search` tool. </summary>
    public partial class FileSearchToolResource
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

        /// <summary> Initializes a new instance of <see cref="FileSearchToolResource"/>. </summary>
        public FileSearchToolResource()
        {
            VectorStoreIds = new ChangeTrackingList<string>();
            VectorStores = new ChangeTrackingList<VectorStoreConfigurations>();
        }

        /// <summary> Initializes a new instance of <see cref="FileSearchToolResource"/>. </summary>
        /// <param name="vectorStoreIds">
        /// The ID of the vector store attached to this agent. There can be a maximum of 1 vector
        /// store attached to the agent.
        /// </param>
        /// <param name="vectorStores">
        /// The list of vector store configuration objects from Azure.
        /// This list is limited to one element.
        /// The only element of this list contains the list of azure asset IDs used by the search tool.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileSearchToolResource(IList<string> vectorStoreIds, IList<VectorStoreConfigurations> vectorStores, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorStoreIds = vectorStoreIds;
            VectorStores = vectorStores;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The ID of the vector store attached to this agent. There can be a maximum of 1 vector
        /// store attached to the agent.
        /// </summary>
        public IList<string> VectorStoreIds { get; }
        /// <summary>
        /// The list of vector store configuration objects from Azure.
        /// This list is limited to one element.
        /// The only element of this list contains the list of azure asset IDs used by the search tool.
        /// </summary>
        public IList<VectorStoreConfigurations> VectorStores { get; }
    }
}
