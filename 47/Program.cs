// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов. Программа создаст массив, заполненный случайными числами");
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
            array[i,n] = rand.Next(-99,100);
            array[i,n]=array[i,n]/10;
        }
    }
}
void PrintArray (double [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int n = 0; n <array.GetLength(1); n++)
        {
            if (array[i,n]>=0) Console.Write($" ");
            Console.Write($"{array[i,n]} ");
            if (array[i,n]%1==0) Console.Write($"  ");
        
        }
        Console.WriteLine();
    }
}
FillArray(Martix);
PrintArray(Martix);