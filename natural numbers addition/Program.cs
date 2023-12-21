// static int SumOfNumbersGivenRange(int number1, int number2)
// {
//     int sum = 0;
//     for (int i = number1; i <= number2; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }



// int Sum= SumOfNumbersGivenRange(12,13);
// Console.WriteLine(Sum);

static string RelaceData(string data, char from, char to)
{
    string replacedData = "";
    //use the logic to replace  character
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] == from)
            replacedData += to;
        else
            replacedData += data[i];
    }
    return replacedData;
}

RelaceData("Akash",a,h);