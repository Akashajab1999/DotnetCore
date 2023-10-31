static void FindCountOfNumberInArray()
{

    int[] arr = {0,10, 10, 11, 23, 15, 45, 12, 13, 15 };
    int odd_count = 0;
    int even_count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==0){

            continue;
        }
       else if (arr[i] % 2 == 0)
        {
            even_count++;
        }
        else
        {
            odd_count++;
        }
    }
    Console.WriteLine($"Even number count{even_count} and odd number count{odd_count}");
}


FindCountOfNumberInArray();