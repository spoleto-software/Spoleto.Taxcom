namespace Spoleto.Taxcom
{
    /// <summary>
    /// Система налогообложения
    /// </summary>
    public enum TaxationSystem
    {
        /// <summary>
        /// ОСН
        /// </summary>
        OSN,

        /// <summary>
        /// УСН доход
        /// </summary>
        USNIncome,

        /// <summary>
        /// УСН доход-расход
        /// </summary>
        USNIncomeExpenditure,

        /// <summary>
        /// ЕНВД
        /// </summary>
        ENVD,

        /// <summary>
        /// ЕСН
        /// </summary>
        ESN,

        /// <summary>
        /// Патент
        /// </summary>
        Patent
    }
}