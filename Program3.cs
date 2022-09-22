Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;    
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}
PrintArray(numbers);
Console.WriteLine(max - min);
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
        
}
}
void PrintArray(double[] numbers)
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
