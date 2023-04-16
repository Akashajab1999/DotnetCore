using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using SerilizationTest;
 

    //decorator------typescript
    //annotationp----java
    //attribute---c#
    //metadata-----data about data --extra information about an entity product
   
   


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
            List<Product> products = new List<Product>();
            products.Add(theProduct);
            products.Add(theProduct1);


            //Properly initilizer syntax

            products.Add(new Product { Id = 35, Title = "Carnation", Description = " White wash Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Lily", Description = "Delicate Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Lotus", Description = " Best Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Marigold", Description = " Worship Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Rose", Description = " Valentine  Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Tulip", Description = " Festival Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            products.Add(new Product { Id = 35, Title = "Auster", Description = " Beautiful Flower", UnitPrice = 10, Likes = 1000, ImageUrl = "/images/gerbera.jpg" });

            //Presentation logic 

            foreach (Product product in products)
            {
                //bind your data with console output screen
                //Dynamic data binding with Console UI
                Console.WriteLine($"Flower : {product.Title} :{product.Description}:{product.Likes}");
            }

            //Store these all flowers into file 
            //Persistance :Serilization
            //store state of object into file 
            //file should be binary
            //While dealing with system resources 
            //file,strean,database,socket,external web api
            //etc
            //Use Exception Handling
            //Logic for Serilization


            //Second Part: Serilization using Binary file

            try
            {
                Stream stream = new FileStream("product.bin", FileMode.Create,
                FileAccess.Write, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                //first parameter-------destination
                //second parameter------data

                formatter.Serialize(stream, products);
                stream.Close();

            }
            catch (Exception exp)
            {

            }
            finally
            {

            }

            //Logic for Deserilization
            Console.WriteLine("After Deserilization ,retrived Products......");
            try
            {

                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("product.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Product> productsFromFile = (List<Product>)formatter.Deserialize(stream);

                foreach (Product product in productsFromFile)
                {
                    Console.WriteLine($"{product.Title}:{product.Description}:{product.Likes}");

                }
                stream.Close();

            }
            catch (Exception exp)
            {

            }
            finally
            {

            }

            //Third part: Serilization using JSON file
            //Cross Platform data Storage using universal file format:JSON
            //JSON :Javascript object notation (JSON)
            //Java Application ,JAvascript application ,c++,.NET Framework,Mobile application
            //Inbuilt GoogleApp ---- Spreadsheet-----

            //[
            //{id:23, title:"gerbera", description:"best Flower"},
            //{id:23, title:"gerbera", description:"best Flower"},
            //{id:23, title:"gerbera", description:"best Flower"}
            //]

            try
            {
                //dynamic datatype variable
                var options = new JsonSerializerOptions { IncludeFields = true };
                var productsJson = JsonSerializer.Serialize<List<Product>>(products, options);
                string fileName = "products.json";
                File.WriteAllText(fileName, productsJson);

                //deserilization from json file
                string jsonString = File.ReadAllText(fileName);
                List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
                Console.WriteLine("Desrilizing data from json file");
                foreach (Product product in jsonProducts)
                {
                    Console.WriteLine($"{product.Title}:{product.Description}:{product.Likes}");
                    
                }

            }
            catch (Exception exp)
            {

            }
            finally
            {

            }

        }
    }

