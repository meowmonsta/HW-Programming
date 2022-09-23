//14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsAliquot7and23(int arg)
{
    return num % 7 == 0 && num % 23 == 0;
}

if (IsAliquot7and23(num)) Console.WriteLine($"{num} кратно 7 и 23");
else Console.WriteLine($"{num} не кратно 7 и 23");