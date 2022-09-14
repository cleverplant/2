// Переменная должна быть определена до того, как будет использована.

//Console.WriteLine(greeting);
//greeting = "Father!";
//Запуск программы выше завершается с ошибкой:
//error CS0103: The name 'greeting' does not exist in the current context

//Еще одна распространенная ошибка — попытаться объявить уже объявленную переменную:
//var greeting = "Father!";
//var greeting = "Father!";

//Задание
//Найдите в программе необъявленную переменную и объявите ее, 
//присвоив ей значение "Dragon";
var family = "Targaryen";
// BEGIN (write your solution here)
var pet = "Dragon";
// END
Console.WriteLine(family + " and " + pet);

