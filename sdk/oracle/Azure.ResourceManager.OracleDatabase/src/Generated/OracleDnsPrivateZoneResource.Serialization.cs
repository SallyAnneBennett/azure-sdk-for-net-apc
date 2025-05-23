// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OracleDatabase
{
    public partial class OracleDnsPrivateZoneResource : IJsonModel<OracleDnsPrivateZoneData>
    {
        private static OracleDnsPrivateZoneData s_dataDeserializationInstance;
        private static OracleDnsPrivateZoneData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<OracleDnsPrivateZoneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<OracleDnsPrivateZoneData>)Data).Write(writer, options);

        OracleDnsPrivateZoneData IJsonModel<OracleDnsPrivateZoneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<OracleDnsPrivateZoneData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<OracleDnsPrivateZoneData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<OracleDnsPrivateZoneData>(Data, options, AzureResourceManagerOracleDatabaseContext.Default);

        OracleDnsPrivateZoneData IPersistableModel<OracleDnsPrivateZoneData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<OracleDnsPrivateZoneData>(data, options, AzureResourceManagerOracleDatabaseContext.Default);

        string IPersistableModel<OracleDnsPrivateZoneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<OracleDnsPrivateZoneData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
