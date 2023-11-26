using System;

public static class ControlWork1
{
    public static void Main(string[] args)
    {
        string[] array = ["Hello", "2", "world", ":-)"];
        int count = FindCountOf3Sumbol(array);
        string[] newArray = FillArrayElement3Symbol(array, count);
        PrintArray(array);
        Console.Write(" -> ");
        PrintArray(newArray);
        Console.WriteLine(" ");

    }
    public static int FindCountOf3Sumbol (string[] array)
    {
        int countElement = 0;
        for(int i = 0; i < array.Length; i++)
        {
            string world = array[i];
            if (world.Length <= 3)
            {
                countElement++;
            }
        }
        return countElement;
    }
    public static string[] FillArrayElement3Symbol (string[] array, int count)
    {
        int j = 0;
        string[] newArray = new string[count];
        for (int i = 0; i < array.Length; i++)
        {
            string world = array[i];
            if(world.Length <= 3)
            {
                newArray[j] = world;
                j++;
            }
        }
        return newArray;
    }
    public static void PrintArray (string[] array)
    {
        int sizeArray = array.Length-1;
        Console.Write("[");
        for (int i = 0; i < sizeArray; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[sizeArray]}\"]");  
    }
}
