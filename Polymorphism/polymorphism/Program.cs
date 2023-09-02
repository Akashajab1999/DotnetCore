
//method overloading

Student student = new Student();

 String Employee=student.AddName("Pragati","Ajab");
  Console.WriteLine(Employee);

string employee=student.AddName("Akash");
 Console.WriteLine(employee);




//method overriding
College p1 = new Student();
 string c1=p1.CollegeName();
 Console.WriteLine(c1);
College p2 = new College();
 string c2=p2.CollegeName();
 Console.WriteLine(c2);

