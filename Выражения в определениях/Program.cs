var rublesPerDollar = 60;
var dollarsCount = 50 * 1.25; // 62.5
var rublesCount = dollarsCount * rublesPerDollar; // 3750
Console.WriteLine(rublesCount); // => 3750

//А теперь давайте добавим к выводу текст с помощью конкатенации:

var rubleDollar = 60;
var dollarCount = 50; //* 1.25; // 62.5
var rubleCount = dollarCount * rubleDollar; // 3750
Console.WriteLine("The price is " + rubleCount + " rubles"); // => The price is 3750 rubles

//Задание
//Напишите программу, которая берет исходное количество евро, 
//записанное в переменную eurosCount, переводит евро в доллары и выводит на экран. 
//Затем полученное значение переводит в рубли и выводит на новой строчке.
//Пример вывода для 100 евро:
//125.0
//7500.0
//Считаем, что:
//1 евро = 1.25 долларов
//1 доллар = 60 рублей

var eurosCount = 100;
// BEGIN (write your solution here)
var dollC = eurosCount * 1.25;
Console.WriteLine(dollC);
var rurC = dollC * 60;
Console.WriteLine(rurC);
// END
// пример ниже показывает, как еще можно обявлять переменные
// вот так их и нужно объявлять в дальнейнем, если например, она пустая,
// а потом мы будем использовать лучше сразу определить ее тип int, float, double 
float eur = 100;
// BEGIN (write your solution here)
double dol = eur * 1.25;
Console.WriteLine(dol);
double rur = dol * 80; //<= здесь изменил на 80, чтобы в консоли была видна разница
Console.WriteLine(rur);
// END





