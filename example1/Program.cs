Console.Write("Напиши любое трехзначное число: ");

int user_number = int.Parse(Console.ReadLine());

if (user_number > 100 && user_number < 1000) Console.Write("Вторя цифра этого числа = " + user_number /10 % 10);
if (user_number < 100) Console.WriteLine("Ты ввел не правельное число! По пробуй еще раз!");
if (user_number > 999) Console.WriteLine("Ты ввел не правельное число! По пробуй еще раз!");


