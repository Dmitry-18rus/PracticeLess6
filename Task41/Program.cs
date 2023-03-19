// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите величину массива ");
int M = Convert.ToInt32(Console.ReadLine());

int [] array = new int [M];
MetInput(array);
MetPrint(array);
MetCount(array);

void MetInput (int [] array)
{
    for (int i =0; i<array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}

void MetPrint ( int [] array)
{
    Console.Write("[");
    foreach (int el  in array)
        Console.Write($"{el} ");
    // Console.WriteLine();
    Console.WriteLine("]");
}

int MetCount(int [] array)
{
    int count = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    Console.WriteLine($"count = {count}");
return count;
}