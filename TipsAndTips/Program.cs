static bool InputCheck(string s)
{
    if (double.TryParse(s, out double res)) return true;
    else return false;
}

static double InputConvert()
{
    while (true) 
    {
        string input = Console.ReadLine();
        if (InputCheck(input)) return double.Parse(input);
        else Console.WriteLine("Ввод неверный. Попробуйте снова!");
    }
}

Console.WriteLine("Приветствуем в программе Tips&Tips!");
Console.WriteLine("Введите сумму заказа: ");
double Order = InputConvert();

Console.WriteLine("Введите процент чаевых: ");
double TipsPs = InputConvert();

int Persons;
while (true)
{
    Console.WriteLine("Введите количество гостей: ");
    string input = Console.ReadLine();
    if (InputCheck(input))
    {
        Persons = Convert.ToInt32(double.Parse(input));
        break;
    }
    else Console.WriteLine("Ввод неверный. Попробуйте снова!");
}

Console.WriteLine($"Сумма заказа: {Order}; Количество гостей: {Persons}; Процент чаевых: {TipsPs}");

Console.WriteLine($"Общая сумма чаевых: {Order * 0.01 * TipsPs * Persons}");
Console.WriteLine($"Итоговая сумма заказа: {Order += Order * 0.01 * TipsPs * Persons}");
Console.WriteLine($"Сумма на одного гостя: {Order / Persons}");
