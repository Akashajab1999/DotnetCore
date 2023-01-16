using System;

namespace AnnonumousMethodTest
{

    public delegate void BasicOperation();
    public delegate void Dosomething();
    public delegate int annonymousoperation1(int x);
    public delegate int annonymousoperation2(int x,int y);

    class Program
    {
        //call back
        static void PrintReport()
        {
            Console.WriteLine(" Printing a report : graph,table,score ");
        }

        static void Main(string[] args)
        {

            //resister the function 
            //registering callback function
            BasicOperation method1 = new BasicOperation(PrintReport);
            //resolving name of the function at runtime
            method1();



            //Inline function 
            //annonymous method

            BasicOperation method2 = delegate ()
            {
                Console.WriteLine("Printing company annual report");
            };
            method2();


            Dosomething method3 = () => { Console.WriteLine("Akash is my name."); };   //Lambda function
            method3();


            annonymousoperation1 proxy1 = new annonymousoperation1(
              delegate (int x){
                return x * 2;}
            
            );
            Console.WriteLine( "{0}",proxy1(5));
            

            //use of Lambda
            annonymousoperation1 proxy2=x=>x*2;
            Console.WriteLine("{0}",proxy2(25));


            annonymousoperation2 ak = new annonymousoperation2(delegate(int x,int y){
                return x*y;
            });

            Console.WriteLine(ak(25,25));

            annonymousoperation2 aj =(x,y)=>x * y;
            Console.WriteLine(aj(50,50));
           
            annonymousoperation2 getBigInteger=(x,y)=>{if(x>y) return x; else return y;};
            Console.WriteLine(getBigInteger(10,20));

            Console.WriteLine("Welcome to .Net core programming");
        }
    }
}

