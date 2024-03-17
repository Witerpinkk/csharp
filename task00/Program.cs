/* Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
4 -> 16
-3 - 9
-7 -> 49

Console.WriteLine("new number");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}*/


/*
Напишите программу которая на вход принимает число и выдаёт её квадрат


Console.WriteLine("new number");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);*/

/*Напишите программу которая будет выдавать название дня недели по заданному номеру

int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("monday");
}
else 
if (number == 2)
{
    Console.WriteLine("tuesday");
}
else 
if (number == 3)
{
    Console.WriteLine("wednesday");
}
else 
if (number == 4)
{
    Console.WriteLine("thursdey");
}
else 
if (number == 5)
{
    Console.WriteLine("friday");
}
else 
if (number == 6)
{
    Console.WriteLine("saturday");
}
else 
if (number == 7 )
{
    Console.WriteLine("sunday");
}
else 
{
    Console.WriteLine("there is no such day");
}*/

/*Напишите программу которая на вход принимает одно число N а на выходе показывает все целые числа промежутки от -N до N

Console.WriteLine("new number");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <= number; i ++)
{
    Console.Write(i + " ");
}*/

/*Напишите программу которая принимает трёхзначное число а на выходе выводит последнюю цифру из этого числа*/

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number%10);
