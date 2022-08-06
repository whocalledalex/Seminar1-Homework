// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Insert the first number: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second number: ");
// int second = Convert.ToInt32(Console.ReadLine());

// int max = first;

// if (max < second)
// {
//     max = second;
// }

// Console.Write("Max number is: " + max);






// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Insert the first number: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second number: ");
// int second = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the third number: ");
// int third = Convert.ToInt32(Console.ReadLine());

// int max = first;

// if (max < second)
// {
//     max = second;
// }

// if (max < third)
// {
//     max = third;
// }

// Console.Write("Max number is: " + max);







// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Insert the number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int y = number % 2;

// if (y == 0)
// {
//    Console.Write("The number is even"); 
// }
// else
// {
//     Console.Write("The number is odd"); 
// }






// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Insert the number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count < number)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count + " ");
//     }
//     count++;
// }