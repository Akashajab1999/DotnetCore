using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Serilization
{   

    [Serializable]
    class Product
    {

        
        int Id{get; set;} 
        string Name{get; set;}
        string Description{get; set;}


        public Product(int Id,string Name,string Description)
        {
            this.Id=Id;
            this.Name=Name;
            this.Description=Description;
        }
    }
}