namespace SampleNetCoreMVC.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BookDescription { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishingHouse { get; set; }

    }
}
