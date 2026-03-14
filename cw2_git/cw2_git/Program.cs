Console.WriteLine("Hello, World!");
Console.WriteLine("Helloooo, Wooooorld!");

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

int CalculateMax(int[] values)
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

Console.WriteLine(CalculateMax(new int[] {1,23,4,5,6}));
Console.WriteLine(CalculateMax(new int[] {23,45,52,66}));
Console.WriteLine(CalculateMax(new int[] {4,6,8,12}));

int CalculateMin(int[] values)
{
    int min = values[0];

    foreach (int el in values)
    {
        if (el < min)
        { 
            min = el;
        }
    }
    return min;
}