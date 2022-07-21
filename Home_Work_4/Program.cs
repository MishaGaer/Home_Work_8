/*Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. 
Напишите программу, 
которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)*/

//заполнение массива
void FillCube(int[,,] array)
{
    int number = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
}
//вывод массива и индексов
void PrintCube(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//Основной код
int[,,] cube = new int[3, 3, 3];
FillCube(cube);
PrintCube(cube);

