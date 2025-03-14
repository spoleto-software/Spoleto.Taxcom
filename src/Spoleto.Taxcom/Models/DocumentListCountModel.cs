using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Информация о количестве записей
    /// </summary>
    public record DocumentListCountModel
    {
        /// <summary>
        /// Всего записей
        /// </summary>
        [JsonPropertyName("recordCount")]
        public int RecordCount { get; set; }

        /// <summary>
        /// Записей с учетом фильтра
        /// </summary>
        [JsonPropertyName("recordFilteredCount")]
        public int RecordFilteredCount { get; set; }

        /// <summary>
        /// Записей в ответе
        /// </summary>
        [JsonPropertyName("recordInResponceCount")]
        public int RecordInResponceCount { get; set; }

        public override string ToString() => $"RecordInResponceCount = {RecordInResponceCount}";
    }
}