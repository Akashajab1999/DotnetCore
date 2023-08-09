using System.Runtime.Serialization.Formatters.Binary;
using Seri;
namespace Serilization
{

    public class Program{

        static void Main(String[] args)
        {
        string path=@"C:\LocalRepo\dotnet project\EssentialDotnet\serialize.txt";
        //Product p1 = new Product(2,"Rose","valentineFlower");
        //  FileStream stream= new FileStream(path,FileMode.OpenOrCreate);
        //  BinaryFormatter obj= new BinaryFormatter();
        //  obj.Serialize(stream,p1);
        //  stream.Close();
        //  Console.WriteLine("File created succesfully"+ path);
        //   Console.ReadLine();
        

        

         FileStream stream= new FileStream(path,FileMode.Open);
         BinaryFormatter obj= new BinaryFormatter();
         Product p1= (Product)obj.Deserialize(stream);
         Console.WriteLine("Data retrived successfully : " + p1.Id+" "+p1.Name+" "+p1.Description);
         Console.ReadLine();


        }
    }
}