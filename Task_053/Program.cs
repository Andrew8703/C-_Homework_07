// Задача 53: В двумерном массиве показать позиции числа, 
// заданного пользователем, или указать, что такого элемента нет.

Console.Clear();

Console.Write("Количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
bool f = false;

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
PrintArray(array);
Console.Write("Введите число для поиска: ");
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == a)
        {
            Console.WriteLine($"Элемент находится в {i + 1} строке и {j + 1} столбце.");
            f = true;
        }
    }
}
if (f == false) Console.WriteLine("в заданном массиве такого числа нет!");

Console.WriteLine();
