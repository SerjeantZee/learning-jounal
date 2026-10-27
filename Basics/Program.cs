static bool IsEven(int n)
{
    return n % 2 == 0;
}

static bool Pol(string s)
{
    for(int i = 0; i < s.Length; i++)
    {
        if (s[i] != s[s.Length - 1 - i]) return false;
    }
    return true;
}

for (int i = 1; i <= 20; i++)
{
    if (IsEven(i)) {
        Console.WriteLine(i);
    }
}

string? input = Console.ReadLine();

if (Pol(input.ToLower())) {
    Console.WriteLine("Строка является палиндромом");
}
else
{
    Console.WriteLine("Строка не является палиндромом");
}