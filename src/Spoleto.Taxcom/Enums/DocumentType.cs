using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Типы документа.
    /// </summary>
    [JsonConverter(typeof(JsonDocumentTypeConverter))]
    public enum DocumentType
    {
        /// <summary>
        /// отчет об открытии смены
        /// </summary>
        ShiftOpeningReport = 2,

        /// <summary>
        /// отчет о текущем состоянии расчетов
        /// </summary>
        CurrentStateReport = 21,

        /// <summary>
        /// кассовый чек
        /// </summary>
        SalesSlip = 3,

        /// <summary>
        /// кассовый чек коррекции
        /// </summary>
        CorrectionSlip = 31,

        /// <summary>
        /// бланк строгой отчетности
        /// </summary>
        StrictReportingForm = 4,

        /// <summary>
        /// бланк строгой отчетности коррекции
        /// </summary>
        CorrectionStrictReportingForm = 41,

        /// <summary>
        /// отчет о закрытии смены
        /// </summary>
        ShiftClosingReport = 5
    }
}