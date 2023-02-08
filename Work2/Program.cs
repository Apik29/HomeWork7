/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Write("Введите позицию на какой строке: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в каком столбце: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());


void Generate2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
    System.Console.WriteLine();
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

void CheckNumber(int[,] arr)
{
    if (arr[line - 1, column - 1] == number)
    {
        Console.WriteLine($"{number} - такое число в массиве есть");
    }
    else
    {
        Console.WriteLine($"{number} - такого числа в массиве нет");
    }
}
const int lines = 4;
const int columns = 5;
int[,] array = new int[lines, columns];

Generate2DArray(array);
Print2DArray(array);
CheckNumber(array);