﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetCountNum(int n) 
{        
    int sum = 0;
    for(int i = 1; i <= n; i++)
    {       
        sum = sum + (n % 10);
        n = n / 10;
    }  
    return sum; 
}  
  
Console.WriteLine(GetCountNum(n));
     