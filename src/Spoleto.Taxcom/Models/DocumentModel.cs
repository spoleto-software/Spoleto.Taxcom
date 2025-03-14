using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Документ
    /// </summary>
    public record DocumentModel
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
        public string ShiftNumber { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        [JsonConverter(typeof(JsonDocumentTypeConverter))]
        [JsonPropertyName("documentType")]
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Дата и время в формате: 2017-03-20T10:47:00
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Номер ФД
        /// </summary>
        [JsonPropertyName("fdNumber")]
        public int FdNumber { get; set; }

        /// <summary>
        /// Номер за смену
        /// </summary>
        [JsonPropertyName("numberInShift")]
        public int NumberInShift { get; set; }

        /// <summary>
        /// Фискальный признак документа
        /// </summary>
        [JsonPropertyName("fpd")]
        public string Fpd { get; set; }

        /// <summary>
        /// Кассир
        /// </summary>
        [JsonPropertyName("cashier")]
        public string Cashier { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        [JsonPropertyName("taxationSystem")]
        public TaxationSystem? TaxationSystem { get; set; }

        /// <summary>
        /// Признак расчета
        /// </summary>
        [JsonPropertyName("accountingType")]
        public AccountingType? AccountingType { get; set; }

        /// <summary>
        /// Сумма (копейки)
        /// </summary>
        [JsonPropertyName("sum")]
        public int Sum { get; set; }

        /// <summary>
        /// Сумма нал (копейки)
        /// </summary>
        [JsonPropertyName("cash")]
        public int Cash { get; set; }

        /// <summary>
        /// Сумма безнал (копейки)
        /// </summary>
        [JsonPropertyName("electronic")]
        public int Electronic { get; set; }

        /// <summary>
        /// Сумма без НДС (копейки)
        /// </summary>
        [JsonPropertyName("nondsSum")]
        public int NondsSum { get; set; }

        /// <summary>
        /// Сумма с НДС 0% (копейки)
        /// </summary>
        [JsonPropertyName("nds0Sum")]
        public int Nds0Sum { get; set; }

        /// <summary>
        /// НДС 10% (копейки)
        /// </summary>
        [JsonPropertyName("nds10")]
        public int Nds10 { get; set; }

        /// <summary>
        /// НДС 18% (копейки)
        /// </summary>
        [JsonPropertyName("nds18")]
        public int Nds18 { get; set; }

        /// <summary>
        /// НДС 20% (копейки)
        /// </summary>
        [JsonPropertyName("nds20")]
        public int Nds20 { get; set; }

        /// <summary>
        /// НДС 10/110 (копейки)
        /// </summary>
        [JsonPropertyName("ndsC10")]
        public int NdsC10 { get; set; }

        /// <summary>
        /// НДС 18/118 (копейки)
        /// </summary>
        [JsonPropertyName("ndsC18")]
        public int NdsC18 { get; set; }

        /// <summary>
        /// НДС 20/120 (копейки)
        /// </summary>
        [JsonPropertyName("ndsC20")]
        public int NdsC20 { get; set; }

        public override string ToString() => $"{DocumentType}: ФД №{FdNumber} от {DateTime}";
    }
}
