// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using PetStore;

namespace PetStore.Models
{
    /// <summary></summary>
    public partial class Insurance : IJsonModel<Insurance>
    {
        internal Insurance()
        {
        }

        void IJsonModel<Insurance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Insurance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Insurance)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("provider"u8);
            writer.WriteStringValue(Provider);
            writer.WritePropertyName("premium"u8);
            writer.WriteNumberValue(Premium);
            writer.WritePropertyName("deductible"u8);
            writer.WriteNumberValue(Deductible);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
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

        Insurance IJsonModel<Insurance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual Insurance JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Insurance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Insurance)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInsurance(document.RootElement, options);
        }

        internal static Insurance DeserializeInsurance(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provider = default;
            int premium = default;
            int deductible = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("provider"u8))
                {
                    provider = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("premium"u8))
                {
                    premium = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("deductible"u8))
                {
                    deductible = prop.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new Insurance(provider, premium, deductible, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<Insurance>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Insurance>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Insurance)} does not support writing '{options.Format}' format.");
            }
        }

        Insurance IPersistableModel<Insurance>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual Insurance PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Insurance>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInsurance(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Insurance)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Insurance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="insurance"> The <see cref="Insurance"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(Insurance insurance)
        {
            if (insurance == null)
            {
                return null;
            }
            return BinaryContent.Create(insurance, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="Insurance"/> from. </param>
        public static explicit operator Insurance(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInsurance(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
