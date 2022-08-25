Console.Clear();
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
int num = new Random().Next(1,8); 
if (num <= 5)
{
Console.WriteLine(+num+" день недели рабочий ");
}
else
{
Console.WriteLine(+num+ " день недели выходной ");
}