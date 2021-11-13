// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int[] Arr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " ");

    }
    return array;
}
Arr(10);