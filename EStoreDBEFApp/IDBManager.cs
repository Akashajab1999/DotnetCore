using System.Collections.Generic;
namespace EStoreDBEFApp{
    public interface IDBManager{

        List<Product> GetAll();
        Product GetById(int Id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int Id);

    }
}