//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

{

            int size = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[] mas = new int[size];
            
            for(int i = 0; i < size; i++)
            {
                mas[i] = rnd.Next(100, 999);
            }

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                int a = mas[i] % 2;
                if(a == 0)
                {
                    count++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i]+ " ");
            }
            Console.WriteLine(count);

            Console.ReadKey(true);
}
    