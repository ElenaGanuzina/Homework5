int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
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


int[] MultiplyElements(int[] array)
{
    int length = array.Length;
    int length2 = 0;
    if (length % 2 == 0)
    {
        length2 = length / 2;
        int[] arr = new int [length2];
        int i = 0;
        int k = array.Length - 1;
        for(int j = 0; j < length2; j++)
        {
            arr[j] = array[i] * array[k];
            i++;
            k--;
        }
        return arr;
    }

    else
    {
        length2 = length / 2 + 1;
        int[] arr = new int [length2];
        int i = 0;
        int k = array.Length - 1;
        for(int j = 0; j < length2; j++)
        {
            arr[j] = array[i] * array[k];
            i++;
            k--;
        }
        arr[length2-1] = Convert.ToInt32(Math.Sqrt(arr[length2-1]));
        
        return arr;
    }
}


int[] array = CreateArray(5, 3, 50);
PrintArray(array);
int[] arr = MultiplyElements(array);
PrintArray(arr);

int[] array1 = CreateArray(6, 1, 100);
PrintArray(array1);
int[] arr1 = MultiplyElements(array1);
PrintArray(arr1);