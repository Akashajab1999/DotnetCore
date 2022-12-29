namespace Banking
{
   //used as blueprint for creating number of instances
   
    public class Account
    {
        //Auto property
        
        public double Balance{get; set ;}

        public Account(double amount){
            this.Balance=amount;
        }

        /*public void Monitor(){
            if(this.Balance<5000){
                //static linking of behaviour
                //applying Dynamic linking
                //Handler.BlockedAccount();
            }
            else if(this.Balance>=250000){
                //static linking of behaviour
                //applying Dynamic linking
                //Handler.PayIncomeTax();
            }
        }
        public void Deposit(double amount){
            this.Balance+=amount;
            Monitor();
        }

        public void Withdraw(double amount){
            this.Balance-=amount;
            Monitor();
        }
        public static Account Create(double initialAmount){
            Account account =new Account(initialAmount);
            return account;
        }*/
        
    }
}