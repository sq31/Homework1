// Напишите программу, которая на вход принимает число и выдаёт, делится ли число на 3 без остатка

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%3==0)  
{
    Console.WriteLine("Число делится на 3");
}
else
{
Console.WriteLine("Число не делится на 3");
}
