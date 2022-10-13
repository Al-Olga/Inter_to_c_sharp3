// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число А= ");
int a = int.Parse(Console.ReadLine() ?? "0");

int sum = 0;
int numb = a;
while (numb>0)
{
    sum = sum + (numb%10);
    numb = numb/10;
}

Console.WriteLine($"Сумма всех чисел числа {a}= {sum}");