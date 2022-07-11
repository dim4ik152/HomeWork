Console.WriteLine("Введите номер");
string numberONE = Console.ReadLine();
int number1 = int.Parse(numberONE);

string [] week = new string [] {"Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Satarday", "Sunday"};

 if(number1 > 7 )
 {
    Console.WriteLine("Ошибка");
 }

  else if(number1 == 6 || number1 == 7)
 {
    Console.WriteLine($"Выходной {week} {week [number1 - 1]}");
 }

 else
 {
  Console.WriteLine($"Рабочий День {week} {week [number1 - 1]}");
 }
 
