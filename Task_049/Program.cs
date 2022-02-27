// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Clear();

Console.Write("Количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов n: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100) + new Random().NextDouble();
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:0.00}\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

Console.WriteLine();
