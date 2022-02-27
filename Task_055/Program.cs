// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

Console.Write("Количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 501);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++) sum += array[j, i];
    Console.Write($"{Math.Round((sum / m),1)} \t");
}
Console.WriteLine();
Console.WriteLine();