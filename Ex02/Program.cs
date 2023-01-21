// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int GetNumberByUser()
{
  Console.Write("Введите значение n: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void SumOfNumbersBetweenMandN(int M, int N)
{
  if (N != M) Console.Write($"{N}, ");
  else Console.Write($"{N}.");
  if (N == M) return;
  N++;
  SumOfNumbersBetweenMandN+
  SumOfNumbersBetweenMandN(M,N);
}

int n = GetNumberByUser();
int m = GetNumberByUser();
SumOfNumbersBetweenMandN(m, n);