// Задача НЕГАФИБОНАЧЧИ. Задайте число. 
// Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 8 список будет выглядеть 
// так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

Console.WriteLine("Введите величину ряда k");
int k = Convert.ToInt32(Console.ReadLine());

int Fibonacci (int n)
{
    if (n==1 || n==2 || n ==(-1) ) return 1;
    else if(n>0) return Fibonacci(n-1) + Fibonacci(n-2);
    else if(n<0) return (Fibonacci(n+1)*(-1)) + Fibonacci(n+2);
    else return 0;
}

for (int i=-k; i<(k+1); i++)
{
    Console.Write($"{Fibonacci(i)}, ");
}