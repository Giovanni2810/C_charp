// напишите программу, когторая на вход принимает число и выдает его квадрат (Число умноженное на само себя)

// Например:
// 4 -> 16
// - 3 -> 9
// - 7 -> 49

Console.Write("Введите значение: "); // Приглашение пользователя ко вводу
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
System.Console.WriteLine(sqr);