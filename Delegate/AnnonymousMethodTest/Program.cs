using System;
namespace AnnonumousMethodTest{

 public  delegate void BasicOperation();

    class Program{
      //call back
      static void PrintReport(){
        Console.WriteLine(" Printing a report : graph,table,score ");
      }

        static void Main(string[] args){

            //resister the function 
            //registering callback function
            BasicOperation method1= new BasicOperation(PrintReport);
            //resolving name of the function at runtime
            method1();



            //Inline function 
            //annonymous method

            BasicOperation method2= delegate(){
                Console.WriteLine("Printing company annual report");
            };
            method2();
        }
    }
}

