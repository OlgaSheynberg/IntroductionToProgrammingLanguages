Console.Clear();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());

int c=0;

for(int i=1;i<= a.Length; i++)

{
c=c+ a%10;
}
Console.WriteLine("Сумма цифр в числе равна: "+c);