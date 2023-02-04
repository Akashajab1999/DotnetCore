﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTaskApp{

    //Single Threaded Application

    class Program{
        

        //non blocking call
        public static async Task StoreData(){
        // defining callback function and invoking callback function
        //using internal  thread pool

          await Task.Run(()=>{
                Console.WriteLine("storing data to JSON file");
          });

        }

         public static async Task GetRemoteData(){
        
          await Task.Run(()=>{
                Console.WriteLine("getting data from external world ");
          });

        }


        static void Main (string[] args){
         // primary thread
         // is to invoke main entrypoint function
         Thread theTread = Thread.CurrentThread;
         Console.WriteLine("Main fn Thread="+ theTread.ManagedThreadId);
         //INvoke other reusable function 

         /* StoreData();
         GetRemoteData();
         */

         StoreData();
         GetRemoteData();
         Console.WriteLine("Hello World");
        }


    }
}