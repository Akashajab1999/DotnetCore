List<int> numbers = new List<int>(){1,2,3,4,5,6};
  
//method syntax
var values = numbers.Where(x=>x>2).ToList();

foreach(var i in values){
    Console.WriteLine(i);
}




//It gives first value of your list
var num =numbers.FirstOrDefault(x=>x>2);
Console.WriteLine(num);





//query syntax
var num1 = from number in numbers where number>4 select number;
foreach(var i in num1){
    Console.WriteLine(i);
}

