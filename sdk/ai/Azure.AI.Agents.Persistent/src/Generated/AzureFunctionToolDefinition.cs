// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The input definition information for a azure function tool as used to configure an agent. </summary>
    public partial class AzureFunctionToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="AzureFunctionToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalAzureFunction"> The definition of the concrete function that the function tool should call. </param>
        internal AzureFunctionToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalAzureFunctionDefinition internalAzureFunction) : base(type, serializedAdditionalRawData)
        {
            InternalAzureFunction = internalAzureFunction;
        }

        /// <summary> Initializes a new instance of <see cref="AzureFunctionToolDefinition"/> for deserialization. </summary>
        internal AzureFunctionToolDefinition()
        {
        }
    }
}
