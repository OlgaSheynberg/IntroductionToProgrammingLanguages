Console.Clear();
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

int num = new Random().Next(10,1000); 
int a1 = num / 100;
int a2 = num % 10;

if (a1 > 0)
{
Console.WriteLine("Вторая цифра в числе " +num+ " -> " + a2);
}
else
{
Console.WriteLine("третьей цифры нет");
}