// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int GetNumberByUser()
{
  Console.Write("Введите значение : ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void SumOfNumbersBetweenMandN(int M, int N)
{
  int sum = 0;
  int temp=0;
  
  for (int i = 0; i < M; i++)
  {
  // if (N != M) Console.Write($"{N}, ");
  // else Console.WriteLine($"{N}.");
  temp+=N;
  Console.WriteLine(sum);
  if (N == M) return;
  N++;
  sum= temp+N;
  
  }
  
  SumOfNumbersBetweenMandN(M, N);
  
}
Console.WriteLine();

int n = GetNumberByUser();
int m = GetNumberByUser();
SumOfNumbersBetweenMandN(m,n);
