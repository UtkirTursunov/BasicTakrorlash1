namespace BasicTakrorlash1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-vazifa. 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing.
            //While loop dan foydalaning!
            /*
            int i = 1;
            int summa = 0;
            while (i < 1000)
            {
                summa += i;
                i += 2;
            }
            Console.WriteLine(summa.ToString("N0"));
            */

            //2-vazifa. Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan
            //dastur tuzing. For loop dan foydalaning!
            /*
            Console.Write("Massiv o‘lchamini kiriting: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Massiv elementlarini kiriting:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }
            int result = max * min;

            Console.WriteLine($"Eng katta qiymat: {max}");
            Console.WriteLine($"Eng kichik qiymat: {min}");
            Console.WriteLine($"Ularning ko‘paytmasi: {result}");
            */

            //3.Consolga int tipidagi butun son kiritilgan => int x x!(x factorial) ni hisoblaydigan dastur tuzing.
            
            Console.Write("Sonni kiriting (n): ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; 
            }
            Console.WriteLine($"{n}! = {factorial}");
        }
    }
}
