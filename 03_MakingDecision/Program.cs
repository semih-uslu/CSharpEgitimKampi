using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler



            //double number;

            //number = 37.7;

            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");

            //Console.WriteLine();

            //Console.WriteLine();



            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;



            //applePrice = 20;

            //orangePrice = 10;

            //strawberryPrice = 15;

            //potatoPrice = 4;

            //tomatoPrice = 5;





            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "TL");

            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "TL");

            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");

            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice +  "TL");

            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice +  "TL");

            //Console.WriteLine() ;  

            //Console.WriteLine() ;  

            //Console.WriteLine() ;  



            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;



            //appleGram = 1.410; orangeGram = 2.845;

            //strawGram = 3.491; potatoGram = 8.120; tomatoGram = 0.875;





            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleGram * applePrice + " TL");

            //Console.WriteLine("Portakalın Toplam Fİyatı: " + orangeGram * orangePrice + " TL");

            //Console.WriteLine("Çilek Toplam Fiyatı: " + strawGram * strawberryPrice + " TL");

            //Console.WriteLine("Patates Toplam Fiyatı: " + potatoGram * potatoPrice + " TL");

            //Console.WriteLine("Domates Toplam Fiyatı: " + tomatoGram * tomatoPrice + " TL");



            #endregion



            #region Char Değişkenler



            //Tek Tırnak ile tanımlanıyor



            //char symbol;



            //symbol = 'A';



            //Console.WriteLine(symbol);







            #endregion



            #region Klavyeden Veri Girişleri



            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgileri *****");



            //string passangerIdentityNumber, passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge   ;



            //Console.WriteLine("TC: ");

            //passangerIdentityNumber = Console.ReadLine();



            //Console.WriteLine("Yolcu Adı: ");

            //passengerName = Console.ReadLine();



            //Console.WriteLine("Yolcu Soyadı: ");

            //passengerSurname = Console.ReadLine();



            //Console.WriteLine("İlçe Bİlgisi: ");

            //passengerDistrict = Console.ReadLine();



            //Console.WriteLine("İl Bilgisi: ");

            //passengerCity = Console.ReadLine();



            //Console.WriteLine("Yaş Bilgisi: ");

            //passengerAge = Console.ReadLine();





            //Console.WriteLine("-----------------");

            //Console.WriteLine("Yolcu TC Kimlik Bilgisi:  " + passangerIdentityNumber + "- Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);



            #endregion



            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;

            //computerPrice = 2000;

            //chairPrice = 600;

            //tvPrice = 10022;



            //int shoesCount, computerCount, chairCount, tvCount;



            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.Write("Toplam Tutar: "+totalPrice);


            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3,result;

            //Console.Write("1. sınav notu: ");
            //exam1= int.Parse(Console.ReadLine());

            //Console.Write("2. sınav notları: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. sıanv notları: ");
            //exam3 = int.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.Write("sınav ortalaması: "+ result);

            #endregion


            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("cinsiyet seçin: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
