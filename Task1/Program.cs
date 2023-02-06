// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//----------------------------Решение-----------------------------------------------------

// Создаем двумерный массив вещественных чисел m x n --------------------------

double[,] FillRealMatrix(int m, int n)
{
              double[,] matrix = new double[m, n];
              Random rand = new Random();
              for (int i = 0; i < m; i++)
              {
                            for (int j = 0; j < n; j++)
                            {
                                          matrix[i, j] = Math.Round((rand.Next(0, 100) + rand.NextDouble()), 2);
                            }
              }
              return matrix;
}

// Распечатываем созданный массив вещественных чисел----------------------

void PrintArray(double[,] matrix)
{
              for (int row = 0; row < matrix.GetLength(0); row++)
              {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                          System.Console.Write(matrix[row, col] + "\t");
                            }
                            System.Console.WriteLine();
              }
}
//------------------------------------------------------------------------------------

double[,] realMatrix = FillRealMatrix(3, 4);
PrintArray(realMatrix);