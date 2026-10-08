namespace practice07102026;

internal class Program
{
    static void Main(string[] args)
    {
        // усі типи існуючі та ті, що будемо створюватися самостійно є структурами
        // все створене нижче є локольно створені в стеку
        // цілі числа
        byte a0 = 1; // 1 byte
        short a1 = 4; // 2 bytes
        int a2 = 10; // 4 bytes
        long a3 = 20; // 8 bytes
        ushort a4 = 30; // тільки додатні числа

        bool a5 = true; // 1 byte

        // дробні 
        float b1 = 3.4f; // 4 bytes, літерал типу double, тому через сильну типізацію треба писати f
        double b2 = 3.4; // 8 bytes
        decimal b3 = 4.6m; // 16 bytes

        char ch = 'a'; // 2 bytes
        string s = "Hello";

        // об'єкт структури
        Boolean b = true;

        // об'єкт класу завжди буде створюватися у купі

        //Console.WriteLine("Result: {0} {1}", a1, a2);
        //Console.WriteLine($"Result: {a1} {a2}");
        //Console.WriteLine("Enter your name");
        //string name = Console.ReadLine()??"";
        //Console.WriteLine($"Welcome, {name}");
        //Console.WriteLine("Enter your age");
        //ushort age = Convert.ToUInt16(Console.ReadLine());

        // practice 1
        //ulong n1 = 1;
        //ulong n2 = 7;

        //ulong sum = 0;
        //sum = n1 + n2;

        //ulong diff = 0;
        //if (n1 >= n2)
        //{
        //    diff = n1 - n2;
        //}
        //else
        //{
        //    Console.WriteLine("ERROR! n1 must be greater or equal to n2");
        //}

        //ulong mul = 0;
        //mul = n1 * n2;

        //ulong fract = 0;
        //if (n2 != 0)
        //{
        //    fract = n1 / n2;
        //}
        //else
        //{
        //    Console.WriteLine("ERROR! Division by zero");
        //}

        //ulong rem = 0;
        //if (n2 != 0)
        //{
        //    rem = 1 % 7;
        //}
        //else
        //{
        //    Console.WriteLine("ERROR! Division by zero");
        //}
        //Console.WriteLine($"Sum: {sum}");
        //Console.WriteLine($"Diff: {diff}");
        //Console.WriteLine($"Mul: {mul}");
        //Console.WriteLine($"Fract: {fract}");
        //Console.WriteLine($"Rem: {rem}");

        // practice 2
        //Console.WriteLine("Please, enter a three-digit number");
        //int userThreeDigitNumber = Convert.ToUInt16(Console.ReadLine());
        //if (userThreeDigitNumber >= 100 && userThreeDigitNumber <= 999)
        //{
        //    int hundreds = userThreeDigitNumber / 100;
        //    int tens = (userThreeDigitNumber / 10) % 10;
        //    int units = userThreeDigitNumber % 10;

        //    Console.WriteLine($"Hundreds: {hundreds}");
        //    Console.WriteLine($"Tens: {tens}");
        //    Console.WriteLine($"Units: {units}");
        //}
        //else
        //{
        //    Console.WriteLine($"Number {userThreeDigitNumber} is not three digit!");
        //}

        // practice 3
        //int numA = 7;
        //int numB = 3;
        //Console.WriteLine($"Values: A = {numA} B = {numB}");
        //if (numA % 2 == 0 && numB % 2 == 0)
        //{
        //    numA /= 2;
        //    numB /= 2;
        //}
        //else if (numA % 2 != 0 && numB % 2 != 0)
        //{
        //    int halfSum = (numA + numB) / 2;
        //    numA = halfSum;
        //    numB = halfSum;
        //}
        //Console.WriteLine($"Result: A = {numA} B = {numB}");

        // practice 4
        //Console.WriteLine("Please, enter a film duration in minutes");
        //uint filmDuration = Convert.ToUInt16(Console.ReadLine());

        //if (filmDuration < 35)
        //{
        //    Console.WriteLine("Film located in the folder SHORT FILMS");
        //}
        //else if (filmDuration >= 35 &&  filmDuration < 60)
        //{
        //    Console.WriteLine("Film located in the folder TV FILMS");
        //}
        //else
        //{
        //    Console.WriteLine("Film located in the folder MOVIES");
        //}

        // practice 5
        //int[] arrA = new int[] { 66, 77, 88, 99, 10 };
        //int[] arrB = new int[] { 1, 2, 3, 4, 5 };
        //int[] arrC = new int[arrA.Length];
        //int arrCindex = 0;
        //int arrBsum = 0;
        //for (int i = 0; i < arrB.Length; i++)
        //{
        //    arrBsum += arrB[i];
        //}
        //double arrBavg = (double)arrBsum / arrB.Length;

        //for (int i = 0; i < arrA.Length; i++)
        //{
        //    if (arrA[i] > arrBavg)
        //    {
        //        arrC[arrCindex] = arrA[i];
        //        arrCindex++;
        //    }
        //}

        //if (arrCindex == 0)
        //{
        //    Console.WriteLine("Not elements, greater than avg B");
        //}
        //else
        //{
        //    for (int i = 0; i < arrCindex; i++)
        //    {
        //        Console.WriteLine(arrC[i]);
        //    }
        //}

        //Object w1 = 10;
        //Object w2 = "hi";
        //Object[] arr = new object[4];
        //arr[0] = 3;
        //arr[1] = 4.5f;
        //arr[2] = "hello";
        //arr[3] = new Cat("Misya");
        //for (uint i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        // homework 06.10.2026
        // 1
        uint num1 = ReadSingleDigit("Please, enter first digit: ");
        uint num2 = ReadSingleDigit("Please, enter second digit: ");
        uint num3 = ReadSingleDigit("Please, enter third digit: ");
        uint num4 = ReadSingleDigit("Please, enter fourth digit: ");
        Console.WriteLine($"Successfully entered: {num1}, {num2}, {num3}, {num4}");
        uint num1234 = (num1 * 1000) + (num2 * 100) + (num3 * 10) + num4;
        Console.WriteLine($"Number: {num1234}");

        // 2
        double value = makeNumber("Please, enter a value: ");
        double percent = makeNumber("Please, enter a percent: ");
        Console.WriteLine($"Successfully entered: VALUE => {value}, PERCENT => {percent}");
        double result = (value * percent) / 100.0;
        Console.WriteLine($"\n{percent}% of {value} = {result}");

        // homework 07.10.2026
        // 4
        Console.WriteLine("TASK 4");
        Random rand = new Random();

        const uint N = 10;
        uint[] arr1 = new uint[N];
        for (uint i = 0; i < N; i++)
        {
            arr1[i] = (uint)rand.Next(1, 5);
        }

        const uint M = 5;
        uint[] arr2 = new uint[M];
        for (uint i = 0; i < M; i++)
        {
            arr2[i] = (uint)rand.Next(1, 100);
        }

        uint[] arrTemp = new uint[N + M];
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            bool inArr2 = false;
            for (int j = 0; j < M; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    inArr2 = true;
                    break;
                }
            }
            bool alreadyInTemp = false;
            for (int k = 0; k < count; k++)
            {
                if (arrTemp[k] == arr1[i])
                {
                    alreadyInTemp = true;
                    break;
                }
            }
            if (inArr2 && !alreadyInTemp)
            {
                arrTemp[count] = arr1[i];
                count++;
            }
        }
        uint[] arrResult = new uint[count];
        Array.Copy(arrTemp, arrResult, count);
        Console.Write("RESULT: ");
        Console.WriteLine(string.Join(", ", arrResult));
        Console.WriteLine(" ");

        // 7
        Console.WriteLine("TASK 7");
        Console.Write("Please, enter a sentence: ");
        string sentence1 = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(sentence1))
        {
            Console.WriteLine("Empty sentence entered!");
            return;
        }

        string[] words = sentence1.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArr = words[i].ToCharArray();
            Array.Reverse(charArr);
            words[i] = new string(charArr);
        }
        string result7 = string.Join(" ", words);
        Console.WriteLine($"Result: {result}");
        Console.WriteLine(" ");

        // 8
        Console.WriteLine("TASK 8");
        Console.Write("Please, enter a sentence: ");
        string sentence2 = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(sentence2))
        {
            Console.WriteLine("Empty sentence entered!");
            return;
        }

        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        foreach (char c in sentence2)
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"Number of vowels in the sentence: {vowelCount}");
        Console.WriteLine(" ");


        // homework 06.10.2026
        // 1
        static uint ReadSingleDigit(string prompt)
        {
            ushort number;
            bool isValid;
            do
            {
                Console.Write(prompt);
                // означає, що input може бути null
                string? input = Console.ReadLine();

                // TryParse повертає true або false
                // out number означає, що якщо перетворення успішне, то отримане число записується як number
                isValid = ushort.TryParse(input, out number) && number <= 9;
                if (!isValid)
                {
                    Console.WriteLine("ERROR! Please, enter a number from 1 to 9!");
                }
            } while (!isValid);
            return number;
        }

        // 2
        static double makeNumber(string prompt)
        {
            double number;
            bool isValid;
            do
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                isValid = double.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("ERROR! Please enter a positive number!");
                }

            } while (!isValid);
            return number;
        }
    }
}
 