//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number()
{
    Console.WriteLine($"Input 3 digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    
    int num1 = num % 100;// поделили с остатком
    int num2 = num1 / 10;// поделили без остатка

     return num2; // вернули значение
}

int result = Number();// Вызвали Функцию, Вызвали Метод
Console.Write($"Result is {result}");// вывели пользователю результат