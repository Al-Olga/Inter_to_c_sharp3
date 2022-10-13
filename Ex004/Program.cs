// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите количество чисел N= ");
int number = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
double kub = 0;
if (number<0) number=number*(-1);
else if (number==0) 
{
    Console.WriteLine("Так как введено число = 0, принимаем количество чисел = 1");
    number=1;
}

while (i<=number)
{
    kub = i*i*i;
    if (kub%2==0) Console.WriteLine($"Куб числа {i}= {kub}");
    i++;
}
