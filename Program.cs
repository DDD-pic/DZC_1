﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1



int  number = new Random().Next(100, 1000);

int secondValue = (number / 10) % 10;
Console.WriteLine("Исходное число: " + number + " вторая цифра: " + secondValue);

//Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

//78 -> третьей цифры нет

//3267900 -> 6

int  number = new Random().Next(10, 10000000);
if (number > 100 && number < 1000)
{
    Console.WriteLine("Исходное число: " + number + "Число трехзначное: ");
}
else
{
    Console.WriteLine("Исходное число: " + number +  "Число не трехзначное:");
}
int secondValue = (number / 10000) % 10;
Console.WriteLine("Исходное число: " + number + " третья цифра: " + secondValue);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 6)
{
    Console.WriteLine("Рабочий день: ");
}
else 
{
    
    Console.WriteLine("Выходной: ");
}
