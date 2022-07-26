// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
 Console.WriteLine("Введите число A: ");
  int numberA = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int numberB = int.Parse(Console.ReadLine());

int Exponent (int numberA, int numberB)
{
  int result = 1;
  for (int i=1; i <= numberB; i++)
    {
    result = result * numberA;
    }
    return result;
}
  int exponentresult = Exponent(numberA, numberB);
  Console.WriteLine(exponentresult);