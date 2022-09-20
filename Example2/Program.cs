Console.Write("Введи любое число: ");
int User_Number = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(User_Number);
if (Number.Length > 2)
{
  Console.WriteLine("третья цифра этого числа  " + Number[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}
