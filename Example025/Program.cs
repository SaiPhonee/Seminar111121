// 25. Найти сумму чисел от 1 до А
int summa = 0;
int Sum(int a)
{
    for (int i = 0; i <= a; i++)
    {
        // int summa = 0;
        summa = summa + i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {a} = {summa}");
    return summa;
}
Sum(5);