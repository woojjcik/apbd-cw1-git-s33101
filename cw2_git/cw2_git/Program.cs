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
Console.WriteLine(CalculateAverage(new int[] { 6,8,9 }));
Console.WriteLine(CalculateAverage(new int[] { 11,11,23}));

int CalculateMac(int[] values)
{
    int max = values[0];

    foreach (int i in values)
    {
        if (i > max)
        {
            max = i;
        }
    }
    
    return max;
}