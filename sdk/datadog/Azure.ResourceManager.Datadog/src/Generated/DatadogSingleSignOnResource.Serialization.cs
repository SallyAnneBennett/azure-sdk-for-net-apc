// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Datadog
{
    public partial class DatadogSingleSignOnResource : IJsonModel<DatadogSingleSignOnResourceData>
    {
        private static DatadogSingleSignOnResourceData s_dataDeserializationInstance;
        private static DatadogSingleSignOnResourceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DatadogSingleSignOnResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DatadogSingleSignOnResourceData>)Data).Write(writer, options);

        DatadogSingleSignOnResourceData IJsonModel<DatadogSingleSignOnResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DatadogSingleSignOnResourceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DatadogSingleSignOnResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DatadogSingleSignOnResourceData>(Data, options, AzureResourceManagerDatadogContext.Default);

        DatadogSingleSignOnResourceData IPersistableModel<DatadogSingleSignOnResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DatadogSingleSignOnResourceData>(data, options, AzureResourceManagerDatadogContext.Default);

        string IPersistableModel<DatadogSingleSignOnResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DatadogSingleSignOnResourceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
