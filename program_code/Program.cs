// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CrateArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите значения массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArrey(string[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write(']');
    Console.WriteLine();
}


string[] CrateNewArray(string[] array)
{
    string[] temp = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            temp[j] = array[i];
            j++;
        }
    }
    string[] arr = new string[j];
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = temp[k];
    }
    return arr;
}
Console.Clear();
Console.WriteLine();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = CrateArray(n);
Console.WriteLine();
Console.Write("Исходный массив: ");
PrintArrey(array);
Console.Write("Новый массив: ");
PrintArrey(CrateNewArray(array));
Console.WriteLine();
