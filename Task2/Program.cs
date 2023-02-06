// Задача 50. Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//----------------------------Решение------------------------------------------------------


// Задаем двумерный массив m x n заполнененый случайными числами

int[,] Matrix(int rows, int cols)
{
              int[,] newMatrix = new int[rows, cols];
              Random rand = new Random();
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          newMatrix[i, j] = rand.Next(0, 100);
                            }
              }
              return newMatrix;
}
//--------------------------------------------------------------------
// Печатаем созданный массив m x n

void PrintMatrix(int[,] newMatrix)
{
              for (int i = 0; i < newMatrix.GetLength(0); i++)
              {
                            for (int j = 0; j < newMatrix.GetLength(1); j++)
                            {
                                          System.Console.Write(newMatrix[i, j] + "\t");
                            }
                            System.Console.WriteLine();
              }
}
//------------------------------------------------------------------
// Вводим произвольное число 

int InputNumber(string str)
{
              int number;
              string? text;
              while (true)
              {
                            Console.Write(str);
                            text = Console.ReadLine();
                            if (int.TryParse(text, out number))
                            {
                                          break;
                            }

                            System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
              }
              return number;
}
//-----------------------------------------------------------
// Проверяем есть ли введенное число в заданном массиве и 
// если есть выдаем его индексы, если нет - пишем что его нет

void CheckNumberIn(int[,] matrix, int num)
{
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          if (num == matrix[i, j])
                                          {
                                                        System.Console.Write($"Число {num} есть в массиве, его индексы ({i}; {j})");
                                                        return;
                                          }

                            }

              }

              System.Console.WriteLine($"Числа {num} нет в заданном массиве");
}
//-------------------------------------------------------------------------

int[,] matr = Matrix(3, 4);
PrintMatrix(matr);
int number = InputNumber("Введите число : ");
CheckNumberIn(matr, number);