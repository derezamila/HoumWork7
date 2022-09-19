// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] RandomArray(int m, int n, int min, int max){
    
    double[,] array = new double[m,n];
    Random rand = new Random();
    for(int i = 0; i<m; i++)
        for(int j = 0; j<n; j++)
            array[i,j] = rand.Next(min,max) + rand.NextDouble();
       
    return array;
}

void ShowArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк в массиве m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(m, n, min, max));
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] RandomArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

/* void ShowArray(int[,] array){
    Console.Write("Введите индекс строки: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int y = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    if (x < array.GetLength(0) && y < array.GetLength(1)){
    Console.WriteLine($"Значение элемента с координатами {x} {y} равно {array[x,y]}");
}
  
else Console.WriteLine("Такого элемента в массиве нет");
}
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void ShowArray(int[,] array){
    
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    for (int j = 0; j < array.GetLength(1); j++){
        double num = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           num += array[i,j];            
        }
    Console.WriteLine($"Среднее арифметическое {j}-го столбца равно {num / array.GetLength(0)}");
    }
}
Console.Write("Введите кол-во строк в массиве: ");
int rous = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(rous, cols, min, max));
