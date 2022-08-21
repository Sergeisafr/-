Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int b = number1 % 2;
if (b == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
