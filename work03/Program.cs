// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = GetRandomArray(8);

string str = string.Join(", ", arr);
System.Console.Write("[" + str + "]");

int[] GetRandomArray(int length) 
{
    int[] result = new int[length];

    for (int i=0; i<length; i++) 
    {
        result[i] = new Random().Next(0, 20);
    }

    return result;
}