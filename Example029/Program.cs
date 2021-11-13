// 29. Написать программу вычисления произведения чисел от 1 до N
int Multiplication(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {n} = {result}");
    return result;
}

Multiplication(5);
