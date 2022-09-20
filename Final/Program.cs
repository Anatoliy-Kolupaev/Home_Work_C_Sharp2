
System.Console.WriteLine("Добрый день!");
int n=0;
int v=100;
while(n < v)
{
    Console.Write("Выберите задачу которую хотите проверить (задачи пронумерованы 1, 2, 3,):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Задача: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
        Console.WriteLine();
        if (choice == 1) task1(); 
        if (choice == 1) task1();
        if (choice == 1) task1();
        if (choice == 1) task1();
        if (choice == 1) task1();
        break;
        
    }
    while(choice == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Задача: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine();
        if (choice == 2) task2(); 
        if (choice == 2) task2(); 
        if (choice == 2) task2(); 
        if (choice == 2) task2();
        if (choice == 2) task2();
        break;
    }
    while(choice == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Задача: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine();
        if (choice == 3) task3();
        if (choice == 3) task3();
        if (choice == 3) task3();
        if (choice == 3) task3();
        if (choice == 3) task3();
        break;  
    }
    n++;
}

    void task1()
    {
        Console.Write("Напиши любое трехзначное число: ");
        int user_number = int.Parse(Console.ReadLine());
        if (user_number > 100 && user_number < 1000) Console.WriteLine("Вторя цифра этого числа = " + user_number /10 % 10); 
        else System.Console.WriteLine("Ты ввел не правельное число! Необходимо ввести ТРЕХЗНАЧНОЕ число!");
        if (user_number == 0) return ;
  
    }       
    
    void task2()
    {
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

    }
    void task3()
    {
        Console.Write("Напиши любое число от 1 до 7: ");

        int user_number = int.Parse(Console.ReadLine());

        if (user_number < 1 || user_number > 7) Console.WriteLine("Это не день недели, в неделе их 7!");
        if (user_number == 1) Console.WriteLine("Понедельник, не выходной"); 
        if (user_number == 2) Console.WriteLine("Вторник, не выходной");
        if (user_number == 3) Console.WriteLine("Среда, не выходной");
        if (user_number == 4) Console.WriteLine("Четветрг, не выходной");
        if (user_number == 5) Console.WriteLine("Пятница, не выходной");
        if (user_number == 6) Console.WriteLine("Суббота, ЭТО ВЫХОДНОЙ УРА!");
        if (user_number == 7) Console.WriteLine("Воскресенье, ЭТО ВЫХОДНОЙ УРА!");
    }
