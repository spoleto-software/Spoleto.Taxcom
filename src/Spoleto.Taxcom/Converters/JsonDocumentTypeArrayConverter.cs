using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.Taxcom.Converters
{
    public class JsonDocumentTypeArrayConverter : JsonConverter<DocumentType[]>
    {
        public override DocumentType[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array.");
            }

            var documentTypes = new List<DocumentType>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    break;
                }

                int intValue;
                if (reader.TokenType == JsonTokenType.String)
                {
                    intValue = int.Parse(reader.GetString());
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    intValue = (int)reader.GetDecimal();
                }
                else
                {
                    throw new NotSupportedException();
                }

                documentTypes.Add((DocumentType)intValue);
            }

            return documentTypes.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, DocumentType[] value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var documentType in value)
            {
                writer.WriteNumberValue((int)documentType);
            }

            writer.WriteEndArray();
        }
    }
}
