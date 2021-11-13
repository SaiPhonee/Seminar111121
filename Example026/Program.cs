// 26. Возведите число А в натуральную степень B используя цикл

int toPower(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}

if (8 == toPower(2, 3))
{
    Console.WriteLine("Работает корректно");
}
else
{
    Console.WriteLine("Ошибка");
}