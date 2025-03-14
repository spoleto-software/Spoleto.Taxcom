using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Сводные данные по смене.
    /// </summary>
    public record ShiftInfoModel
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
        /// Данные смены
        /// </summary>
        [JsonPropertyName("shift")]
        public ShiftBodyInfoModel Shift { get; set; }
    }
}
