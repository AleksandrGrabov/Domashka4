Console.WriteLine("Введите элементы массива через пробел (максимум 8 элементов):");
            string input = Console.ReadLine();
            
            int[] array = input.Split(' ').Take(8).Select(int.Parse).ToArray();

            Console.WriteLine("Введённый массив:");
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");