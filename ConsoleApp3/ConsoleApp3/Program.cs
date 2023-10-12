Console.WriteLine("task1");
Queue<string> monthsQueue = new Queue<string>();


monthsQueue.Enqueue("Сiчень");
monthsQueue.Enqueue("Лютий");
monthsQueue.Enqueue("Березень");
monthsQueue.Enqueue("Квiтень");
monthsQueue.Enqueue("Травень");
Console.WriteLine("Кількість елементів у колекції: " + monthsQueue.Count + "\n");



Console.WriteLine("Елементи у прямому порядку:");
foreach (string month in monthsQueue)
{
    Console.WriteLine(month);
}


Console.WriteLine("\nЕлементи у зворотньому порядку:");


Stack<string> stack = new Stack<string>();
while (monthsQueue.Count > 0)
{
    stack.Push(monthsQueue.Dequeue());
}

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}





monthsQueue.Clear();
Console.WriteLine("\nколекцію очищено\n");



Console.WriteLine("task2");
List<int> numbers = GenerateRandomNumbers(10, -10, 10);
int positiveCount, negativeCount, zeroCount;

AnalyzeNumbers(numbers, out positiveCount, out negativeCount, out zeroCount);

Console.WriteLine("Кількість додатніх чисел: " + positiveCount);
Console.WriteLine("Кількість від'ємних чисел: " + negativeCount);
Console.WriteLine("Кількість нулів: " + zeroCount);
    

    static List<int> GenerateRandomNumbers(int count, int min, int max)
{
    Random random = new Random();
    List<int> numbers = new List<int>();

    for (int i = 0; i < count; i++)
    {
        numbers.Add(random.Next(min, max + 1));
    }

    return numbers;
}

static void AnalyzeNumbers(List<int> numbers, out int positiveCount, out int negativeCount, out int zeroCount)
{
    positiveCount = 0;
    negativeCount = 0;
    zeroCount = 0;

    foreach (int num in numbers)
    {
        if (num > 0)
        {
            positiveCount++;
        }
        else if (num < 0)
        {
            negativeCount++;
        }
        else
        {
            zeroCount++;
        }
    }
}
Console.ReadLine();