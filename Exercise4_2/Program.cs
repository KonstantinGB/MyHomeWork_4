/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int Summa (int number)
{
int sum = 0;
int count = 0;

    if(number < 0) number *= (-1);
        while(number > 0)
        {
            count = number % 10;
            number = number / 10;
            sum = sum + count;   
        }
        return sum;
}

Console.Write("Введите число что бы узнать сумму цифр в нём: ");
int num = Convert.ToInt32(Console.ReadLine());
int summa = Summa(num);
Console.WriteLine($"Сумма цифр в числе: {summa}");