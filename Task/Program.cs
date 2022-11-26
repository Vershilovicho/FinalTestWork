string[] sourceArray = { "hello", "2", "world", ":-)" };
string[] result = LessThan(sourceArray, 3);
PrintArray(result);

string[] LessThan(string[] array, int n)
{
    string[] newarray = new string[CountString(array, n)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            newarray[j] = array[i];
            j++;
        }
    }

    return newarray;
}

int CountString(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) count++;

    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

