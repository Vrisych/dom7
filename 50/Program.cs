//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("Введите желаемый размер массива, сначала количество строк, затем столбцов.");
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
            Console.Write($"{array[i,n]} ");
        
        }
        Console.WriteLine();
    }
}

FillArray(Martix);
PrintArray(Martix);
Console.WriteLine("Введите строку, а затем столбец желаемого элемента через enter");
int FindArray0 = int.Parse(Console.ReadLine());
int FindArray1 = int.Parse(Console.ReadLine());
if (FindArray0>Array0 && FindArray1>Array1)  Console.WriteLine("Значния выходят за пределы массива");
else Console.WriteLine(Martix[FindArray0-1,FindArray1-1]);