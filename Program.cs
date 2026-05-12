Console.WriteLine("Quyidagi vazifalardan birini tanlang");
Console.WriteLine("1. Array elementlari yig'indisi");
Console.WriteLine("2. Eng katta va eng kichik qiymat");
Console.WriteLine("3. Juft va toq sonlar");
Console.WriteLine("4. O'rtacha qiymat");
Console.WriteLine("5. String teskarisi");
Console.WriteLine("6. Unli va undosh harflar soni");
Console.WriteLine("7. Palindrome tekshirish");
Console.WriteLine("8. String birlashmasi");
Console.WriteLine("9. String ichidan belgilarni olib tashlash");
Console.WriteLine("10. Stringni belgi orqali qo'shib yozish");

Console.Write("Kerakli bo'limni tanlang: ");
string option = Console.ReadLine();

switch (option)
{
    case "1":
        {
            int[] numbers = new int[10];

            Console.WriteLine("Array ning 10 ta elementini kiriting.");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}-elementi: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int summa = AddArrayElements(numbers);

            Console.WriteLine($"Ushbu sonlarning yig'indisi: {summa}");
            break;
        }
    case "2":
        {
            int[] numbers = RandomArrayElements();
            
            ShowArrayElements(numbers);

            int minElement = numbers[0];
            int maxElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minElement)
                    minElement = numbers[i];

                if (numbers[i] > maxElement)
                    maxElement = numbers[i];
            }

            Console.WriteLine($"\nEng katta elementi: {maxElement}\nEng kichik elementi: {minElement}");
            break;
        }
    case "3":
        {
            int[] numbers = RandomArrayElements();

            ShowArrayElements(numbers);

            Console.Write("\nArray ning juft elementlari: ");
            GetEvenNumbers(numbers);

            Console.Write("Array ning toq elementlari: ");
            GetOddNumbers(numbers);

            break;
        }
    case "4":
        {
            int[] numbers = RandomArrayElements();

            ShowArrayElements(numbers);

            double averageElement = GetAverageValue(numbers);
            Console.WriteLine($"O'rtacha qiymati: {averageElement}");
            break;
        }
    default:
        Console.WriteLine("Noto'g'ri bo'lim raqamini kiritdingiz");
        break;
}

static int[] RandomArrayElements()
{
    Random randomObject = new Random();
    int[] randomArrayNumbers = new int[10];

    for (int i = 0; i < 10; i++)
    {
        randomArrayNumbers[i] = randomObject.Next(1, 10);
    }

    return randomArrayNumbers;
}

static void ShowArrayElements(int[] numbers)
{
    Console.Write("Array elementlari: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

static int AddArrayElements(int[] numbers)
{
    int summa = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        summa += numbers[i];
    }

    return summa;
}

static void GetEvenNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

static void GetOddNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1)
            Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

static double GetAverageValue(int[] numbers) =>
    Convert.ToDouble(AddArrayElements(numbers) / numbers.Length);