using System.Text.Json.Serialization;
using Spoleto.Taxcom.Converters;

namespace Spoleto.Taxcom
{
    //todo: переименовать свойства Tag* во что-то смысловое (если они нужны будут в бизнес логике)
    /// <summary>
    /// Содержимое документа: предмет расчета.
    /// </summary>
    public record DocumentBodyItemInfoModel
    {
        /// <summary>
        /// наименование предмета расчета
        /// </summary>
        [JsonPropertyName("1030")]
        public string Name { get; set; }

        /// <summary>
        /// цена за единицу предмета расчета с учетом скидок и наценок
        /// </summary>
        [JsonPropertyName("1079")]
        public int Cost { get; set; }

        /// <summary>
        /// количество предмета расчета
        /// </summary>
        [JsonConverter(typeof(JsonDecimalConverter))]
        [JsonPropertyName("1023")]
        public decimal Amount { get; set; }

        /// <summary>
        /// сумма НДС по ставке 20%
        /// </summary>
        [JsonPropertyName("1102")]
        public int Nds20 { get; set; }

        /// <summary>
        /// стоимость предмета расчета с учетом скидок и наценок
        /// </summary>
        [JsonPropertyName("1043")]
        public int Value { get; set; }

        /// <summary>
        /// признак предмета расчета
        /// </summary>
        /// <remarks>
        ///  "1" – о реализуемом товаре, за исключением подакцизного товара (наименование и иные сведения, описывающие товар),
        ///  "2" - о реализуемом подакцизном товаре (наименование и иные сведения, описывающие товар),
        ///  "3" – работа,
        ///  "4" – услуга,
        ///  http://www.consultant.ru/document/cons_doc_LAW_214339/99a8c12e79d62b38305992f3fd4ec2d4bdf8dfd9/#dst5947
        /// </remarks>
        [JsonPropertyName("1212")]
        public int? Tag1212 { get; set; }

        /// <summary>
        /// признак агента по предмету расчета
        /// </summary>
        [JsonPropertyName("1222")]
        public int? Tag1222 { get; set; }

        /// <summary>
        /// данные агента
        /// </summary>
        [JsonPropertyName("1223")]
        public string Tag1223 { get; set; }

        /// <summary>
        /// данные поставщика
        /// </summary>
        [JsonPropertyName("1224")]
        public string Tag1224 { get; set; }

        /// <summary>
        /// ИНН поставщика
        /// </summary>
        [JsonPropertyName("1226")]
        public string Tag1226 { get; set; }

        /// <summary>
        /// единица измерения предмета расчета
        /// </summary>
        [JsonPropertyName("1197")]
        public string Tag1197 { get; set; }

        /// <summary>
        /// код товара
        /// </summary>
        [JsonPropertyName("1162")]
        public string Tag1162 { get; set; }

        /// <summary>
        /// код страны происхождения товара
        /// </summary>
        [JsonPropertyName("1230")]
        public string Tag1230 { get; set; }

        /// <summary>
        /// номер таможенной декларации
        /// </summary>
        [JsonPropertyName("1231")]
        public string Tag1231 { get; set; }

        /// <summary>
        /// размер НДС за единицу предмета расчета
        /// </summary>
        [JsonPropertyName("1198")]
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// ставка НДС
        /// </summary>
        [JsonPropertyName("1199")]
        public decimal? VatValue { get; set; }

        /// <summary>
        /// сумма НДС за предмет расчета
        /// </summary>
        [JsonPropertyName("1200")]
        public decimal? VatSum { get; set; }

        /// <summary>
        /// акциз
        /// </summary>
        [JsonPropertyName("1229")]
        public string Tag1229 { get; set; }

        /// <summary>
        /// дополнительный реквизит предмета расчета
        /// </summary>
        [JsonPropertyName("1191")]
        public string Tag1191 { get; set; }

        public override string ToString() => $"{Name} - {Value}";

    }
}
