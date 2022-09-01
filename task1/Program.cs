// Определить, присутствует ли в заданном массиве, некоторое число

void FillArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,10);
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}
bool CompareArray(int[] arr, int num){
    bool yest = false;
    for (int i = 0; i < arr.Length; i++){
        if (num == arr[i]) yest = true;
    }
    return yest;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Введите число для проверки ");
int number = Convert.ToInt32(Console.ReadLine());
bool existence = CompareArray(arr, number);
if (existence) Console.WriteLine($"Число {number} присутствует в массиве");
else Console.WriteLine($"Число {number} отсутствует в массиве");