using System;
namespace Catalog{
    public class ProductManager{
        public static List<Product> GetAllProducts(){

        List<Product> allProducts= new List<Product>();

        allProducts= GetAllProductsFromDatabase();
        return allProducts;

        }
        


        public static List<Product> GetAllProductsFromDatabase(){
            List<Product> allProducts = ProductDBManager.GetAll();
            return allProducts;

        }
        
        public static Product Get(int id){
            List<Product> products = GetAllProducts();
            Product theProduct = products.FirstOrDefault(p=>p.Id==id);
            return theProduct;
        }

        public static bool Update(Product product){
            bool status= false;
            status=ProductDBManager.Update(product);
            return status;
        }
        public static bool Insert(Product product){
            bool status= false;
            status=ProductDBManager.Insert(product);
            return status;
        }

        public static bool Delete(int id){
            bool status= false;
            status=ProductDBManager.Delete(id);
            return status;
        }




    }
}