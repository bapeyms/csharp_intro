using System.Globalization;

namespace intro;

internal class Program
{
    static void Main(string[] args)
    {
        // усі типи існуючі та ті, що будемо створюватися самостійно є структурами
        // все створене нижче є локольно створені в стеку
        // цілі числа
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
        ulong n1 = 1;
        ulong n2 = 7;

        ulong sum = 0;
        sum = n1 + n2;
       
        ulong diff = 0;
        if (n1 >= n2)
        {
            diff = n1- n2;
        }
        else
        {
            Console.WriteLine("ERROR! n1 must be greater or equal to n2");
        }

        ulong mul = 0;
        mul = n1 * n2;

        ulong fract = 0;
        if (n2 != 0)
        {
            fract = n1 / n2;
        }
        else
        {
            Console.WriteLine("ERROR! Division by zero");
        }

        ulong rem = 0;
        if (n2 != 0)
        {
            rem = 1 % 7;
        }
        else
        {
            Console.WriteLine("ERROR! Division by zero");
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Diff: {diff}");
        Console.WriteLine($"Mul: {mul}");
        Console.WriteLine($"Fract: {fract}");
        Console.WriteLine($"Rem: {rem}");

        // practice 2
        Console.WriteLine("Please, enter a three-digit number");
        int userThreeDigitNumber = Convert.ToUInt16(Console.ReadLine());
        if (userThreeDigitNumber >= 100 && userThreeDigitNumber <= 999)
        {
            int hundreds = userThreeDigitNumber / 100;
            int tens = (userThreeDigitNumber / 10) % 10;
            int units = userThreeDigitNumber % 10;

            Console.WriteLine($"Hundreds: {hundreds}");
            Console.WriteLine($"Tens: {tens}");
            Console.WriteLine($"Units: {units}");
        }
        else
        {
            Console.WriteLine($"Number {userThreeDigitNumber} is not three digit!");
        }
    }
}