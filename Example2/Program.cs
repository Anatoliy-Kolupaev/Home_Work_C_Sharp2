Console.Write("Напиши любое число: ");

int array = int.Parse(Console.ReadLine());

int [] UserArray = new int[]{array};
{
    int lenght = UserArray.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.WriteLine(UserArray[2]);
        index++;
    }
    
}


//if (user_number > 100 && user_number < 1000) Console.Write("Вторя цифра этого числа = " + user_number /1 % 1);

if (array < 100) Console.WriteLine("Третьей цифры нет!");



