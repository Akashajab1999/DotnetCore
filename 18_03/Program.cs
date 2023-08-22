using System.Runtime.CompilerServices;

namespace DemoApp{

 class  Person{
        // member variables
        public string firstName;
        public string lastName;
        public int age;

        // member functions
        // default constructor
        public Person(){
                firstName="Ravi";
                lastName="Tambade";
                age=46;
        }

        // Parameterized contstructor
        public Person(string fname, string lname, int ag){
            this.firstName=fname;
            this.lastName=lname;
            this.age=ag;
        }

        // static functions


    }
    public class handler{

     public  static void play(){
        Console.WriteLine("akash plays cricket");
       }
    }


    public class program{
    

         static void Display(){
            Console.WriteLine("Processing Display logic");
        }

        static void Show(){
            Console.WriteLine("Processing Show logic");
        }

       
       
         static void Main(string[] args){
            

            // Display();
 

            // handler.play();


             Person p = new Person("Akash","Ajab",12);
              Console.WriteLine(p.firstName +" "+ p.lastName);
         }

        
    }
}
