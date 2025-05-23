// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class DataLakeStoreAccountResource : IJsonModel<DataLakeStoreAccountData>
    {
        private static DataLakeStoreAccountData s_dataDeserializationInstance;
        private static DataLakeStoreAccountData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DataLakeStoreAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataLakeStoreAccountData>)Data).Write(writer, options);

        DataLakeStoreAccountData IJsonModel<DataLakeStoreAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataLakeStoreAccountData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DataLakeStoreAccountData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataLakeStoreAccountData>(Data, options, AzureResourceManagerDataLakeStoreContext.Default);

        DataLakeStoreAccountData IPersistableModel<DataLakeStoreAccountData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataLakeStoreAccountData>(data, options, AzureResourceManagerDataLakeStoreContext.Default);

        string IPersistableModel<DataLakeStoreAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataLakeStoreAccountData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
