//var and dynamic keyword  difference

// var a = 10;      it gives compile time ,build time error
// a="number";


// dynamic a =10;
// a="akash";
// Console.WriteLine(a);

//ref and out paramters
using Tfl;
using System;

            //Calling the Method with the REF arguments
            int AdditionRef = 0;
            int SubtractionRef = 0;
            Ref.MathRef(200, 100, ref AdditionRef, ref SubtractionRef);
            Console.WriteLine($"AdditionRef: {AdditionRef}");
            Console.WriteLine($"SubtractionRef: {SubtractionRef}");

            //Call the Method with the OUT arguments
            int AdditionOut = 0;
            int SubtractionOut = 0;

            Out p1 = new Out();
            p1.MathOut(200, 100, out AdditionOut, out SubtractionOut);
            Console.WriteLine($"AdditionOut: {AdditionOut}");
            Console.WriteLine($"SubtractionOut: {SubtractionOut}");

            Console.ReadKey();
    

      

      

