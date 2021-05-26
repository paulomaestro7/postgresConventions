namespace postgresConventions.Model
{
    public class ItemsOrder : Base
    {
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
