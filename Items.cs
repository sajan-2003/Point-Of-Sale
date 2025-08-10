namespace PointOfSale
{
    public class Items
    {

        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public int Barcode { get; set; }
        public int Unit { get; set; } = -1; // Default value
        public float UnitPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
        public int AdminID { get; set; }

    }
}
