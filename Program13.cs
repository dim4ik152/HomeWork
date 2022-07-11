/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите 2-ухзначное число");
string number = Console.ReadLine();
int number1 = int.Parse(number);

if(number1 < 99)
{
    Console.WriteLine("Нету третьей цифры");
}
Console.WriteLine("Введите 3-ехзначное число");
string numberTHREE = Console.ReadLine();
int number4 = int.Parse(numberTHREE);

     if (number4 < 999)
    {
        int first = (number4 / 1) %10;
        Console.WriteLine($"Третья цифра числа {first}");
    }
        else if(number4 > 999)
        {
            Console.WriteLine("Ошибка");
        
        }
    Console.WriteLine("Введите 4-xзначное число");
    string numberONE = Console.ReadLine();
    int number2 = int.Parse(numberONE);
    
     if (number2 < 9999)
    {
        int second = (number2 / 10) %10;
        Console.WriteLine($"Третья цифра числа {second}");
        
    }
    else if(number2 > 9999)
        {
            Console.WriteLine("Ошибка");
        
        }

    Console.WriteLine("Введите 5-тизначное число");
    string numberTWO = Console.ReadLine();
    int number3 = int.Parse(numberTWO);

     if(number3 < 99999)
    {
    int third = (number3 / 100) %10;
    Console.WriteLine($"Третья цифра числа {third}");
    }
    else if (number3 > 99999)
    {
        Console.WriteLine("Ошибка");
    }
    

