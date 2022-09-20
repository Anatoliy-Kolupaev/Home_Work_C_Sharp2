Console.Write("Напиши любое число от 1 до 7: ");

int user_number = int.Parse(Console.ReadLine());

if (user_number < 1 || user_number > 7) Console.WriteLine("Это не день недели, в неделе их 7!");
if (user_number == 1) Console.WriteLine("Понедельник, не выходной"); 
if (user_number == 2) Console.WriteLine("Вторник, не выходной");
if (user_number == 3) Console.WriteLine("Среда, не выходной");
if (user_number == 4) Console.WriteLine("Четветрг, не выходной");
if (user_number == 5) Console.WriteLine("Пятница, не выходной");
if (user_number == 6) Console.WriteLine("Суббота, это выходной день");
if (user_number == 7) Console.WriteLine("Воскресенье, это выходной день");
