using System;
namespace Banking{


 public delegate void AccountOperation();

 class Program{
    static void Main(string[] args){

        Handler theHandler=new Handler();
        theHandler.BlockedAccount();
        theHandler.SendEmailNotification();
        theHandler.PayIncomeTax();
    }
 }   
}