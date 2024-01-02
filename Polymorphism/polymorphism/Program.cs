
// method overloading

Student student = new Student();

 String Employee=student.AddName("sahil","mankar");
  Console.WriteLine(Employee);

string employee=student.AddName("ritesh","Chopra");
 Console.WriteLine(employee);




// method overriding
College p1 = new Student();
 string c1=p1.CollegeName();
 p1.StudentDetails();
 Console.WriteLine(c1);
College p2 = new College();
 string c2=p2.CollegeName();
 Console.WriteLine(c2);

