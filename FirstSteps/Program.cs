Console.Write("Введите №: ");
string? input = Console.ReadLine();
if (!int.TryParse(input, out int n))
{
    Console.WriteLine("Ты дурак, блять?");
    return;
}

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0)
    {
        if (i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            Console.WriteLine("Fizz");
        }
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else Console.WriteLine(i);
}