// using System.Linq;

// // // soal 1
// // int[] input1 = {1,2,3,4,5,6};
// // var ambilTeratas = input1.OrderByDescending(x => x).Take(3).ToArray();
// // // ambilTeratas.ToList().ForEach(x => Console.WriteLine(x));
// // Console.WriteLine(ambilTeratas.Sum());


// // // soal 2
// // int[] input2 = {2,4,6,5,3,1,7,9,10,8};
// // var orderInput2 = input2.OrderBy(x => x).ToArray();
// // int[] angkaGenap = orderInput2.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
// // // angkaGenap.ToList().ForEach(x => Console.WriteLine(x));

// // for (int i = angkaGenap.Length - 1; i >= 0; i--)
// // {
// //     // Console.WriteLine(i);
// //     for (int j = 0; j <= i; j++)
// //     {
// //         Console.Write(angkaGenap[j]);

// //         if (j <= i - 1)
// //         {
// //             Console.Write(",");
// //         }
// //     }

// //     Console.WriteLine();
// // }

// // soal 3
// int input = 5;
// // belum selesai
// List<int> daftarPrima = new List<int>();
// int angkaPertama = 2;

// // Console.WriteLine(daftarPrima.Count);

// while (daftarPrima.Count < input)
// {
//     // Console.WriteLine($"Memeriksa angka: {angkaPertama}");
//     if (IsPrime(angkaPertama))
//     {
//         daftarPrima.Add(angkaPertama);
//     }
//     angkaPertama++;
// }

// Console.WriteLine(string.Join(", ", daftarPrima));

// static bool IsPrime(int n)
// {
//     if (n <= 1) return false;
//     if (n == 2) return true;
//     if (n % 2 == 0) return false;

//     for (int i = 3; i <= Math.Sqrt(n); i += 2)
//     {
//         if (n % i == 0) return false;
//     }

//     return true;
// }

