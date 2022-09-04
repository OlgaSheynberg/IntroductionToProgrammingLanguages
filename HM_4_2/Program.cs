Console.Clear();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("введите число: ");

string chislo=Console.ReadLine();
int a = int.Parse(chislo);
int c=0;
int d=a;

for(int i=1;i<= chislo.Length; i++)
{
c=c+d%10;
d= d/10;
//Console.WriteLine( c);
}
Console.WriteLine("Сумма цифр в числе равна: "+c);