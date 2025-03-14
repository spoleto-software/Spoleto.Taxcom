using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Информация для поиска списка документов по смене
    /// </summary>
    public record DocumentListSearchModel
    {
        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("fn")]
        public string FnFactoryNumber { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        [JsonPropertyName("shift")]
        public int? ShiftNumber { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        /// <remarks>
        /// Можно передавать несколько значений, например:
        /// …type=2&type=5…
        /// </remarks>
        [JsonConverter(typeof(JsonDocumentTypeArrayConverter))]
        [JsonPropertyName("type")]
        public DocumentType[] DocumentType { get; set; }

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
