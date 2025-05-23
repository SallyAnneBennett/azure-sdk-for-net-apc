// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTlsCertificateProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTlsCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTlsCertificateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryTlsCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTlsCertificateProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CertificateType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(CertificateType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CertificateLocation))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(CertificateLocation);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ContainerRegistryTlsCertificateProperties IJsonModel<ContainerRegistryTlsCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTlsCertificateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTlsCertificateProperties(document.RootElement, options);
        }

        internal static ContainerRegistryTlsCertificateProperties DeserializeContainerRegistryTlsCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryCertificateType? type = default;
            string location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ContainerRegistryCertificateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryTlsCertificateProperties(type, location, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertificateType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertificateType))
                {
                    builder.Append("  type: ");
                    builder.AppendLine($"'{CertificateType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertificateLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CertificateLocation))
                {
                    builder.Append("  location: ");
                    if (CertificateLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertificateLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertificateLocation}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerRegistryTlsCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerRegistryContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTlsCertificateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryTlsCertificateProperties IPersistableModel<ContainerRegistryTlsCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerRegistryTlsCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTlsCertificateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTlsCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
