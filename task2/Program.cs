// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,200);
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++) {
        if(i == 0) Console.Write("{");
        Console.Write(arr[i]);
        if(i != arr.Length-1) Console.Write(", ");
        if(i == arr.Length-1) Console.Write("}");
    }
}
int FindMatch(int[] arr){
    int res = 0;
    for (int i = 0; i < arr.Length; i++){
    if (arr[i] >= 10 && arr[i] <= 99) res = res + 1;
    }
    return res;
}
int[] arr = new int[123];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int result = FindMatch(arr);
Console.WriteLine($"Количество элементов из отрезка {result}");