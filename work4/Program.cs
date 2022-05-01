// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int R = number - 1;

Console.Write("Все четные числа от 1 до ");
Console.WriteLine(number);
if(number > 0)
{ 
    for (int i = 1; i <= number; i=i+1)
    {
      if(i % 2==0)
       {   
           Console.Write(i);
             {
                 if(i < R)
             {
            Console.Write(", ");
             }
             }
       }   
    }
}
else
{
    Console.Write("Необходимо ввести число больше 0");   
}