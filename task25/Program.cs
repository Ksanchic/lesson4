// цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную 
//степень В(без использования Math.Pow)


Console.WriteLine ("Введите число А");
Console.WriteLine("Введите степень n:");
{
int A = int.Parse (Console.ReadLine());
int n = int.Parse(Console.ReadLine());
 int s=1;

if (n <1)
 {
    Console.WriteLine("некорректное число");
 } 
else
{
  for (int i=0; i<n; i++)
       s*=A;
       Console.WriteLine("{0} ^ {1} = {2}", A, n, s);
       Console.ReadKey();
}
}