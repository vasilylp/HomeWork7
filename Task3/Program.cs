// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//---------------------------------Решение---------------------------------

// Задаем двумерный массив-------------------------------------------------

double[,] CreateMatrix(int rows, int cols)
{
              double[,] matrix = new double[rows, cols];
              Random rand = new Random();
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          matrix[i, j] = rand.Next(0, 10);
                            }
              }
              return matrix;
}
// Печатаем заданный массив-------------------------------------------------

void PrintMatrix(double[,] matrix)
{
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          System.Console.Write(matrix[i, j] + "\t");
                            }
                            System.Console.WriteLine();
              }
}

// Находим среднее-арифметическое элементов в каждом столбце заданного массива

void AverageArithmeticCol(double[,] matrix)
{

              for (int i = 0; i < matrix.GetLength(1); i++)
              {
                            double sumCol = 0;
                            double averageSumCol = 0;
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                          sumCol = sumCol + matrix[j, i];

                            }
                            averageSumCol = sumCol / matrix.GetLength(0);
                            if (i != (matrix.GetLength(1) - 1))
                            {
                                          System.Console.Write($"{Math.Round(averageSumCol, 1)};\t");
                            }
                            else System.Console.Write($"{Math.Round(averageSumCol, 2)}.");
              }
}

//------------------------------------------------------------------------

double[,] matr = CreateMatrix(3, 4);
PrintMatrix(matr);
AverageArithmeticCol(matr);