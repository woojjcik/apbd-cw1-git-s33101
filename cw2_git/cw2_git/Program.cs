Console.WriteLine("Hello, World!");
Console.WriteLine("Hellooo, Woooorld!");

double CalculateAverage(int[] values)
{
    int suma = 0;

    foreach (int el in values)
    {
        suma += el;
    }
    
    return suma / values.Length;
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

Console.WriteLine(CalculateMin(new int[] {1,23,4,5,6}));
Console.WriteLine(CalculateMin(new int[] {5,7,2,5,6}));
Console.WriteLine(CalculateMin(new int[] {1,0,12,5}));