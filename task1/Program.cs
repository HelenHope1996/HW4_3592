/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите первое число: ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите второе число: ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);
ToDegree(number1, number2);


void ToDegree(int a, int b)
{
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}