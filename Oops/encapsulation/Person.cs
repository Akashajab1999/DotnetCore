public class Person{
//The process of binding or grouping the State (Data Members) and Behaviour (Member Functions) together into a single unit (i.e. class, interface, struct, etc) is called encapsulation in C#. 
//The Encapsulation Principle ensures that the state and behavior of a unit cannot be accessed directly from other units.
    public string FirstName{get;set;}

    public string LastName{get;set;}


  public Person(string firstName,string lastName){


  this.FirstName=firstName;
    this.LastName=lastName;

  }


  public void GetPersonalInfo(){
     Console.WriteLine(FirstName +" "+LastName);
  }


    public void Eat(){
      Console.WriteLine("I am eating ");
    }




    public void Run(){
       Console.WriteLine("I am running");
    }
}