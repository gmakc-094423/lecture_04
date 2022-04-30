Console.Clear();
/* string[,] table = new string[2, 5];
// table[0, 0]  table[0, 1]  table[0, 2] ... table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2] ... table[1, 4]
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
  Console.Write($"\n");
  for (int columns = 0; columns < 5; columns++)
  {
    Console.Write($"-{table[rows, columns]}- ");
  }
} */

int[,] matrix = new int[3, 4];

void PrintMatrix(int[,] matrix){
  for (int rows = 0; rows < matrix.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
      Console.Write($"{matrix[rows, columns]} ");
    }
    Console.Write($"\n");
  }
}

void FillMatrix(int[,] matrix, int min, int max){
  for (int rows = 0; rows < matrix.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
      matrix[rows, columns] = new Random().Next(min, max);
    }
  }
}

PrintMatrix(matrix);
FillMatrix(matrix, 1, 10);
Console.Write($"\n");
PrintMatrix(matrix);
