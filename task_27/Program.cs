// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число N: ");
int Number = int.Parse(Console.ReadLine());

  int SumNumber(int N)
  {
    int cont = Convert.ToString(Number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < cont; i++)
    {
      advance = Number - Number % 10;
      result = result + (Number - advance);
      Number = Number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(Number);
Console.WriteLine(sumNumber);
