// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
    }
    Console.WriteLine("]");
}

int FindEvenElementsAmount(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amount += 1;
        }
    }
    return amount;
}

int[] array = CreateArray(10);
PrintArray(array);
int amount = FindEvenElementsAmount(array);
Console.WriteLine($"Количество четных элементов в данном массиве равно {amount}.");