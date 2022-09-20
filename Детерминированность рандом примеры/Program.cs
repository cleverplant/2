Random rndu = new Random();
var output = rndu.Next(0, 10);
var outputAsNumber = Convert.ToInt32(output);
Console.WriteLine(outputAsNumber);


Random rnd = new Random();//Создание объекта для генерации чисел
int value = rnd.Next();//Получить случайное число 
Console.WriteLine(value);

//Получить случайное число (в диапазоне от 0 до 10)
int value1 = rnd.Next(0, 10); 
Console.WriteLine(value1);

//Создание объекта для генерации чисел (с указанием начального значения)
Random rndum = new Random(24);
int value3 = rndum.Next();
Console.WriteLine(value3);
