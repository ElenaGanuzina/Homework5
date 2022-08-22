// Задайте одномерный массив, заполненный случайными числами.  
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(0, 1000);
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

int FindUnevenElementsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 1) sum += array[i];
    }
    return sum;
}

int[] array = CreateArray(10);
PrintArray(array);
int sum = FindUnevenElementsSum(array);
Console.WriteLine($"Сумма нечетных элементов данного массива равна {sum}.");