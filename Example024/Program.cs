// 24. Найти кубы чисел от 1 до N
int Vkub(int number)
{
    return number*number*number;
}
int n = 4;
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(Vkub(i));
}

