using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.Taxcom.Converters
{
    public class JsonDocumentTypeConverter : JsonConverter<DocumentType>
    {
        public override DocumentType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int intValue;
            if (reader.TokenType == JsonTokenType.String)
                intValue = int.Parse(reader.GetString());
            else if (reader.TokenType == JsonTokenType.Number)
                intValue = (int)reader.GetDecimal();
            else
                throw new NotSupportedException();

            return (DocumentType)intValue;
        }

        public override void Write(Utf8JsonWriter writer, DocumentType value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue((int)value);
        }
    }
}
