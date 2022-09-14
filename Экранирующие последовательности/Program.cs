// символ перевода строки: \n
//  \n — всего лишь способ записать символ перевода строки, 
//но сам перевод строки по своему смыслу – это один символ, правда, невидимый.
//  \n — это пример экранирующей последовательности (escape sequence)
// Мы это не изучали, но вы должны знать правду
// Ниже код, который возвращает длину строки
//  "a".Length;    // 1
//  "\n".Length;   // 1 !!!
//  "\n\n".Length; // 2 !!!

Console.WriteLine("- Are you hungry?\n- Aaaarrrgh!");
Console.WriteLine("Gregor Clegane\nDunsen\nPolliver\nChiswyck");
Console.WriteLine("\n");
Console.WriteLine("Dunsen");
//Почему перед строкой Dunsen появилось две пустые строки, а не одна? 
//Дело в том, что Console.WriteLine() при выводе значения автоматически добавляет 
//в конец символ перевода строки. Таким образом, один перевод строки мы указали явно, 
//передав этот символ экранирующей последовательности аргументом в функцию, 
//а второй перевод строки добавлен самой функцией автоматически.

//Ещё пример кода:
Console.WriteLine("Polliver");
Console.WriteLine("Gregor Clegane");
Console.WriteLine();
Console.WriteLine("Chiswyck");
Console.WriteLine("\n");
Console.WriteLine("Dunsen");

Console.WriteLine("Joffrey loves using \\n");

//Задание
//Напишите программу, которая выводит на экран:
Console.WriteLine("- Did Joffrey agree?");
Console.WriteLine("- He did. He also said \"I love using \\n\".");






