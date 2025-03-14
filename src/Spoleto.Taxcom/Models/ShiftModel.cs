using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Смена
    /// </summary>
    public record ShiftModel
    {
        /// <summary>
        /// Номер ФН
        /// </summary>
        [JsonPropertyName("fnFactoryNumber")]
        public string FnFactoryNumber { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        [JsonPropertyName("shiftNumber")]
        public int ShiftNumber { get; set; }

        /// <summary>
        /// Дата открытия
        /// </summary>
        /// <remarks>
        /// Дата закрытия в формате: 2017-03-20T10:47:00
        /// </remarks>
        [JsonPropertyName("openDateTime")]
        public DateTime OpenDateTime { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        /// <remarks>
        /// Дата закрытия в формате: 2017-03-20T10:47:00
        /// </remarks>
        [JsonPropertyName("closeDateTime")]
        public DateTime? CloseDateTime { get; set; }

        /// <summary>
        /// Кол-во чеков за смену"
        /// </summary>
        [JsonPropertyName("receiptCount")]
        public int ReceiptCount { get; set; }
    }
}
