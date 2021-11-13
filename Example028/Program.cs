// 28. Подсчитать сумму цифр в числе
int SummaChisel(int number)
{
// int number = 2134;
int summa = 0;
while (number > 0)
{
    summa = summa + number % 10;
    number = number /10;
}
Console.WriteLine(summa);
return summa;
}
SummaChisel(2341);