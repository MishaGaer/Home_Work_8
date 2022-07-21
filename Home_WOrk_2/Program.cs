/*Задайте прямоугольный двумерный массив. 
Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
//рандомное заполнение массива и печать в консоль
void FillTable(ref int[,] table)
{
    int indexLine = 0;
    while (indexLine < table.GetLength(0))
    {
        for (int indexPost = 0; indexPost < table.GetLength(1); indexPost++)
        {
            table[indexLine, indexPost] = new Random().Next(10, 100);
            Console.Write($"{table[indexLine, indexPost]} | ");
        }
        Console.WriteLine();
        indexLine++;
    }
}
//Поиск строки с наименьшей суммой элементов
void AmountMaxLine(int[,] table, out int maxLine)
{
    maxLine = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 1; j < table.GetLength(1); j++)
        {
            table[i, 0] += table[i, j];
        }
        if (table[i, 0] < table[maxLine, 0])
        {
            maxLine = i;
        }
    }
}
//Основной код
int size = new Random().Next(5, 20);
int[,] table = new int[size, size];
FillTable(ref table);
int maxLine;
AmountMaxLine(table, out maxLine);
Console.WriteLine($"номер строки с наименьшей суммой элементов - {maxLine + 1}");