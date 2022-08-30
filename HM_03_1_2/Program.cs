Console.Clear();
Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

int[] array = new int[5];

for (int i=0; i<5;i++)
{
    Console.WriteLine("Введите число подиндексом" +i);
    array[i]=int.Parse(Console.ReadLine()); 
}

if (array[0]==array[4]&& array[1]==array[3])
{
Console.WriteLine(array+" число является палиндромом");
}
else
{
 Console.WriteLine(array+" число не является палиндромом");    
}