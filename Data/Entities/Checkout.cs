using SampleNetCoreMVC.Data.Entities;

namespace SampleNetCoreMVC.Data.Entities
{
    public class Checkout
    {
        public int Id { get; set; }
        public DateTime CheckoutDate { get; set; }
        public ICollection<CheckoutItem> CheckoutList { get; set; }
    }
}
