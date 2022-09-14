// Оператор такой же, как и при сложении чисел
// но здесь он имеет другой смысл (семантику)
Console.WriteLine("Dragon" + "stone");
// => Dragonstone
Console.WriteLine("Kings" + "wood"); // => Kingswood
// Обратный порядок слов
Console.WriteLine("road" + "Kings"); // => roadKings
// Конкатенировать можно абсолютно любые строки
Console.WriteLine("King's" + "Landing"); // => King'sLanding

// Ставим пробел в левой части
Console.WriteLine("King's " + "Landing"); //  => King's Landing

// Ставим пробел в правой части
Console.WriteLine("King's" + " Landing"); //  => King's Landing

// Добавляем пробел отдельно
Console.WriteLine("King's" + " " + "Landing"); //  => King's Landing
Console.WriteLine("King's " + " Landing");   // => King's  Landing
Console.WriteLine("King's  " + "  Landing"); // => King's    Landing

//Задание
//Используя Console.WriteLine(), выполните конкатенацию слов и выведите на экран фразу:
//   Winter came for the House of Frey.
Console.WriteLine("Winter " + "came " + "for " + "the " + "House " + "of " + "Frey.");



