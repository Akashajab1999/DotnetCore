using System;

namespace LINQDemoTest{


    public class Program{

        static void Main(string[] args){
        Program theProgram= new Program();
        Console.WriteLine("Demo for Reflection");
        Type thetype1=theProgram.GetType();
        Console.WriteLine("Type of thePOrogram Variable"+thetype1.Name);
        var instance= new {Id=34, Firstname="Ravi",Lastname="Tambade",EmailAddress="ravi.Tambade@transflower.in",ContactNumber="9881735801",
        Location=new {
            Landmark="Walvekar Garden",
            City="Pune",
            State="Maharashtra",
            Country="India"
        }
        };
        Type theType2=instance.GetType();
        Console.WriteLine("Type of theType2 " +theType2.Name);
        Console.WriteLine("Demo for Annonumous Data type....");
        Console.WriteLine(instance.Firstname+" "+instance.Lastname);
        Console.WriteLine(instance.Location.Country);
        Console.WriteLine(instance.Location.State);
        Console.WriteLine(instance.Location.City);
        Console.WriteLine(instance.Location.Landmark);
        Console.WriteLine("Hello World");
             }
    }
}