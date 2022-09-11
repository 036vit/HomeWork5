// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Создаём массив вещественных чисел (double)
double[] array = new double[5];
Console.Write("[ ");
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
  }
Console.Write("] -> " );
double maxNumber = array[0];
double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.Write($"{decision}");