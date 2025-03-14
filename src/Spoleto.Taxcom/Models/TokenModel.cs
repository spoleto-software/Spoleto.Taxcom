using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    public record TokenModel
    {
        [JsonPropertyName("sessionToken")]
        public string SessionToken { get; set; }

        public override string ToString() => SessionToken;
    }
}
