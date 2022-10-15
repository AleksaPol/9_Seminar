// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
// который выведет все натуральные числа кратные 3-ём 
// в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

void Zadacha64()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 64.");
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    FindNatural(number, m);
    void FindNatural(int number, int counter)
    {
        if (counter > number)
            return;
        if (counter % 3 == 0)
        {
            Console.WriteLine(counter);
            counter++;
        }
        else counter++;
        FindNatural(number, counter);
    }
}
Zadacha64();

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

void Zadacha66()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 66.");
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    FindSum(number, m);
    void FindSum(int number, int counter = 0, int result = 0)
    {
        if (counter > number)
        {
            Console.WriteLine(result);
            return;
        }

        result += counter;
        counter++;
        FindSum(number, counter, result);
    }
}
Zadacha66();


// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
void Zadacha68()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 68.");
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A(m, n) = {Akkerman(m, n)}");
    int Akkerman(int m, int n)
    {
        if (n < 0 || m < 0) return Akkerman(n, m);
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
Zadacha68();

