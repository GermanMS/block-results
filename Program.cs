﻿//создать массив, потом из этого массива создать еще один, но только взять те значения у которых длины 3 или менее символов
// дописать если их нет!!!!!
Console.WriteLine("введите длину массива x");
int x = Convert.ToInt32(Console.ReadLine());
string [] A = new string [x];
int b = 0;
for   (int i = 0; i < A.Length; i++)
    {
     Console.WriteLine($" Введите элемент массива под индексом {i}: x");
     A [i] = Console.ReadLine();
    }
Console.WriteLine("вывод массива");
