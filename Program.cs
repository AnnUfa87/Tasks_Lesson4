//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int PowerOfNumber (int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int involution = PowerOfNumber(numberA, numberB);
Console.WriteLine("Значение числа А в натуральной степени В равно: " + involution);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num != 0)
{
    sum = sum + num % 10;
    num/= 10;
}
Console.WriteLine("Количество цифр в заданном числе: " + sum);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arr)
{
Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nВывод массива:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ",");
}

}
int[] massiv = new int [8];
FillArray(massiv);

