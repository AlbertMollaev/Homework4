// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void GetArray(int [] args) 
{
    int length = args.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите эллемент массива для заполнения {i}: ");
        args[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < length; i++) 
    {
        Console.WriteLine(string.Join(" , " ,  args[i] ));
    }
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите размер массива : ");
int [] array = new int [num];
GetArray(array);
