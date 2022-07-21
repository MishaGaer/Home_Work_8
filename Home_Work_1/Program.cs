/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

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
//Упорядочение строк по убыванию и печать в консоль
void Regulating(int[,] table)
{
    int unit = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int jNext = j + 1; jNext < table.GetLength(1); jNext++)
            {
                if (table[i, j] < table[i, jNext])
                {
                    unit = table[i, j];
                    table[i, j] = table[i, jNext];
                    table[i, jNext] = unit;
                }
            }
            Console.Write($" {table[i, j]} |");
        }
        Console.WriteLine();
    }
}

//Основной код
int line = new Random().Next(5, 20);
int post = new Random().Next(5, 20);
int[,] table = new int[line, post];
FillTable(ref table);
Console.WriteLine();
Console.WriteLine();
Regulating(table);
