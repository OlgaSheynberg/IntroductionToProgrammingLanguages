﻿Console.Clear();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

int num = new Random().Next(100,999); 
int a1= num / 10;
int a2= a1 % 10;

Console.WriteLine("Вторая цифра в числе " +num+ " -> " + a2);