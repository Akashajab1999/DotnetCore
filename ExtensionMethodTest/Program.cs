﻿using System;
namespace ExtensionMethodTest
{

    //what do you mean  by extending class ?
    //Inheritance
    //Base class
    //Derived class
    //Derived class is Base class

    //block inheritance for your class

    
   
    

    class Program
    {
        static void Main(String[] args){
            MathsHelper mathEngine=new MathsHelper();
            int number1 =45;
            int number2 =23;

            // Instance method call

            int result1=mathEngine.Addition(number1,number2);
            Console.WriteLine("Addition Result =" + result1);
            int result2=mathEngine.Subtraction(number1,number2);
            Console.WriteLine("Subtraction Result="+result2);

            //Extrension method call

            int result3 = mathEngine.Multiplication(number1,number2);
            Console.WriteLine("Multiplicatiopn result="+result3);

            int result4 =mathEngine.Division(number1,number2);
            Console.WriteLine("Division Result="+result4);



            Person thePerson = new Person();
            string fullName=thePerson.GetFullName();   //MemberFunction
            string country=thePerson.GetNationlityDetails();      //Extension method

            Console.WriteLine(fullName+ " "+country);
            string state ="Maharashtra";
            Console.WriteLine(state.GetStarPrefix());
        }
    }
}