namespace Group4_IT3045_FinalProject.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string AppleProducts { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public int YearOfFirstRelease { get; set; }

        public Product() { }

        public Product(int iD, string appleProducts, string color, int price, int yearOfFirstRelease)
        {
            ID = iD;
            AppleProducts = appleProducts;
            Color = color;
            Price = price;
            YearOfFirstRelease = yearOfFirstRelease;
        }
    }
}

