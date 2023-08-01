//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int size = 10;
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
PrintArray(arr);

int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
