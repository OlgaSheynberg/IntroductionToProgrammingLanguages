Console.Clear();
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Введите размер массива: ");
int n =int.Parse(Console.ReadLine()); 
while (n <0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

int count=0;
int[]array= new int[n];
for(int i=0; i<n; i++)
{
array[i]= new Random().Next(100,1000);
}
foreach(int e in array)
{
    count+=e%2==0?1:0;
    Console.Write(e+" ");
}

Console.Write("Количество чётных чисел в массиве: "+count);
