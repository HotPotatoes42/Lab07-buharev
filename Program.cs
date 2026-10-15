using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
// // 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine($"{i + 1}: {days[i]}");
// }

// // 1.2
// double[] temps = { 0, -1, -2, 3, 4, 5, 6 };
// foreach (int temp in temps)
// {
//     Console.Write(temp);
//     Console.Write(" ");
// }

// // 2
// int sum = 0;
// int sred = 0;
// int count = 0;
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// for (int i = 0; i < prices.Length; i++)
// {
//     sum += prices[i];
//     if (prices[i] > 100)
//     {
//         count += 1;
//     }
// }
// sred = sum / prices.Length;
// Console.WriteLine(sum);
// Console.WriteLine(sred);
// Console.WriteLine(count);

// // 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int max = prices[0];
// int min = prices[0];
// int indexmax = 0;
// int indexmin = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] > max)
//     {
//         max = prices[i];
//         indexmax = i;
//     }
//     else if (prices[i] < min)
//     {
//         min = prices[i];
//         indexmin = i;
//     }
// }
// Console.WriteLine($"Максимальное значение {max} Индекс {indexmax}");
// Console.WriteLine($"Максимальное значение {min} Индекс {indexmin}");
// // 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int j in balance)
// {
//     Console.Write(j);
//     Console.Write(" ");
// }
// 5
int[] s = (new int[5]);
for (int i = 0; i < 5; i++)
{
    s[i] = System.Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Наоборот");
for (int j = s.Length; j > -1 * s.Length; j--)
{
    Console.WriteLine(s[j]);
}