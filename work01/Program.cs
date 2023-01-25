// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: "); 
int b = Convert.ToInt32(Console.ReadLine());

GetPow(a,b);

int GetPow(int a, int b)

{
int result = 1;
for(int i = 0; i < b; i++)
    {   
        result = result * a;
    }

return result;
}
Console.WriteLine(GetPow(a,b));