public class Person{
   public string Name{get;set;}

   public Person(string _name){
      this.Name=_name;
   }

   public string GetName(){

   Console.WriteLine("My name is" +" "+this.Name);
   return "";
   }

    public void Run(){

    Console.WriteLine("I am Running");
   }
}