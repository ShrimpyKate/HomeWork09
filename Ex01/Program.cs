// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNumberByUser()
{
  Console.Write("Введите значение n: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void PrintNumbersFrom1ToN(int n)
{
  if (n != 1) Console.Write($"{n}, ");
  else Console.Write($"{n}.");
  if (n == 1) return;
  n--;
  PrintNumbersFrom1ToN(n);
}

int num = GetNumberByUser();
PrintNumbersFrom1ToN(num);