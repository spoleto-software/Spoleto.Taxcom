using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.Taxcom.Converters
{
    public class JsonIntAsBoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            bool boolValue;
            if (reader.TokenType == JsonTokenType.True)
            {
                boolValue = true;
            }
            else if (reader.TokenType == JsonTokenType.False)
            {
                boolValue = false;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                var intValue = (int)reader.GetDecimal();
                if (intValue == 0)
                {
                    boolValue = false;
                }
                else if (intValue == 1)
                {
                    boolValue = true;
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
            else
            {
                throw new NotSupportedException();
            }

            return boolValue;
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
