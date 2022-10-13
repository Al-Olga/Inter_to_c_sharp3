// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите количество чисел N= ");
int number = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
double mult = 1;
if (number<0) number=number*(-1);
else if (number==0) 
{
    Console.WriteLine("Так как введено число = 0, принимаем количество чисел = 1");
    number=1;
}

while (i<=number)
{
    mult = mult*i;
    i++;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {mult}");