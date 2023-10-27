

 
   Console.WriteLine("Enter Your Number");
    int num =int.Parse(Console.ReadLine());
    int octal =0;
    int rem ,i=1;

    while(num!=0){

        rem=num%8;
        num=num/8;
        octal += rem * i;
        i=i*10;
    }
    
    Console.WriteLine(octal);




