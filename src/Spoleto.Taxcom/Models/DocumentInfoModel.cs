using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Данные документа
    /// </summary>
    public record DocumentInfoModel
    {
        /// <summary>
        /// Дата формирования ответа
        /// </summary>
        /// <remarks>
        /// Дата формирования ответа в формате: 2017-03-20T10:47:00
        /// </remarks>
        [JsonPropertyName("reportDate")]
        public DateTime ReportDate { get; set; }

        /// <summary>
        /// Дата формата документа
        /// </summary>
        /// <remarks>
        /// Например, 21.03.2017
        /// </remarks>
        [JsonPropertyName("documentFormatDate")]
        public string DocumentFormatDate { get; set; }

        /// <summary>
        /// Версия формата документа
        /// </summary>
        [JsonPropertyName("documentFormatVersion")]
        public string DocumentFormatVersion { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        [JsonConverter(typeof(JsonDocumentTypeConverter))]
        [JsonPropertyName("documentType")]
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Документ.
        /// </summary>
        [JsonPropertyName("document")]
        public DocumentBodyInfoModel Document { get; set; }

        public override string ToString() => $"{DocumentType}: {Document}";
    }
}
