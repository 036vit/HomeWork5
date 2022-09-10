//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Запрашиваем у пользователя размер массива
Console.WriteLine("Введите размер массива:  ");

// Конвертируем введённый символ в число
int size = Convert.ToInt32(Console.ReadLine());

// Создаём массив, который по размеру соответствует введённому
int[] numbers = new int[size];

// Наполняем массив числами
FillArrayRandomNumbers(numbers);

//Выводим на консоль массив
PrintArray(numbers);

//Вводим число чётных чисел = 0
int count = 0;

// Считаем сколько чисел при дилении на 2 не дают остаток
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

// Выводим на консоль количество чётных чисел
Console.WriteLine($" -> {count}");

// Возврщаем в массив трёхзначные числа
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

// Добавляем в Принтерей скобочки
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}