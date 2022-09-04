// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 10) + random.NextDouble();
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
}
double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++) {
        if(max < arr[i]) max = arr[i];
    }
    return max;
}
double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++) {
        if(min > arr[i]) min = arr[i];
    }
    return min;
}


double[] arr = new double[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
double max = FindMax(arr);
Console.WriteLine($"Max {max}");
double min = FindMin(arr);
Console.WriteLine($"Min {min}");
double result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами {result}");