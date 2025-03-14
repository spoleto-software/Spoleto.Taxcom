using System.Text.Json.Serialization;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Данные смены
    /// </summary>
    public record ShiftBodyInfoModel
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
        public int ShiftNumber { get; set; }

        /// <summary>
        /// Дата открытия
        /// </summary>
        /// <remarks>
        /// Дата закрытия в формате: 2017-03-20T10:47:00
        /// </remarks>
        [JsonPropertyName("openDateTime")]
        public DateTime OpenDateTime { get; set; }

        /// <summary>
        /// Номер ФД отчета об открытии смены
        /// </summary>
        [JsonPropertyName("openFdNumber")]
        public int OpenFdNumber { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        /// <remarks>
        /// Дата закрытия в формате: 2017-03-20T10:47:00
        /// </remarks>
        [JsonPropertyName("closeDateTime")]
        public DateTime? CloseDateTime { get; set; }

        /// <summary>
        /// Номер ФД отчета об закрытии смены
        /// </summary>
        [JsonPropertyName("closeFdNumber")]
        public int? CloseFdNumber { get; set; }

        /// <summary>
        /// Кассир
        /// </summary>
        [JsonPropertyName("cashier")]
        public string Cashier { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        [JsonPropertyName("state")]
        public ShiftState State { get; set; }

        /// <summary>
        /// Приход
        /// </summary>
        [JsonPropertyName("income")]
        public PaymentModel Income { get; set; }

        /// <summary>
        /// Возврат прихода
        /// </summary>
        [JsonPropertyName("incomeReturn")]
        public PaymentModel IncomeReturn { get; set; }

        /// <summary>
        /// Коррекция прихода
        /// </summary>
        [JsonPropertyName("incomeCorrection")]
        public PaymentBaseModel IncomeCorrection { get; set; }

        /// <summary>
        /// Расход
        /// </summary>
        [JsonPropertyName("expenditure")]
        public PaymentModel Expenditure { get; set; }

        /// <summary>
        /// Возврат расхода
        /// </summary>
        [JsonPropertyName("expenditureReturn")]
        public PaymentModel ExpenditureReturn { get; set; }

        /// <summary>
        /// Коррекция расхода
        /// </summary>
        [JsonPropertyName("expenditureCorrection")]
        public PaymentModel ExpenditureCorrection { get; set; }
    }
}
