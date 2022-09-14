//Переменные и конкатенацию можно объединять. /
//Синтаксически ничего не меняется: мы умеем конкатенировать (склеивать) две строки:
var what = "Kings" + "road";
Console.WriteLine(what); // => "Kingsroad"
//… а значит сумеем конкатенировать строку и одну переменную, в которой записана строка:
var firs = "Kings";
var wha = firs + "road";
Console.WriteLine(wha); // => "Kingsroad"
//… и даже конкатенировать две переменные, в которых записаны строки:
var fir = "Kings";
var last = "road";
var wh = fir + last;
Console.WriteLine(wh); //=> "Kingsroad"

//Задание
//Если где-то в базе сайта хранится имя человека в виде строки, 
//tо задача генерации заголовка сводится к конкатенации: например, 
//нужно склеить строку Здравствуйте со строкой, где записано имя.
//Напишите программу, которая будет генерировать заголовок и тело письма, 
//используя уже готовые переменные, и выводить получившиеся строки на экран.
//Напишите программу, которая будет генерировать заголовок и тело письма, 
//используя уже готовые переменные, и выводить получившиеся строки на экран.
var par = "==============";
Console.WriteLine(par) ;
var info = "We couldn't verify you mother's maiden name.";
var intro = "Here is important information about your account security.";
var firstName = "Joffrey";
var greeting = "Hello";

// BEGIN (write your solution here)
Console.WriteLine(greeting  + ", " + firstName + '!') ;
Console.WriteLine(intro) ;
Console.WriteLine(info) ;
// END
//Hello, Joffrey!
//Hello, Joffrey!
//Here is important information about your account security.
//Here is important information about your account security.
//We couldn't verify you mother's maiden name.
//We couldn't verify you mother's maiden name.

