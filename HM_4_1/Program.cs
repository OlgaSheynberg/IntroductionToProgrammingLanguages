Console.Clear();
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B: ");
int b = int.Parse(Console.ReadLine());
int c=1;

for(int i=1;i<= Math.Abs(b);i++)

{
c= c*a;
}
Console.WriteLine("Число "+a +" в натуральной степени числа"+b  +" равно: "+c);