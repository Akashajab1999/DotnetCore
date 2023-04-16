
namespace SerilizationTest{
 [Serializable]
public class Product{
     public int Likes { get; set; }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
}

}