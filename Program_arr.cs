string[] array0 = new string[8] {"Hello", "Russia", "Denmark", "Kazan", "computer since", "2", ";-)", "15"};
string[] array1 = new string[array0.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

SecondArrayWithIF(array0, array1);
PrintArray(array1);