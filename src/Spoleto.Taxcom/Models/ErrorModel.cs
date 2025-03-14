using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Ответ сервиса с ошибкой.
    /// </summary>
    public record ErrorModel
    {
        /// <summary>
        /// Api код ошибки
        /// </summary>
        [JsonPropertyName("apiErrorCode")]
        public int ApiErrorCode { get; set; }

        /// <summary>
        /// Http код ошибки
        /// </summary>
        [JsonPropertyName("httpErrorCode")]
        public int HttpErrorCode { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Общее описание ошибки
        /// </summary>
        [JsonPropertyName("commonDescription")]
        public string CommonDescription { get; set; }

        /// <summary>
        /// Детальная информация ошибки
        /// </summary>
        [JsonPropertyName("details")]
        public string Details { get; set; }

        public string Label => Message ?? $"{CommonDescription}; {Details}; ApiErrorCode = {ApiErrorCode}.";

        public override string ToString() => Label;
    }
}
