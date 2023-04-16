using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Serilization
{

    public class Program{

        static void Main(String[] args)
        {
        string path=@"C:\LocalRepo\dotnet project\EssentialDotnet\serialize.png";
        Product p1 = new Product(2,"Rose","valentineFlower");
        FileStream stream= new FileStream(path,FileMode.OpenOrCreate);
        BinaryFormatter obj= new BinaryFormatter();
        obj.Serialize(stream,p1);
        stream.Close();
        Console.WriteLine("File created succesfully"+ path);
        //Console.ReadLine();



        }
    }
}