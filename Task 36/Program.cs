//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] numbers = new int[4];

void FillArray(int[] array, int min, int max){
for (int i = 0; i<array.Length; i++ ){
array[i] = new Random().Next(min, max);
}
}
 Console.Write("[ ");
void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
       Console.Write(array[i] + ", ");

  }
   Console.Write(" ] -> " );
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 1; i<array.Length; i = i + 2 ){
      {
      quantity = quantity + array[i];
    }
  }
  return quantity;
}
FillArray(numbers, 0, 100);
WriteArray(numbers);
int quantity = QuantityPositive(numbers);
Console.Write($"{quantity}");