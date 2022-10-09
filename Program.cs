// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

void CreateRandomArray(double[,] Array)
    {
        for (int i =0; i < Array.GetLength(0); i++)
    {
        for (int j =0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(-10, 10);
        }
    }

    for (int i =0; i < Array.GetLength(0); i++)
    {
        for (int j =0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}   ");
        }
    Console.WriteLine();
    }
    }


int m =3;
int n = 4;

double [,] workArray = new double [m,n];

CreateRandomArray(workArray);
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


// если ищем позицию как указано в тексте задания
Console.Write("Укажите позицию элемента в двумерном массиве (строку/столбец): ");
int pos = Convert.ToInt32(Console.ReadLine());
int a = pos/10-1;
int b = pos%10-1;

if ((a<workArray.GetLength(0)) && (b<workArray.GetLength(1))) Console.WriteLine($"Значение элемента двумерного массива на позиции {pos}:  {workArray[a,b]}");
else Console.WriteLine($"Значение элемента двумерного массива на позиции {pos} :  отсутствует.");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] MediumNum = new double [n];

for ( int j =0; j<workArray.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i< workArray.GetLength(0); i++)
    {
        summ += workArray[i,j];
    }
    
    MediumNum[j] = Math.Round((summ/workArray.GetLength(0)),2);
    Console.Write($" {MediumNum[j]} ;");
}


// первое решение
// for (int i = 0; i < n; i++)
// {
//     MediumNum[i] = Math.Round(((workArray[0,i]+workArray[1,i]+workArray[2,i])/m),2);
//     Console.Write($"{MediumNum[i]}; ");
// }
