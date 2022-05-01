// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if(number1>number2)
{
    max = number1;   
}
else
{   
    max = number2;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
