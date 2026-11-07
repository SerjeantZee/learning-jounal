using System.Linq;

int[] target = [0];
int summ = 0;

static bool IsInputCheck (string? i)
{
    bool Check = true;
    foreach (string z in i.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        if (!int.TryParse(z, out int n))
        {
            Check = false;
            break;
        }
    }
    return Check;
}

static int[][] IsBroot (int[] arr, int summ)
{
    int[][] result = [];
    for (int i = 0; i <= arr.Length; i++)
    {
        for (int z = i+1; z < arr.Length; z++) if (arr[i] + arr[z] == summ) result = result.Append(new[] {i, z}).ToArray();
    }
    return result;
}

static List<(int, int)> AllPairs(int[] nums, int target)
{
    var seen = new Dictionary<int, List<int>>();
    var pairs = new List<(int, int)>();

    for (int i = 0; i < nums.Length; i++)
    {
        int need = target - nums[i];

        if (seen.TryGetValue(need, out List<int>? indexes))
            foreach (int j in indexes)
                pairs.Addтек,i));
                                                                                                                                                                                                             
        if(!seen.ContainsKey(nums[i]))
            seen[nums[i]] = new List<int>();
        seen[nums[i]].Add(i);
    }
    return pairs;
}

Console.Write("Введите необходимый массив чисел через пробел: ");
bool input_checkup = false;
while (!input_checkup){
    string? input = Console.ReadLine();
    if (IsInputCheck(input))
    {
        input_checkup = true;
        target = input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    } 
    else Console.WriteLine("Некорректный ввод. Попробуйте снова");
} 

// Console.WriteLine("Ваш массив: ");
// for (int i = 0; i <= target.Length - 1; i++) Console.Write($"{target[i]} ");

Console.Write("Введите искомую сумму:");
input_checkup = false;
while (!input_checkup)
{
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int n))
    {
        input_checkup = true;
        summ = n;
    }
}

int[][] res = IsBroot(target, summ);

for (int i = 0; i < res.Length; i++)
{
    for (int z = 0; z < res[i].Length; z++)
    {
        Console.Write($"{res[i][z]} ");
    }
    Console.WriteLine();
}
if (res.Length == 0) Console.WriteLine("Пара не найдена");
Console.WriteLine();

var pairs = AllPairs(target, summ);

if (pairs.Count == 0) Console.WriteLine("Пара не найдена");
foreach (var (a, b) in pairs)
    Console.WriteLine($"{a} {b}");