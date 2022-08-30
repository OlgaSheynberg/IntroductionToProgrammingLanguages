Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите координату x1");
int x1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1");
int y1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z1");
int z1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2");
int y2= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z2");
int z2= int.Parse(Console.ReadLine());

double vec = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine(vec);