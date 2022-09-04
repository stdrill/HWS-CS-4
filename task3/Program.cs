// Найти произведение пар чисел в одномерном массиве

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 11);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
}

void MultiplicationArrayPairs(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length / 2; i++)
    {
        Console.Write(array[i] * array[array.Length - 1 - i]);
        Console.Write(" ");
    }
    if(array.Length % 2 != 0) Console.Write(array[array.Length/2]);
    Console.WriteLine();
}


int[] arr = new int[11];
FillArray(arr);
PrintArray(arr);

MultiplicationArrayPairs(arr);
