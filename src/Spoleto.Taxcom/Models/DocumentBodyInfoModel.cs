using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    //todo: переименовать свойства Tag* во что-то смысловое (если они нужны будут в бизнес логике)
    /// <summary>
    /// Содержимое документа.
    /// </summary>
    public record DocumentBodyInfoModel
    {
        /// <summary>
        /// номер ФН
        /// </summary>
        [JsonPropertyName("1041")]
        public string FnFactoryNumber { get; set; }

        /// <summary>
        /// регистрационный номер ККТ
        /// </summary>
        [JsonPropertyName("1037")]
        public string Tag1037 { get; set; }

        /// <summary>
        /// ИНН пользователя
        /// </summary>
        [JsonPropertyName("1018")]
        public string Inn { get; set; }

        /// <summary>
        /// номер ФД
        /// </summary>
        [JsonPropertyName("1040")]
        public int FdNumber { get; set; }

        /// <summary>
        /// дата, время
        /// </summary>
        [JsonPropertyName("1012")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Фискальный признак документа (1)
        /// </summary>
        [JsonPropertyName("1077")]
        public string Fpd { get; set; }

        /// <summary>
        /// номер смены
        /// </summary>
        [JsonPropertyName("1038")]
        public int NumberInShift { get; set; }

        /// <summary>
        /// номер чека за смену
        /// </summary>
        [JsonPropertyName("1042")]
        public int Tag1042 { get; set; }

        /// <summary>
        /// признак расчета
        /// </summary>
        [JsonPropertyName("1054")]
        public int Tag1054 { get; set; }//todo: use AccountingType ?

        /// <summary>
        /// сумма расчета, указанного в чеке (БСО)
        /// </summary>
        [JsonPropertyName("1020")]
        public int Tag1020 { get; set; }

        /// <summary>
        /// кассир
        /// </summary>
        [JsonPropertyName("1021")]
        public string Cashier { get; set; }

        /// <summary>
        /// сумма НДС чека по ставке 20%
        /// </summary>
        [JsonPropertyName("1102")]
        public int Nds20 { get; set; }

        /// <summary>
        /// наименование пользователя
        /// </summary>
        [JsonPropertyName("1048")]
        public string Tag1048 { get; set; }

        /// <summary>
        /// телефон или электронный адрес покупателя
        /// </summary>
        [JsonPropertyName("1008")]
        public string Tag1008 { get; set; }

        /// <summary>
        /// сумма по чеку (БСО) наличными
        /// </summary>
        [JsonPropertyName("1031")]
        public int Cash { get; set; }

        /// <summary>
        /// сумма по чеку (БСО) безналичными
        /// </summary>
        [JsonPropertyName("1081")]
        public int Electronic { get; set; }

        /// <summary>
        /// применяемая система налогообложения
        /// </summary>
        [JsonPropertyName("1055")]
        public int Tag1055 { get; set; }//todo: use TaxationSystem?

        /// <summary>
        /// предмет расчета
        /// </summary>
        [JsonPropertyName("1059")]
        public DocumentBodyItemInfoModel[] Items { get; set; }

        /// <summary>
        /// наименование документа
        /// </summary>
        [JsonPropertyName("1000")]
        public string DocumentName { get; set; }

        /// <summary>
        /// номер версии ФФД
        /// </summary>
        [JsonPropertyName("1209")]
        public int Tag1209 { get; set; }

        /// <summary>
        /// покупатель (клиент)
        /// </summary>
        [JsonPropertyName("1227")]
        public string Tag1227 { get; set; }

        /// <summary>
        /// ИНН покупателя (клиента)
        /// </summary>
        [JsonPropertyName("1228")]
        public string Tag1228 { get; set; }

        /// <summary>
        /// ИНН кассира
        /// </summary>
        [JsonPropertyName("1203")]
        public string CashierInn { get; set; }

        /// <summary>
        /// номер автомата
        /// </summary>
        [JsonPropertyName("1036")]
        public string Tag1036 { get; set; }

        /// <summary>
        /// адрес расчетов
        /// </summary>
        [JsonPropertyName("1009")]
        public string Tag1009 { get; set; }

        /// <summary>
        /// место расчетов
        /// </summary>
        [JsonPropertyName("1187")]
        public string Tag1187 { get; set; }

        /// <summary>
        /// сумма по чеку (БСО) предоплатой (зачетом аванса и (или) предыдущих платежей)
        /// </summary>
        [JsonPropertyName("1215")]
        public int? AdvancePayment { get; set; }

        /// <summary>
        /// сумма по чеку (БСО) постоплатой (в кредит)
        /// </summary>
        [JsonPropertyName("1216")]
        public int? PaymentCredit { get; set; }

        /// <summary>
        /// сумма по чеку (БСО) встречным предоставлением
        /// </summary>
        [JsonPropertyName("1217")]
        public int? PaymentTag1217 { get; set; }

        /// <summary>
        /// сумма НДС чека по ставке 10%
        /// </summary>
        [JsonPropertyName("1103")]
        public int Nds10 { get; set; }

        /// <summary>
        /// сумма расчета по чеку с НДС по ставке 0%
        /// </summary>
        [JsonPropertyName("1104")]
        public int Nds0 { get; set; }

        /// <summary>
        /// сумма расчета по чеку без НДС
        /// </summary>
        [JsonPropertyName("1105")]
        public int NondsSum { get; set; }

        /// <summary>
        /// сумма НДС чека по расч. ставке 20/120
        /// </summary>
        [JsonPropertyName("1106")]
        public int NdsC20 { get; set; }

        /// <summary>
        /// признак ККТ для расчетов только в Интернет
        /// </summary>
        [JsonConverter(typeof(JsonIntAsBoolConverter))]
        [JsonPropertyName("1108")]
        public bool IsInternet { get; set; }

        /// <summary>
        /// адрес электронной почты отправителя чека
        /// </summary>
        [JsonPropertyName("1117")]
        public string Tag1117 { get; set; }

        /// <summary>
        /// признак агента
        /// </summary>
        [JsonPropertyName("1057")]
        public int? Tag1057 { get; set; }

        /// <summary>
        /// телефон оператора перевода
        /// </summary>
        [JsonPropertyName("1075")]
        public string Tag1075 { get; set; }

        /// <summary>
        /// операция платежного агента
        /// </summary>
        [JsonPropertyName("1044")]
        public string Tag1044 { get; set; }

        /// <summary>
        /// телефон платежного агента
        /// </summary>
        [JsonPropertyName("1073")]
        public string Tag1073 { get; set; }

        /// <summary>
        /// телефон оператора по приему платежей
        /// </summary>
        [JsonPropertyName("1074")]
        public string Tag1074 { get; set; }

        /// <summary>
        /// наименование оператора перевода
        /// </summary>
        [JsonPropertyName("1026")]
        public string Tag1026 { get; set; }

        /// <summary>
        /// адрес оператора перевода
        /// </summary>
        [JsonPropertyName("1005")]
        public string Tag1005 { get; set; }

        /// <summary>
        /// ИНН оператора перевода
        /// </summary>
        [JsonPropertyName("1016")]
        public string Tag1016 { get; set; }

        /// <summary>
        /// телефон поставщика
        /// </summary>
        [JsonPropertyName("1171")]
        public string Tag1171 { get; set; }

        /// <summary>
        /// адрес сайта ФНС
        /// </summary>
        [JsonPropertyName("1060")]
        public string Tag1060 { get; set; }

        /// <summary>
        /// дополнительный реквизит чека (БСО)
        /// </summary>
        [JsonPropertyName("1192")]
        public string Tag1192 { get; set; }

        /// <summary>
        /// дополнительный реквизит пользователя
        /// </summary>
        [JsonPropertyName("1084")]
        public string Tag1084 { get; set; }

        /// <summary>
        /// QR-код
        /// </summary>
        [JsonPropertyName("1196")]
        public string QrCode { get; set; }

        public override string ToString() => $"ФД №{FdNumber} от {DateTime}";
    }
}
