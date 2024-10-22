using System;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "yeşil";
            //colors[2] = "mavi";
            //colors[3] = "siyah";

            //Console.WriteLine(colors[5]);

            //string[] cities = new string[5];

            //cities[0] = "istanbul";
            //cities[1] = "madrid";
            //cities[2] = "dortmund";
            //cities[3] = "roma";

            //Console.WriteLine(cities[3]);


            //int[] numbers = new int[10];
            //numbers[0] = 37;
            //numbers[1] = 24;
            //numbers[2] = 15;
            //numbers[3] = 18;
            //numbers[6] = 64;

            //Console.WriteLine(numbers[3]);


            #endregion

            #region Dizideki Tüm elemanları Listeleme

            //string[] colors = { "sarı", "beyaz", "mavi", "yeşil", "siyah", "turuncu" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 45, 645, 684, 814, 11158, 664, 2 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}


            //char[] symbols = { 'a', 'b', 'c', '/', '*' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 1, 2, 45, 56, 81, 75, 337, 100, 511 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];

            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "veli", "ahmet ", "ayşe" };
            //Console.WriteLine(persons.Length);  


            //int[] numbers = { 1, 2, 37, 4, 5, 6 }; 
            ////küçükten büyüğe doğru sıraladı
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 1, 2, 37, 4, 5, 6 };
            ////diziyi tersten sıralıyor
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlar

            //string[] customers = {"ali","ayşe","veli","özge" };
            //int index = Array.IndexOf(customers, "özge");
            //Console.WriteLine(index);


            //int[] numbers = { 1, 2, 84, 502, 47, 479, 412, 24 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() + " dizinin en küçük elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 1, 2, 4, 65, 874 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine("çift sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2 == 0) { Console.WriteLine(numbers[i]); }
            //}

            //Console.WriteLine("tek sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) { Console.WriteLine(numbers[i]); }
            //}



            #endregion

            Console.Read();

        }
    }
}
