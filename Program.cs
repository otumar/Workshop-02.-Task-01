// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

System.Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (number.Length != 3) System.Console.WriteLine("Введено неверное число");
else 
{
int number1 = numberInt % 100 / 10;
System.Console.WriteLine ($"{number1} - Вторая цифра вашего числа");
}
