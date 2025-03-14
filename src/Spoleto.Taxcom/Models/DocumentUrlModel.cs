using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Ссылка на документ.
    /// </summary>
    public record DocumentUrlModel
    {
        /// <summary>
        /// Ссылка на документ.
        /// </summary>
        [JsonPropertyName("taxcomReceiptUrl")]
        public string TaxcomReceiptUrl { get; set; }
    }
}
