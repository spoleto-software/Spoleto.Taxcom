using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Корректировки
    /// </summary>
    public record PaymentBaseModel
    {
        /// <summary>
        /// Сумма (копейки)
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

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
        /// Кол-во чеков (приход)
        /// </summary>
        [JsonPropertyName("receiptCount")]
        public int ReceiptCount { get; set; }

        /// <summary>
        /// Сумма расчета по чеку с НДС по ставке 0% (копейки)
        /// </summary>
        [JsonPropertyName("nds0Total")]
        public int Nds0Total { get; set; }

        /// <summary>
        /// Сумма расчета по чеку без НДС (копейки)
        /// </summary>
        [JsonPropertyName("noNDSTotal")]
        public int NoNDSTotal { get; set; }

        /// <summary>
        /// Сумма НДС чека по ставке 10% (копейки)
        /// </summary>
        [JsonPropertyName("nds10")]
        public int Nds10 { get; set; }

        /// <summary>
        /// Сумма НДС чека по ставке 18% (копейки)
        /// </summary>
        [JsonPropertyName("nds18")]
        public int Nds18 { get; set; }

        /// <summary>
        /// Сумма НДС чека по ставке 20% (копейки)
        /// </summary>
        [JsonPropertyName("nds20")]
        public int Nds20 { get; set; }

        /// <summary>
        /// Сумма НДС чека по расч. ставке 10/110 (копейки)
        /// </summary>
        [JsonPropertyName("nds10_110")]
        public int Nds10_110 { get; set; }

        /// <summary>
        /// Сумма НДС чека по расч. ставке 18/118 (копейки)
        /// </summary>
        [JsonPropertyName("nds18_118")]
        public int Nds18_118 { get; set; }

        /// <summary>
        /// Сумма НДС чека по расч. ставке 20/120 (копейки)
        /// </summary>
        [JsonPropertyName("nds20_120")]
        public int Nds20_120 { get; set; }
    }
}
