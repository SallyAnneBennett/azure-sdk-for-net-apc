// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationRunbookResource : IJsonModel<AutomationRunbookData>
    {
        private static AutomationRunbookData s_dataDeserializationInstance;
        private static AutomationRunbookData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<AutomationRunbookData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomationRunbookData>)Data).Write(writer, options);

        AutomationRunbookData IJsonModel<AutomationRunbookData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomationRunbookData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<AutomationRunbookData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutomationRunbookData>(Data, options, AzureResourceManagerAutomationContext.Default);

        AutomationRunbookData IPersistableModel<AutomationRunbookData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomationRunbookData>(data, options, AzureResourceManagerAutomationContext.Default);

        string IPersistableModel<AutomationRunbookData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomationRunbookData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
