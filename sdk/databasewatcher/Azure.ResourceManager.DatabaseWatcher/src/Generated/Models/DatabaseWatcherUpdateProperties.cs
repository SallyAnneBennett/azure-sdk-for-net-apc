// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseWatcher.Models
{
    /// <summary> The updatable properties of the Watcher. </summary>
    public partial class DatabaseWatcherUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="DatabaseWatcherUpdateProperties"/>. </summary>
        public DatabaseWatcherUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseWatcherUpdateProperties"/>. </summary>
        /// <param name="datastore"> The data store for collected monitoring data. </param>
        /// <param name="defaultAlertRuleIdentityResourceId"> The resource ID of a user-assigned managed identity that will be assigned to a new alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseWatcherUpdateProperties(DatabaseWatcherDatastore datastore, ResourceIdentifier defaultAlertRuleIdentityResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Datastore = datastore;
            DefaultAlertRuleIdentityResourceId = defaultAlertRuleIdentityResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The data store for collected monitoring data. </summary>
        public DatabaseWatcherDatastore Datastore { get; set; }
        /// <summary> The resource ID of a user-assigned managed identity that will be assigned to a new alert rule. </summary>
        public ResourceIdentifier DefaultAlertRuleIdentityResourceId { get; set; }
    }
}
