using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Список документов по смене
    /// </summary>
    public record DocumentListModel
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
        /// Информация о количестве записей
        /// </summary>
        [JsonPropertyName("counts")]
        public DocumentListCountModel Counts { get; set; }

        /// <summary>
        /// Документы
        /// </summary>
        [JsonPropertyName("records")]
        public List<DocumentModel> Records { get; set; }

        public override string ToString() => $"Количество документов: {Records?.Count ?? 0}";
    }
}
