//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Hello, World!");
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов. Программа найдет среднее арифметическое элементов столбца");
int Array0 = int.Parse(Console.ReadLine());
int Array1 = int.Parse(Console.ReadLine());
double [,] Martix = new double [Array0,Array1];

void FillArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Random rand = new Random();
            array[i,n] = rand.Next(10,100);
        }
    }
}
void PrintArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            Console.Write($"{array[i,n]}  ");
        }
        Console.WriteLine();
    }
}
void PrintAverageColumn (double [,] array)
{
    for (int n = 0; n <array.GetLength(1); n++)
    {
        double Average = 0;
        for (int i = 0; i <array.GetLength(0); i++)
        {
            Average = Average + array[i,n];
        }
        Console.Write($"{Average/array.GetLength(0)} ");
    }
}
FillArray(Martix);
PrintArray(Martix);
Console.WriteLine("Среднее арифметическое по столбцам:");
PrintAverageColumn(Martix);
