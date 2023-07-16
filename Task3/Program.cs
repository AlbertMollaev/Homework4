// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void GetStepen(int a) 
{
    int sum1 = a / 1000;  
    int sum2 = a / 100 % 10;
    int sum3 = a % 100 / 10;    
    int sum4 = a % 10;    
    if (a > 9 & a < 100) {
        int result = sum3 + sum4;
        Console.WriteLine($"Сумма чисел {a} равна : {result}");
    }
    if (a > 99 & a < 1000) {
        int result = sum2 + sum3 + sum4;
        Console.WriteLine($"Сумма чисел {a} равна : {result}");
    }
    if (a > 999 & a < 10000 ) {
        int result = sum1 + sum2 + sum3 + sum4;
        Console.WriteLine($"Сумма чисел {a} равна : {result}");
    }

}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите число : ");;
GetStepen(a);