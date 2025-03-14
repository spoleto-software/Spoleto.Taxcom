using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Информация для поиска ссылки на документ.
    /// </summary>
    public record DocumentUrlSearchModel
    {
        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("fn")]
        public string FnFactoryNumber { get; set; }

        /// <summary>
        /// Номер фискального документа
        /// </summary>
        [JsonPropertyName("fd")]
        public int FdNumber { get; set; }
    }
}
