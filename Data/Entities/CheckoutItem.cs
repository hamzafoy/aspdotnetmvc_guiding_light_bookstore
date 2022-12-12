namespace SampleNetCoreMVC.Data.Entities
{
    public class CheckoutItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Checkout Checkout { get; set; }

    }
}
