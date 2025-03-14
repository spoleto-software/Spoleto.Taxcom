using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.Taxcom.Converters
{
    public class JsonDecimalConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var strValue = reader.GetString();
                if (strValue == "1.")
                {
                    return 1M;
                }
                else if (decimal.TryParse(strValue, NumberStyles.Any, CultureInfo.InvariantCulture, out var value1))
                {
                    return value1;
                }
                else if (decimal.TryParse(strValue, out var value2))
                {
                    return value2;
                }
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                var value = reader.GetDecimal();
                return value;
            }

            throw new NotSupportedException();
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
