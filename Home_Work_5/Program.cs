/*Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
//Заполнение по спирали
void FillTable(int[,] table)
{
    int maxIndexI = table.GetLength(0) - 1;
    int maxIndexJ = table.GetLength(1) - 1;
    int endI = 1;
    int endJ = 0;
    int i = 0;
    int j = 0;
    int number = 1;
    while (number <= table.GetLength(0) * table.GetLength(1))
    {
        if (i == endI && j == endJ)
        {
            endI++;
            endJ++;
            maxIndexI--;
            maxIndexJ--;
        }
        else
        {
            if (i < endI && j < maxIndexJ)
            {
                table[i, j] = number;
                number++;
                j++;
            }
            else
            {
                if (j == maxIndexJ && i < maxIndexI)
                {
                    table[i, j] = number;
                    number++;
                    i++;
                }
                else
                {
                    if (i == maxIndexI && j > endJ)
                    {
                        table[i, j] = number;
                        number++;
                        j--;
                    }
                    else
                    {
                        table[i, j] = number;
                        number++;
                        i--;
                    }

                }

            }
        }
    }
}

//печать массива в консоль
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($" {table[i, j]} |");
        }
        Console.WriteLine();
    }
}


//Основной код
int[,] table = new int[4, 4];
PrintArray(table);
FillTable(table);
Console.WriteLine();
PrintArray(table);

