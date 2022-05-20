namespace ASP_MVC_Exo_01.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? Discount { get; set; }
        public string Reference { get; set; }

        public double? PriceDiscounted
        {
            get
            {
                return (Discount is null) ? null : Price - (Price * Discount / 100);
            }
        }
    }
}
