//Console.Clear;
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Введите размер массива: ");

int n= int.Parse(Console.ReadLine());
while(n<0)
{
    Console.WriteLine("Введите положительное число: ");
    int n= int.Parse(Console.ReadLine());
}

int count=0;
int[]array= new int[n];
for(int i=0; i<n; i++)
{
array[i]= new Random().Next(100,1000);
//count+=array[i]%2=0;
//Console.Write(Strarray);
}
string Strarray = string.Join(",", array);
Console.Write(Strarray);