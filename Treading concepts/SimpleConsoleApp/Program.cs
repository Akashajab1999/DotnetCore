using System;
using System.Threading;

namespace SimpleConsoleApp
{

    // Multitheded Application
   class Program{

    //need to execute both functions is independent manner
    static void StoreData(){

        Thread theThread = Thread.CurrentThread;
        Console.WriteLine("StoreDAta fn Thred="+ theThread.ManagedThreadId);
        Console.WriteLine("Storing data into JSON file");
        Thread.Sleep(3000);
        Console.WriteLine("Data is succesfully Write in JSON file");
    }

    static void GetRemoteData(){
        Thread theThread = Thread.CurrentThread;
        Console.WriteLine("GetRemoteDta fn Thred="+ theThread.ManagedThreadId);
        Console.WriteLine("Getting users data from git reporisotory");
        Thread.Sleep(4000);
        //access data from external apliocation using rpc 
        Console.WriteLine("data is  recived from remote server");
        
    }
        
        static void Main (string[] argument){

            //Primary thread

        Thread theThread = Thread.CurrentThread;
        Console.WriteLine("Main function Invoker="+ theThread.ManagedThreadId);
        Thread.Sleep(3000);
        Display();

        //Creating two secondary Threded using .NET SDK

        ThreadStart theDelegate1= new ThreadStart(StoreData);
        Thread thread2=new Thread(theDelegate1);


        ThreadStart theDelegate2= new ThreadStart(StoreData);
        Thread thread3=new Thread(theDelegate2);

        thread2.Start();
        thread3.Start();
        Console.WriteLine(" MAin function is about to be terminated....");

        }


        public static void Display(){
        Thread theThread = Thread.CurrentThread;
        Console.WriteLine("Display fn thred="+ theThread.ManagedThreadId);
        Console.WriteLine("Displaying product catalog data");

        }

   } 
}