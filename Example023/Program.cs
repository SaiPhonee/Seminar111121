// 23. Показать таблицу квадратов чисел от 1 до N 
int Power(int n)
{
    for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i} x {i} = {i * i}");
    return n;
}
Power(7);