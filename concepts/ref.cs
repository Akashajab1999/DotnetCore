
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;

namespace Tfl;
public static class Ref{
     
  //Creating Method with Ref Parameters
    public static void MathRef(int number1, int number2, ref int Addition, ref int Subtraction)
        {
            Addition = number1 + number2; //This will Update the Addition variable inside the Main method
            Subtraction = number1 - number2; //This will Update the Subtraction variable inside the Main method
        }
     

     public  static int Addition(ref int a,ref int b){
       int c = a+b;

       return c;
     }
}