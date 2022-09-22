Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int summ = 0;
for (int x = 0; x < numbers.Length; x++)
if (numbers[x] % 2 == 1)
summ = numbers[x] + summ;
PrintArray(numbers);
Console.WriteLine(summ);
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
        
}
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
     for(int i = 0; i < numbers.Length; i++)
     { if (i < numbers.Length - 1)
     {
     Console.Write(numbers[i] + ", ");
     }
     else Console.Write(numbers[i] + "");
     }
    Console.Write("]");
    Console.Write(" -> ");
}
