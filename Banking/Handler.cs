using System;
namespace Banking
{
    public class Handler
    {
        public void BlockedAccount()
        {
            Console.WriteLine("The account has been blocked....");

        }
        public void SendEmailNotification()
        {
            Console.WriteLine(" Email notification has been sent to registered email adress");
        }

        public void PayIncomeTax()
        {
            Console.WriteLine("Income tax has been deducted from your Account by order....");
        }


    }
}
