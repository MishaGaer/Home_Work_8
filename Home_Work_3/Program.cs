/*
Задайте две матрицы. 
Напишите программу, 
которая будет находить произведение двух матриц.
*/
void FillTable(ref int[,] table, string message)
{
    Console.WriteLine(message);
    int indexLine = 0;
    while (indexLine < table.GetLength(0))
    {
        for (int indexPost = 0; indexPost < table.GetLength(1); indexPost++)
        {
            table[indexLine, indexPost] = new Random().Next(1, 10);
            Console.Write($"{table[indexLine, indexPost]} | ");
        }
        Console.WriteLine();
        indexLine++;
    }
}
//произведение массивов
void IncreaseArray(int[,] table1, int[,] table2)
{
    Console.WriteLine("Произведение первой и второй матрици будет равно:");
    for (int i = 0; i < table1.GetLength(0); i++)
    {
        for (int j = 0; j < table1.GetLength(1); j++)
        {
            Console.Write($" {table1[i, j] * table2[i, j]} |");
        }
        Console.WriteLine();
    }
}
//Основной код
int size = new Random().Next(5, 20);
int[,] table1 = new int[size, size];
int[,] table2 = new int[size, size];
FillTable(ref table1, "Первая матрица:");
FillTable(ref table2, "Вторая матрица:");
IncreaseArray(table1, table2);
