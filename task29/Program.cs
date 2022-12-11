//программа, которая задает массив из 8 элементов и выводит их на экран


{
int[] array = new int[8];
Console.WriteLine($"Введите элементы массива:");

    for (int i =0; i< array.Length; ++i)
        {
         Console.Write($"Введите элемент массива под индексом {i}:\t ");
        array[i] = int.Parse(Console.ReadLine());
        }

    Console.WriteLine("\nВывод массива:");

    for (int i =0; i< array.Length; ++i)
        {
        Console.Write(array[i]);
        Console.Write(", ");
    
        }

    Console.ReadLine();

}

