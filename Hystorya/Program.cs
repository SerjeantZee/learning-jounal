Console.WriteLine("Добро пожаловать в программу тестирования по истории)");
Console.WriteLine("Вам будут заданы вопросы, на которые нужно будет ответить. Введите номер ответа и нажмите Enter.");
Console.WriteLine("На каждый вопрос будет предоставлено несколько вариантов ответов, из которых только один является правильным.");
Console.WriteLine("После того как вы ответите на все вопросы, программа покажет вам ваш результат.");
Console.WriteLine("Удачи!");

int score = 0;
string? input = "";

static int AskQuestion(int total, string? input, int answer)
{
    if (string.IsNullOrEmpty(input)) return total;
    if (Convert.ToInt32(input) == answer) return total + 1;
    else return total;
}

Console.WriteLine("Вопрос 1: В каком году произошло крещение Руси?");
Console.WriteLine("1. 988 год");
Console.WriteLine("2. 1240 год");   
Console.WriteLine("3. 998 год");
input = Console.ReadLine();
score = AskQuestion(score, input, 1);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 2: Какой московский правитель первым официально принял титул царя?");
Console.WriteLine("1. Иван IV");
Console.WriteLine("2. Алексей I");
Console.WriteLine("3. Петр I");
input = Console.ReadLine();
score = AskQuestion(score, input, 1);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 3: Какой период российской истории называют Смутным временем?");
Console.WriteLine("1. 1480–1505 гг.");
Console.WriteLine("2. 1547–1565 гг.");
Console.WriteLine("3. 1598–1613 гг.");
input = Console.ReadLine();
score = AskQuestion(score, input, 3);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 4: Кто стал первым царём из династии Романовых?");
Console.WriteLine("1. Пётр I");
Console.WriteLine("2. Алексей Михайлович");
Console.WriteLine("3. Михаил Фёдорович");
input = Console.ReadLine();
score = AskQuestion(score, input, 3);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 5: Какой город был столицей России до Москвы?");
Console.WriteLine("1. Новгород");   
Console.WriteLine("2. Киев");
Console.WriteLine("3. Казань");
input = Console.ReadLine();
score = AskQuestion(score, input, 2);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 6: Какой российский император подписал указ о создании Академии наук?");
Console.WriteLine("1. Екатерина II");
Console.WriteLine("2. Александр I");
Console.WriteLine("3. Пётр I");
input = Console.ReadLine(); 
score = AskQuestion(score, input, 3);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 7: Кем приходится Пётр I своему преемнику Петру II?");
Console.WriteLine("1. Дедом");
Console.WriteLine("2. Дядей");
Console.WriteLine("3. Отцом");
input = Console.ReadLine();
score = AskQuestion(score, input, 1);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 8: Кто способствовал восхождению Елизаветы на трон?");
Console.WriteLine("1. Столбовая аристократия");
Console.WriteLine("2. Немецкие элиты");
Console.WriteLine("3. Гвардейские офицеры");
input = Console.ReadLine();
score = AskQuestion(score, input, 3);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 9: Кто возглавил русское войско в Куликовской битве?");
Console.WriteLine("1. Александр Невский");
Console.WriteLine("2. Дмитрий Донской");
Console.WriteLine("3. Иван III");
input = Console.ReadLine();
score = AskQuestion(score, input, 2);
Console.WriteLine("Текущий счет: " + score);

Console.WriteLine("Вопрос 10: Какое событие традиционно считается началом монгольского нашествия на Русь?");
Console.WriteLine("1. Ледовое побоище в 1242 году");
Console.WriteLine("2. Осада Киева в 1240 году");
Console.WriteLine("3. Битва на реке Калке в 1238 году");
input = Console.ReadLine();
score = AskQuestion(score, input, 3);
Console.WriteLine("Текущий счет: " + score);

switch (score)
{
    case 10:
        Console.WriteLine("Отлично! Вы набрали максимальное количество баллов!");
        break;
    case 8:
    case 9:
        Console.WriteLine("Хорошо! Вы набрали " + score + " баллов!");
        break;
    case 5:
    case 6:
    case 7:
        Console.WriteLine("Неплохо! Вы набрали " + score + " баллов!");
        break;
    default:
        Console.WriteLine("К сожалению, вы набрали всего " + score + " баллов. Попробуйте снова!");
        break;
}