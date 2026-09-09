using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //for(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 76, 123, 63, 7093, 312, 2391, 32, 5, 2, 99, 100 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 76, 123, 63, 7093, 312, 2391, 32, 5, 2, 99, 100 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 76, 123, 63, 7093, 312, 2391, 32, 5, 2, 99, 100 };
            //int totalValue = 0;

            //foreach (int i in numbers)
            //{
            //    totalValue += i;
            //}
            //Console.Write(totalValue);

            //List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach(char letter in word)
            //{
            //    Console.Write(letter);
            //}


            #endregion

            #region Örnek Sınav Sistemi

            //Console.Write("*** C# Eğitim Kampı Sınav Uygulaması ***");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");

            ////Sınıftaki Öğrenci Sayısını Kullancıdan Alma
            //Console.Write("Sınıfınızda Kaç Öğrenci Var?: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------------");

            ////Öğrenci İsimlerini Ve Not Ortalamalarını Saklayacak Diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAverage = new double[studentCount];

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.Öğrencinin İsmini Giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    Console.WriteLine();

            //    double totalExamResult = 0;

            //    //Her Öğrenci İçin 3 Sınav Notu Girişi
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}.Sınav Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; // notları toplama
                   
            //    }
            //    Console.WriteLine();
            //    studentExamAverage[i] = totalExamResult / 3;
            //}

            ////Öprencilerin Sınav Ortamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} Adli Öğrencinin Ortalaması: {studentExamAverage[i]} ");
            

            //    //Öprencilerin Ortalaması Ve Geçip Kalma Durumları
            //    if (studentExamAverage[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçemedi.");
            //    }
            //    Console.WriteLine("----------------------------------");
            //}

           


            #endregion


            Console.Read();
        }
    }
}
