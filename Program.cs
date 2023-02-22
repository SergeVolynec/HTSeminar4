//Задача1
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// for (int i=1;i<=b;i++)
// {
//     result = result*a; 
// }
// Console.WriteLine($"Число {a} в степени {b} равняется {result}");

//Задача2
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (a > 0)
// {
//     sum+=a%10;
//     a = a/10;
// }
// Console.WriteLine(sum);

//

//Задача3
int [] arr = new int [8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i+1}-ый элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(String.Join(';', arr));