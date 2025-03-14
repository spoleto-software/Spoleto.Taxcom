using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Список смен за период по ККТ
    /// </summary>
    public record ShiftListModel
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
        /// Смены
        /// </summary>
        [JsonPropertyName("records")]
        public List<ShiftModel> Records { get; set; }
    }
}
