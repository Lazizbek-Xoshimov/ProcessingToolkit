using System.Text;

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
    case "5":
        {
            Console.Write("Teskarisini ko'rmoqchi bo'lgan string qatorini kiriting: ");
            string userInput = Console.ReadLine();
            string oppositeString = GetOppositeString(userInput);

            Console.WriteLine($"Teskariga aylangan string: {oppositeString}");
            break;
        }
    case "6":
        {
            Console.Write("Harflari statistikasini ko'rmoqchi bo'lgan qatoringizni kiriting: ");
            string userInput = Console.ReadLine();

            int vowelLetterCount = GetVowelLettersCount(userInput);
            Console.WriteLine($"Unli harflar soni: {vowelLetterCount}");

            int consonantLetterCount = GetConsonantLettersCount(userInput);
            Console.WriteLine($"Undosh harflar soni: {consonantLetterCount}");
            break;
        }
    case "7":
        {
            Console.Write("Palindromlikka tekshiruvchi qatoringizni kiriting: ");
            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
                Console.WriteLine("Kiritgan qatoringiz palindrome.");
            else
                Console.WriteLine("Kiritgan qatoringiz palindrome emas.");
            break;
        }
    case "8":
        {
            Console.WriteLine("5 ta so'z kiriting");
            StringBuilder stringBuilderObject = CombineStrings();

            Console.WriteLine($"Birlashishdan so'ng quyidagi gap hosil bo'ldi: {stringBuilderObject}");
            break;
        }
    case "9":
        {
            Console.Write("Space larni olib tashlamoqchi bo'lgan gapni kiriting: ");
            string userInput = Console.ReadLine();

            StringBuilder stringBuilderObject = RemoveSpaces(userInput);

            Console.WriteLine($"Hosil bo'lgan gap qatori: {stringBuilderObject}");
            break;
        }
    case "10":
        {
            string[] names = new string[5];

            Console.WriteLine("5 ta ism kiriting");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i}-ism: ");
                names[i] = Console.ReadLine();
            }

            StringBuilder stringBuilderObject = AddComma(names);

            Console.WriteLine($"Vergul qo'shilgan natijadagi qator: {stringBuilderObject}");
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
    Console.WriteLine();
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

static string GetOppositeString(string userInput)
{
    string oppositeString = String.Empty;

    for (int i = userInput.Length - 1; i >= 0; i --)
        oppositeString += userInput[i];

    return oppositeString;
}

static int GetVowelLettersCount(string userInput)
{
    int vowelLetterCount = 0;

    Console.Write("Kiritgan qatoringizdagi unli harflar: ");
    foreach (char letter in userInput.ToLower())
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.Write(letter);
            vowelLetterCount ++;
        }
    }
    Console.WriteLine();

    return vowelLetterCount;
}

static int GetConsonantLettersCount(string userInput)
{
    int consonantLetterCount = 0;

    Console.Write("Kiritgan qatoringizdagi undosh harflar: ");
    foreach (char letter in userInput.ToLower())
    {
        if (letter > 'a' && letter <= 'z' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u')
        {
            Console.Write(letter);
            consonantLetterCount ++;
        }
    }
    Console.WriteLine();

    return consonantLetterCount;
}

static bool IsPalindrome(string userInput) => 
    userInput.Equals(GetOppositeString(userInput)) ? true : false;

static StringBuilder CombineStrings()
{
    StringBuilder stringBuilderObject = new StringBuilder();

    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"{i}-so'zingiz: ");
        string userInput = Console.ReadLine();

        stringBuilderObject.AppendFormat("{0}, ", userInput);
    }
    Console.WriteLine();

    return stringBuilderObject;
}

static StringBuilder RemoveSpaces(string userInput)
{
    StringBuilder stringBuilderObject = new StringBuilder(userInput);

    for (int i = 0; i < stringBuilderObject.Length; i++)
    {
        if (stringBuilderObject[i] == ' ')
            stringBuilderObject.Remove(i, 1);
    }

    return stringBuilderObject;
}

static StringBuilder AddComma(string[] names)
{
    StringBuilder stringBuilderObject = new StringBuilder();

    foreach(string name in names)
        stringBuilderObject.AppendFormat("{0}, ", name);

    return stringBuilderObject;
}