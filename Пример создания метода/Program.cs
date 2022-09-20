// === Создадим наш первый метод. ===

//Его задача - вывести на экран текущую дату:
//Today is: 2021-10-25

// Объявление класса
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class App
{
    // Определение метода
    public static void ShowCurrentDate()
    {
        // Класс со свойством для получения текущего времени
        var currentDate = DateTime.Now;
        var text = $"Today is: {currentDate}";
        Console.WriteLine(text);
    }
}


 
// namespace GetTime
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Текущие дата/время хранятся в свойстве Now класса DateTime
 
//             Console.WriteLine(DateTime.Now + " holla"); //Получаем текущие дату и время, выводим их в консоль
//             //Чтобы программа сразу же не закрылась
//             Console.ReadKey();
//         }
//     }
// }
