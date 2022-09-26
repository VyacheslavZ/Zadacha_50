int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(1, 10);
        }
    }
    return mas;
}

string NumberOfMatr(int[,] array, int row, int column)
{
    string num = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                num = array[i, j].ToString();
                return num;
            }
            else num = "Такого числа в массиве нет!";
        }
    }
    return num;
}

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write("{0,3}", mas[i, j]);
        }
        Console.WriteLine("]");
    }
}

try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);

    System.Console.Write("Введите номер строки: ");
    int k = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите номер столбца: ");
    int s = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(NumberOfMatr(newArray, k, s));
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа!");
}