Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ind = 2;
while (ind <= num)
{
   if (ind % 2 ==0)
    {
      Console.Write (ind + ", ");
     ind = ind + 1; 
    }
    else 
    {
       Console.Write (ind + ", ");
    }
   ind = ind + 1; 
}
