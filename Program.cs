// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] array = new int[3, 4];
// ArrayRndm(array);
// PrintArray(array);
// Sorter(array);
// Console.WriteLine("---Вывод отсортированного массива---");
// PrintArray(array);

// //1 действие 
// void ArrayRndm(int[,] array2)
// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             array2[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// //2 действие
// void Sorter(int[,] array2)
// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2.GetLength(1) - 1; k++)
//             {
//                 if (array2[i, k] < array2[i, k + 1])
//                 {
//                     int temp = array2[i, k + 1];
//                     array2[i, k + 1] = array2[i, k];
//                     array2[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// //3 действие
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();}}

//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Console.Write("Введите количество столбцов в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк в массиве: ");
// int raws = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(raws, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[] rowAr=GetRowArray(array);
// SortArray(rowAr);
// Console.WriteLine(String.Join(" ", rowAr));
// PrintData(rowAr);



// //1 дейст
// int[,] GetArray(int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j]= new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }
// // 2 действ
// int[] GetRowArray(int[,] inArray){
//     int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
//     int ind = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++){
//             for (int j = 0; j < inArray.GetLength(1); j++){
//                 result[ind] = inArray[i, j];
//                 ind++;
//             }
//         }
//          return result;
//     }
// // 3 действ
// void SortArray(int[] inArray){
//     for (int i = 0; i < inArray.Length; i++){
//        for (int j = i+1; j < inArray.Length; j++){
//         if(inArray[i]>inArray[j]){
//             int k=inArray[i];
//             inArray[i]=inArray[j];
//             inArray[j]=k;
//         }
//        } 
//        Console.WriteLine();
//     }
// }
// //4 действ
// void PrintArray(int[,] inArray){
//     for (int i = 0; i < inArray.GetLength(0); i++){
//         for (int j = 0; j < inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i, j]}");
//         }
//         Console.WriteLine();
//     }

// }
// //5 действ
// void PrintData(int[] inArray){
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++){
//         if(inArray[i]!=el){
//             Console.WriteLine($"{el} встречается {count} раз");
//             el=inArray[i];
//             count=1;
//         }
//         else{
//             count++;
//         }
//     }
//     Console.WriteLine($"{el} встречается {count} раз");
// }

//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Console.Write("Введите количество столбцов в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк в массиве: ");
// int raws = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[raws, columns];

// int[,] secondArray = new int[raws, columns];

// int[,] finalArray = new int[raws, columns];
// ArrayRndm(array);
// PrintArray(array);

// Console.WriteLine("-----------");

// ArrayRndm(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// // 1 
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         finalArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             finalArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray(finalArray);

// // 2
// void ArrayRndm(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // 3
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] array = new int[2, 2, 2];
int count= 0;
FillArray(array);
PrintI(array);


// 1
void PrintI(int[,,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// 2
void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
