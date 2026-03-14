Console.WriteLine("Hello, World!");

double CalculateAverage(int[] values)
{
    int sum = 0;

    foreach (int el in values)
    {
        sum += el;
    }
    
    return sum / values.Length;
}

Console.WriteLine(CalculateAverage(new int[] { 1, 2, 3, 4, 5 }));