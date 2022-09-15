// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear ();

int[,] matrix = new int[4, 5]; // Инициалиируем массив


void PrintArray(int[,] matr) // Создаём метод вывода на консоль массива
{
  for (int i = 0; i < matr.GetLength(0); i++) // Перебираем строку
   {
     for (int j = 0; j < matr.GetLength(1); j++) // Перебираем столбцы
     {
       Console.Write($"{matr[i, j]} ");
     }
       Console.WriteLine();
   }
}

void FillArray(int[,] matr) // Создаём метод наполнения массива числами
{
  for (int i = 0; i < matr.GetLength(0); i++)
   {
     for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i,j] = new Random().Next(1,10);//[1; 10)
      }
   }
}

void SortToLower(int[,] matr) // Создаём метод сортировки элементов в строке двумерного массива, по убыванию
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1]) // Если изменить знак < то сортировка будет в обратную сторону
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

FillArray(matrix); // Наполняем
PrintArray(matrix); // Печатаем
SortToLower(matrix); // Сортируем
Console.WriteLine(); // Отступ
PrintArray(matrix); // Печатаем
