// 25. Найти сумму чисел от 1 до А
int Sum(int a)
{
    int summa = 0;
    for (int i = 0; i <= a; i++)
    {
        // int summa = 0;
        summa = summa + i;
    }
    // Console.WriteLine($"Сумма чисел от 1 до {a} = {summa}");
    return summa;
}
if (6 == Sum(3))
{
    Console.WriteLine("Работает корректно");
}
else
{
    Console.WriteLine("Ошибка");
}