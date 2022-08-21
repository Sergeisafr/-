Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;
max = number1;
if (max < number2)
{
    max = number2;
 }
else 
 {
    max = number1;
 }

if (max < number3)
 {
     max = number3;
 }
 else max = max;
Console.Write("max = "+ max);
