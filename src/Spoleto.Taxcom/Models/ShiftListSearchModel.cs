using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Информация для поиска смен
    /// </summary>
    public record ShiftListSearchModel
    {
        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("fn")]
        public string FnFactoryNumber { get; set; }

        /// <summary>
        /// Начало периода в формате: 2017-03-20T10:47:00
        /// </summary>
        [JsonPropertyName("begin")]
        public DateTime DateBegin { get; set; }

        /// <summary>
        /// Окончание периода в формате: 2017-03-20T10:47:00
        /// </summary>
        [JsonPropertyName("end")]
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Номер страницы результатов
        /// </summary>
        /// <remarks>
        /// Необязательный параметр (если не передан, то возвращается первая страница результатов)
        /// </remarks>
        [JsonPropertyName("pn")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Кол-во результатов на странице (1-1000)
        /// </summary>
        /// <remarks>
        /// Необязательный параметр (если не передан, то возвращается 1000 записей)
        /// </remarks>
        [JsonPropertyName("ps")]
        public int? PageSearches { get; set; }
    }
}
