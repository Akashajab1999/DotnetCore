static string RemoveAdjacentDuplicates(string input)
{
    if (string.IsNullOrEmpty(input) || input.Length == 1)
    {
        return input;
    }

    char[] result = new char[input.Length];
    int resultIndex = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (i < input.Length - 1 && input[i] == input[i + 1])
        {
            // Skip adjacent duplicates.
            while (i < input.Length - 1 && input[i] == input[i + 1])
            {
                i++;
            }
        }
        else
        {
            result[resultIndex++] = input[i];
        }
        ;
    }
    string newString = new string(result, 0, resultIndex);

    // Recursively remove adjacent duplicates until no more can be found.
    if (newString.Length < input.Length)
    {
        return RemoveAdjacentDuplicates(newString);
    }

    return newString;
}


string  str="aaakkassshash";
Console.WriteLine(RemoveAdjacentDuplicates(str));