using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Приходы, возвраты
    /// </summary>
    public record PaymentModel : PaymentBaseModel
    {
        /// <summary>
        /// Общее кол-во позиций в чеках (приход)
        /// </summary>
        [JsonPropertyName("receiptItemCount")]
        public int ReceiptItemCount { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку с НДС по ставке 0% (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_0")]
        public int GoodsSumNds0 { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку без НДС (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_No")]
        public int GoodsSumNdsNo { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку с НДС по ставке 10% (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_10")]
        public int GoodsSumNds10 { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку с НДС по ставке 20% (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_20")]
        public int GoodsSumNds20 { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку с НДС по расч. ставке 10/110 (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_10110")]
        public int GoodsSumNds10_110 { get; set; }

        /// <summary>
        /// Сумма продаж/возвратов по чеку с НДС по расч. ставке 20/120 (копейки)
        /// </summary>
        [JsonPropertyName("goods_sum_nds_20120")]
        public int GoodsSumNds20_120 { get; set; }
    }
}
