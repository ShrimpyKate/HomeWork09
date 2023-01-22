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

int CalcSumBetweenNumbers(int n, int m)
{
  if (n == m)
  {
    return m;
  }
  return n + CalcSumBetweenNumbers(n + 1, m);
}

int n = GetNumberByUser();
int m = GetNumberByUser();
int sum = CalcSumBetweenNumbers(n, m);
Console.WriteLine(sum);