// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class DeviceRegistryAssetEndpointProfileProperties : IUtf8JsonSerializable, IJsonModel<DeviceRegistryAssetEndpointProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceRegistryAssetEndpointProfileProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceRegistryAssetEndpointProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetEndpointProfileProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            writer.WritePropertyName("targetAddress"u8);
            writer.WriteStringValue(TargetAddress.AbsoluteUri);
            writer.WritePropertyName("endpointProfileType"u8);
            writer.WriteStringValue(EndpointProfileType);
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication, options);
            }
            if (Optional.IsDefined(AdditionalConfiguration))
            {
                writer.WritePropertyName("additionalConfiguration"u8);
                writer.WriteStringValue(AdditionalConfiguration);
            }
            if (Optional.IsDefined(DiscoveredAssetEndpointProfileRef))
            {
                writer.WritePropertyName("discoveredAssetEndpointProfileRef"u8);
                writer.WriteStringValue(DiscoveredAssetEndpointProfileRef);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DeviceRegistryAssetEndpointProfileProperties IJsonModel<DeviceRegistryAssetEndpointProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetEndpointProfileProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceRegistryAssetEndpointProfileProperties(document.RootElement, options);
        }

        internal static DeviceRegistryAssetEndpointProfileProperties DeserializeDeviceRegistryAssetEndpointProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uuid = default;
            Uri targetAddress = default;
            string endpointProfileType = default;
            DeviceRegistryAuthentication authentication = default;
            string additionalConfiguration = default;
            string discoveredAssetEndpointProfileRef = default;
            AssetEndpointProfileStatus status = default;
            DeviceRegistryProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uuid"u8))
                {
                    uuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAddress"u8))
                {
                    targetAddress = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointProfileType"u8))
                {
                    endpointProfileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = DeviceRegistryAuthentication.DeserializeDeviceRegistryAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalConfiguration"u8))
                {
                    additionalConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveredAssetEndpointProfileRef"u8))
                {
                    discoveredAssetEndpointProfileRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = AssetEndpointProfileStatus.DeserializeAssetEndpointProfileStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DeviceRegistryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceRegistryAssetEndpointProfileProperties(
                uuid,
                targetAddress,
                endpointProfileType,
                authentication,
                additionalConfiguration,
                discoveredAssetEndpointProfileRef,
                status,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetEndpointProfileProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceRegistryAssetEndpointProfileProperties IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceRegistryAssetEndpointProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetEndpointProfileProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceRegistryAssetEndpointProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
