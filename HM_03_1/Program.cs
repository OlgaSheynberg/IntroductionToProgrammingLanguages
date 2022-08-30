Console.Clear();
Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

Console.WriteLine("ВВедите пятизначное число: ");
int a = int.Parse(Console.ReadLine());

int b1 = a / 10000;
int b2= a % 10;

int b3 = Math.Abs(b1*10 -a / 1000);
int b4= Math.Abs((a % 100-b2)/10);

while (a / 10000 <=0 || a / 10000 > 10)
{
    Console.WriteLine(" введите 5-ти значное число");
    a = int.Parse(Console.ReadLine());;
}
if (b1==b2 && b3==b4)
{
    Console.WriteLine(a+" число является палиндромом");
}
else
{
    Console.WriteLine(a+" число не является палиндромом");
}