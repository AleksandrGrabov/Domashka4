Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень B:");
            int B = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < B; i++)
            {
                result *= A;
            }

            Console.WriteLine($"Число A в степени B равно: {result}");