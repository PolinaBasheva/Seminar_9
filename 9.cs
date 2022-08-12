Задача 64.
int chislo = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(chislo, count);
Console.Write(1);

void PrintNumber(int chislo, int count)
{
  if (count > chislo) return;
  PrintNumber(chislo, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Задача 66.
int chislo_1 = InputNumbers("Введите первое число: ");
int chislo_2 = InputNumbers("Введите второе число: ");
int n = chislo_1;

if (chislo_1  > chislo_2) 
{
  chislo_1  = chislo_2; 
  chislo_2 = n;
}

PrintSumm(chislo_1 , chislo_2, n=0);

void PrintSumm(int chislo_1, int chislo_2, int summ)
{
  summ = summ + chislo_2;
  if (chislo_2 <= chislo_1)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(chislo_1, chislo_2 - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Задача 68.
int chislo_1 = InputNumbers("Введите первое число: ");
int chislo_2 = InputNumbers("Введите второе число: ");
int functionAkkerman = F_Akkerman(chislo_1, chislo_2);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int F_Akkerman(int chislo_1, int chislo_2)
{
  if (chislo_1 == 0) return chislo_2 + 1;
  else if (chislo_2 == 0) return F_Akkerman(chislo_1 - 1, 1);
  else return F_Akkerman(chislo_1 - 1, F_Akkerman(chislo_1, chislo_2 - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
