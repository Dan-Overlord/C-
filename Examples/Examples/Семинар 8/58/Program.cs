// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int [,] first = new int[4, 3];
int[,] second = new int[3,4];
int[,] resultMat = new int[4,4];


FillArrayRandomNumbers(first);
FillArrayRandomNumbers(second);

 Console.WriteLine("Первая матрица"); 
PrintArray (first);
 Console.WriteLine("Вторая матрица"); 
PrintArray (second);



MultiPly(first, second, resultMat);

Console.WriteLine("Результат произведения"); 
PrintArray (resultMat);

void MultiPly(int[,] first, int[,] second, int[,] resultMat)
{
  {
  for (int i = 0; i < resultMat.GetLength(0); i++)
  {
    for (int j = 0; j < resultMat.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * second[k,j];
      }
      resultMat[i,j] = sum;
    }
  }
}
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}