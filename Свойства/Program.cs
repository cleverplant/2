﻿/*
Помимо методов у объектов могут быть еще свойства. 
Мы уже видели свойство Length у строк.

"Hexlet".Length;  // 6

Главная задача свойств 
– обеспечить доступ к внутренним данным класса или объекта. 

Свойства очень похоже на методы – их тоже нужно вызывать, 
чтобы получить значение. Скобочки при этом писать не надо.
*/
var name = "Sansa";
var house = "Stark";

var totalSymbols = name.Length + house.Length;
Console.WriteLine(totalSymbols);  // => 10

/*
Свойства есть и у типов. 
Такие свойства называются статическими. 

Например у всех числовых типов (byte, short, int, long и т.д.) 
есть свойства MinValue и MaxValue.
*/
// byte.MaxValue; // 255
// short.MaxValue; // 32767
// int.MaxValue; // 2147483647
// long.MaxValue; // 9223372036854775807

/*
Так как свойства вызываются без скобочек, их нельзя вызывать с параметрами.

Задание
Создайте строку c именем "Robert I Baratheon" и, 
используя свойство Length этой строки, выведите на экран:

Robert I Baratheon has 18 characters in his name
*/
var stringer = "Robert I Baratheon";//
Console.WriteLine(stringer + " has " + stringer.Length + " characters in his name");
Console.WriteLine($"{stringer} {"has"} {stringer.Length} {"characters in his name"}");



