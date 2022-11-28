//Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от 1 до N.
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// FillArray(number, array);
// PrintArray(array);

// void FillArray(int number, int []array, int count = 0)
// {

//     if (count + 1 > number)
//     {
//         return;
//     }
//     array[count] = count + 1;
//     count++;
//     FillArray(number, array, count);



// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от M до N.

// int begin = Convert.ToInt32(Console.ReadLine());
// int endNumber = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[endNumber - begin +1];
// FillArray(endNumber, array, 0, begin);

// PrintArray(array);

// void FillArray(int number, int []array, int count = 0, int beginNumber = 1)
// {

//     if (count > number - beginNumber)
//     {
//         return;
//     }
//     array[count] = count + beginNumber;
//     count++;
//     FillArray(number, array, count,beginNumber);



// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

//Напишите программу, которая будет принимать 
//на вход число и возвращать сумму его цифр.

// int number = Convert.ToInt32(Console.ReadLine());
// int sum = SumOfDigits(number);
// Console.WriteLine(sum);
// int SumOfDigits(int number)
// {
//     int sum = 0;
//     if (number != 0)
//     {
//         int temp = number % 10;
//         number /= 10;
//         sum += temp;
//         sum += SumOfDigits(number);
//     }
//     return sum;
// }

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int exp = Exponentiate(A, B);
Console.WriteLine(exp);
int Exponentiate(int A, int B)
{
    int exp = 1;
    if (B != 0)
    {
        exp *= A;
        B--;
        exp *= Exponentiate(A,B); 
    }
    return exp;
}


//123
Console.WriteLine("Hello, World!");
Recursive(5, 1);
For(5, 1);

void Recursive(int a, int i = 0)
{
    if (i == a)
    {
        return;
    }
    Console.WriteLine(i);
    Recursive(a, i + 1);
}

void For(int a, int i = 0)
{
    for (; i != a; i++)
    {
        Console.WriteLine(i);
    }
}
