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

static int CountWords(string s)
{
    return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
}

static int MaxPoint(int[] arr)
{
    int mp = arr[0];
    foreach (int z in arr)
    {
        if (z > mp) mp = z;
    }
    return mp;
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

string? input2 = Console.ReadLine();
Console.WriteLine($"В вашей строке {CountWords(input2)} слов");

int[] arr = {1, 2, 3, 6, -2, 8, 16, -10, 999, -456, 8, 11};

Console.WriteLine(MaxPoint(arr));