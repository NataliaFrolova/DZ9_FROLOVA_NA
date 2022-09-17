/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

Start();

void Start()
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Press enter: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.WriteLine();
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine();
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine();
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return;
            case 64: task64(); break;
            case 66: task66(); break;
            case 68: task68(); break;

            default: Console.WriteLine("error"); break;
        }
    }
}
//task64
void task64()
{
    int NumbersToN(int number1, int number2)
    {
        if (number1 > number2) return number2;
        else
        {
            Console.Write(number1 + ", ");
            number1++;
        }
        return NumbersToN(number1++, number2);
    }

    Console.WriteLine("Введите значение M: ");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение N: ");
    int N = int.Parse(Console.ReadLine());

    NumbersToN(M, N);
    return;
}
//task66
void task66()
{
    Console.WriteLine("Введите значение M: ");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение N: ");
    int N = int.Parse(Console.ReadLine());

    int Sum(int M, int N)
    {
        if (N == M) return N;
        return M + Sum(M + 1, N);
    }
    Console.WriteLine($"Сумма элементов в промежутке между {M} и {N} равна {Sum(M, N)} ");
    return;
}
//task68
void task68()
{
    int m = InputNumbers("Введите m: "); 
    int n = InputNumbers("Введите n: "); 
    int functionAkkerman = A(m, n); // обозначение функции Аккермана
    Console.Write($"-> A(m,n)= {functionAkkerman} "); // запись текстового значения для функции Аккермана

    int A(int m, int n) // метод обозначения функции Аккермана с помощью рекурсии
    {
        if (m == 0) return n + 1; // если первая переменная равна 0, возвращаем вторую переменную + 1
        
       else if (n == 0) return A(m - 1, 1); // если вторая переменная равна 0, возвращаем функцию Аккермана со занчениями (первая переменная, переменная -1; 1)
        
            return A(m - 1, A(m, n - 1));// возвращаем функцию Аккермана со значениями (первая переменная -1, функция Аккермана со значениями (первая переменная, вторая переменная -1 ))
    }

    int InputNumbers(string input) // метод ввода чисел для строки 
    {
        Console.Write(input); // запись текстового значения для входного значения
        int output = int.Parse(Console.ReadLine()); // создание выходного значения
        return output; // возращаем выходное значение
    }
    return;
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

