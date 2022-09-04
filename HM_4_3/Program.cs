Console.Clear();
Console.WriteLine("Задача№29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Введите размер массива:");
int n =int.Parse(Console.ReadLine()); 
while (n <0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());;
}
int [] array= new int[n];
for(int i =0; i<n; i++)
{
    Console.WriteLine("Введите "+i+" элемент массива");
    array[i]=int.Parse(Console.ReadLine()); 
}

for(int i =0; i<n-1; i++)
{
 Console.Write(array[i]+", ");   
}
 Console.Write(array[n-1]); 
