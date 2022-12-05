// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Random rand = new  Random();
int size = rand.Next(1,6);
Console.WriteLine("Количество вводимых чисел " + size);
int count = 0;
for(int i=0; i<size;i++)
{
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x>0) count++;
}
Console.WriteLine("\n"+ "Количество положительных чисел " + count);