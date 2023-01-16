using System;
namespace Banking{


 public delegate void AccountOperation();

 class Program{
    static void Main(string[] args){

        Handler theHandler=new Handler();
        //theHandler.BlockedAccount();
        //theHandler.SendEmailNotification();
        //theHandler.PayIncomeTax();

        AccountOperation operation1=new AccountOperation(theHandler.BlockedAccount);
        
        AccountOperation operation2=new AccountOperation(theHandler.SendEmailNotification);
        
        AccountOperation operation3=new AccountOperation(theHandler.PayIncomeTax);
        AccountOperation operation = operation1;
        operation+=operation2;
        operation+=operation3;
        operation();
        Console.WriteLine("hello Akash");
    }
 }   
}