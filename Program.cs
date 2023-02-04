// // Задача 41: Пользователь вводит с клавиатуры
// M чисел. Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

int[] Numbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
    begin:
        System.Console.WriteLine($"Введите число № {i + 1} : ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            arr[i] = number;
        }
        else
        {
            System.Console.WriteLine("Неправильный ввод");
            goto begin;
        }
    }
    return arr;
}

int count = 0;
int Count(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine("Введите число M: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = Numbers(num);
PrintArray(array);

Count(array);
System.Console.WriteLine($"Положителных чисел в последовательности: {count}.");

