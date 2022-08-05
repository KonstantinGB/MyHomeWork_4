/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/


int VozvedenieVStepen( int numA, int numB)
{
    int count = 0;
    int result = 1;
    while (count < numB)
        {
            result = result * numA;
            count++;
        }
    return result;
}

Console.WriteLine("ВВедите два числа для для возведение первого в натуральную степень второго");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое, положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 < 0) Console.WriteLine("Второе число не является положительным");
else
{
    int stepen = VozvedenieVStepen(number1, number2);
    Console.WriteLine($"  {number1} в степени {number2} будет равно {stepen} ");
}