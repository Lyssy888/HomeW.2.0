// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write($"enter the day of the week: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
    Console.Write($"It's a working day");  
} 
 
else if (num >= 6 && num <= 7) 
{ 
    Console.Write($"it's a day off"); 
} 
else Console.Write($"there is no such day of the week");