// Задача 13 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Digit3(int number)
{
int result = -1;
if (number >= 100)
{
while (number > 999)
{
    number = number / 10;
}
result = number % 10;
}
return result; 
}


Console.Write($"Input  number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (Digit3(number1) == -1)
Console.WriteLine($"there is no third digit");
else
Console.WriteLine($"Third digit is {Digit3(number1)}");