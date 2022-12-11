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

    Console.Write("[ ");
    for(int a = 0; a < array.Length; a++)
        {
            Console.Write( array[a] + " ");
        }
    Console.Write("]");

    Console.WriteLine();

}
