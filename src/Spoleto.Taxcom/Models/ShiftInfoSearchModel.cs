using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Информация для поиска смены.
    /// </summary>
    public record ShiftInfoSearchModel
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
        public int Shift { get; set; }
    }
}
