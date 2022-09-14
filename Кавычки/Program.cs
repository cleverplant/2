﻿// Любой одиночный символ в кавычках — это строка. Пустая строка "" — это тоже строка. 
//То есть строкой мы считаем всё, что находится внутри кавычек, даже если это пробел, 
//один символ или вообще отсутствие символов.

// Завершится с синтаксической ошибкой
//Console.WriteLine("Dragon's mother said "No"");
//Для вывода таких строк используют символ экранирования: \. 
//Если поставить \ перед кавычкой, это будет означать, 
//что кавычку нужно рассматривать не как начало или конец строки, а как часть строки.

Console.WriteLine("Dragon's mother said \"No\"");

//Задание
//Напишите программу, которая выведет на экран:
Console.WriteLine("\"Khal Drogo's favorite word is \"athjahakar\"\"  ");



