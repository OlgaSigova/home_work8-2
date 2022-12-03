//Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во колонок");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[,] GetArray()
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }

}
PrintArray(GetArray());
Console.WriteLine("____________");
int sum = 0;
int minsum = Int32.MaxValue;
int minrow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
  
    if (sum < minsum)
    {
        minsum = sum;
        minrow = i;
    }
    sum=0;
}


Console.WriteLine("Номер строки с наименьшей суммой элементов: " +minrow);