// // Урок 8. Двумерные массивы. Продолжение
// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2


var array = GenArray();
PrintArray(array);
System.Console.WriteLine(" ");
ChangeArray(array);
PrintArray(array);

void ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int[,] GenArray(int rows = 4, int cols = 4)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 10);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();  
    }
}




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

var array = GenArray();
PrintArray(array);
System.Console.WriteLine(" ");
int minSumRows = 0;
int sumRows = SumRowsElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRows = SumRowsElements(array, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"\n{minSumRows+1} - строкa содержит наименьшую сумму ({sumRows}) целых чисел ");



int SumRowsElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

int[,] GenArray(int rows = 4, int cols = 4)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 50);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();    
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrixOne = GenArray();
Console.WriteLine($"Первая матрица:");
PrintArray(matrixOne);
System.Console.WriteLine(" ");

int[,] matrixTwo = GenArray();
Console.WriteLine($"Вторая матрица:");
PrintArray(matrixTwo);
System.Console.WriteLine(" ");

int[,] multyMatrix = GenArray();

MultiplyMatrix(matrixOne, matrixTwo, multyMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(multyMatrix);

void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] multyMatrix)
{
  for (int i = 0; i < multyMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multyMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        sum += matrixOne[i,k] * matrixTwo[k,j];
      }
      multyMatrix[i,j] = sum;
    }
  }
}

int[,] GenArray(int rows = 2, int cols = 2)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 5);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();      
    }
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


var array = GenArray();
PrintArray(array);
System.Console.WriteLine(" ");



int[,,] GenArray(int rows = 2, int cols = 2, int lines = 2)
{
    Random random = new Random();
    int[,,] array = new int[rows, cols, lines];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < lines; k++)
            {
                array[i, j, k] = random.Next(10, 100);
            }
        } 
    }
    return array;
}


void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " " + (i ,j, k) + " ");
            }
        }
    Console.WriteLine();      
    }
}
