// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k, на которое будут делится цифры из числа n");
int k=int.Parse(Console.ReadLine());

int rez = 0;
int razrd = 1;

while(n > 0)
{
    int number = n % 10;
    if (number % k == 0)
    {
        number = 0;
        rez = rez + number * razrd;
    }
    else
    {
        rez = rez + number * razrd;
    }
    razrd = razrd * 10;
    n = n / 10;
}
Console.WriteLine(rez);
