// Напишите программу, которая по заданному номеру четверти, показывает диапохон возможных координат точек в этой четверти (X и Y)

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string[] msg = {
    "X>0, Y>0", // 0
    "X<0, Y>0", // 1
    "X<0, Y<0", // 2
    "X>0, Y<0", // 3
    "Такой четверти нет" // 4
};

if(number > 0 && number < 5)
    System.Console.WriteLine(msg[number - 1]);
else
    System.Console.WriteLine(msg[4]);

// 1 - > 0
// 2 ->  1
// 3 - > 2
// 4 - > 3


// switch (number)
// {
//     case 1:
//         System.Console.WriteLine("X>0, Y>0");
//         break;
//     case 2:
//         System.Console.WriteLine("X<0, Y>0");
//         break;
//     case 3:
//         System.Console.WriteLine("X<0, Y<0");
//         break;
//     case 4:
//         System.Console.WriteLine("X>0, Y<0");
//         break;
//     default:
//         System.Console.WriteLine("Такой четверти нет");
//         break;
// }

// if (number == 1){
//     System.Console.WriteLine("X>0, Y>0");
// }
// else if (number == 2){
//     System.Console.WriteLine("X<0, Y>0");
// }
// else if (number == 3)
// {
//     System.Console.WriteLine("X<0, Y<0");
// }

// else if (number == 4)
// {
//     System.Console.WriteLine("X>0, Y<0");
// }
// else{
//     System.Console.WriteLine("Такой четверти нет");
// }


