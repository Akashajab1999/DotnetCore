using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace SerilizationTest
{

    //decorator------typescript
    //annotationp----java
    //attribute---c#
    //metadata-----data about data --extra information about an entity product
    [Serializable]
    public class Product
    {


        public int Likes { get; set; }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //First part : cReating collection 

            Product theProduct = new Product();
            //Real World Object
            //Entity1


            theProduct.Id = 34;
            theProduct.Title = "Gerbera";
            theProduct.Description = "Wedding flower";
            theProduct.UnitPrice = 5;
            theProduct.Quantity = 123;
            theProduct.Likes = 4000;
            theProduct.ImageUrl = "/image/gerbera.jpg";


            Product theProduct1 = new Product();
            theProduct1.Id = 34;
            theProduct1.Title = "Tulip";
            theProduct1.Description = "Best flower";
            theProduct1.UnitPrice = 15;
            theProduct1.Quantity = 12367;
            theProduct1.Likes = 5000;
            theProduct1.ImageUrl = "/image/Tulip.jpg";


            //container :consist of two product instances
            List<Product> products= new List<Product>();
             products.Add(theProduct);
             products.Add(theProduct1);



        }
    }
}
