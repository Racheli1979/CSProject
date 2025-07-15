namespace BO
{
    /// <summary>
    /// רשומה לפרטי מבצע
    /// </summary>
    /// <param name="SaleId">מספר מזהה של המבצע</params>
    /// <param name="ProductId">מספר מזהה של המוצר</params>
    /// <param name="Amount">כמות נדרשת לקבלת המבצע</params>
    /// <param name="SalePrice">מחיר כולל מבצע</params>
    /// <param name="ForAllCustomers">האם רק ללקוחות מועדון?</params>
    /// <param name="StartSale">תאריך תחילת המבצע</params>
    /// <param name="EndSale">תאריך סיום המבצע</params>
    public class Sale
    {
        public int SaleId { get; init; }
        public int ProductId { get; init; }
        public int Amount { get; init; }
        public double SalePrice { get; init; }
        public bool ForAllCustomers { get; init; }
        public DateTime StartSale { get; init; }
        public DateTime EndSale { get; init; }

        public override string ToString() => this.ToStringProperty();
    }
}
