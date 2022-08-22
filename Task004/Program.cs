// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write("; ");
        Console.Write(array[index]);
    }
    Console.WriteLine("]");
}

double FindDifferenceMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    
    double difference = max - min;
    return difference;
}

double[] array = CreateArray(5);
PrintArray(array);
double difference = FindDifferenceMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}.");