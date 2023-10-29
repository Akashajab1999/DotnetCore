static int SumOfNumbersGivenRange(int number1, int number2)
{
    int sum = 0;
    for (int i = number1; i <= number2; i++)
    {
        sum += i;
    }
    return sum;
}



int Sum= SumOfNumbersGivenRange(12,13);
Console.WriteLine(Sum);
