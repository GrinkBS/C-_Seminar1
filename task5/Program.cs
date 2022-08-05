// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberb = Convert.ToInt32(Console.ReadLine());

if(numbera > numberb)
{
    Console.Write ("max = ");
    Console.WriteLine (numbera);
    Console.Write ("min = ");
    Console.Write (numberb);
}
else
{
    Console.Write ("max = ");
    Console.WriteLine (numberb);
    Console.Write ("min = ");
    Console.Write (numbera);
}