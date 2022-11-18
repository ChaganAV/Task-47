int rows = ReadArray("Введите число строк:");
int columns = ReadArray("Введите число колонок:");
double[,] numbers = new double[rows,columns];

FillRandomArray(numbers);
PrintArray(numbers);

// Функции
void FillRandomArray(double[,] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rnd.NextDouble(),2);
        }
    }
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

int ReadArray(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
