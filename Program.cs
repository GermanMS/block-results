//создать массив, потом из этого массива создать еще один, но только взять те значения у которых длины 3 или менее символов
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
for   (int i = 0; i < A.Length; i++)
{
Console.Write(A[i] + " ");
}
for (int i = 0; i < A.Length; i++)
{
    if ( A[i].Length <= 3 )
    {
       b = b+1;
    }
}
string  [] A2 = new string [b];
for (int i = 0; i < A2.Length; i++)
{
    if (A[i].Length <= 3)
    {
       A2[i] = A[i];
    }
    
}
Console.WriteLine("\n вывод нового массива");
for   (int i = 0; i < A2.Length; i++)
{
Console.Write(A2[i]+ " ");
}
Console.WriteLine($"\n {b} длина массива");
