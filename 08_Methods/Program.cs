using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void  Metotlar    

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;

            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Paramereli Metotlar 

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Tolga");


            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: " + customerName +" "+customerSurname);
            //}

            //CustomerCard("Tolga", "Görü");
            //CustomerCard("Arda", "Güler");




            #endregion

            #region Geriye Değer Döndürmeyen İnt Paramereli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(5, 10, 15);

            #endregion

            #region  Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Tolga Görü";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Tolga";
            //    string surname = "Görü";

            //    return name + " " + surname;


            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region  Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent:  " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Girin: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region  Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 55));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return "Sınavı Geçti";
                }
                else
                {
                    return "Sınavı Geçemedi";
                }

            }

            Console.WriteLine(ExamResult("tolga", 85, 90, 50));
            
            #endregion


            Console.Read();
        }
    }
}
