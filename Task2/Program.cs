// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void GetStepen(int a, int b) 
{
    
    double sum = Convert.ToInt32(Math.Pow(a, b));
    Console.WriteLine($"Число {a} возведенное в степень {b} равна {sum}");
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите число A : ");
int b = GetInput("Введите число B : ");
GetStepen(a,b);