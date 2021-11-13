// 31. Задать массив из 8 элементов и вывести их на экран 
int[] Array(int size)
{
    int[] array = new int[8];
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    return array;
}

Array(8);