// 27. Определить количество цифр в числе
int number = 522333434;
int index = 1;
while (number > 10)
{
    number = number / 10;
    index++;
}
Console.WriteLine(index);
