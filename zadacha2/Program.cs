// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] num = new int[size];       
    Random rnd = new Random();
    Console.WriteLine("Вот наш массив: ");
    int sum = 0;     
        
        {
           for(int i = 0; i < size; i++)
            {
                num[i] = rnd.Next(10000);
                int sign = (rnd.Next()%2) * 2 - 1;
                num[i] *= sign;
            }
           
           
            for (int i = 1; i < size; i+=2)
                sum = sum + num[i]; 

            
            for (int i = 0; i < size; i++)
            {
                Console.Write(num[i]+ " ");
                
            }
            
        }   
    Console.WriteLine($"\n всего {size} чисел, сумма элементов на нечётных позициях = {sum}");
           
}