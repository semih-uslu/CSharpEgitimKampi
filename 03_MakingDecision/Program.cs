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
            #region If else

            //Console.Write( "Şifreyi giriniz: " );
            //string password;
            //password = Console.ReadLine();

            //if ( password == "1234" ) 
            //{
            //    Console.WriteLine("Şifre Doğru");   
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //Console.WriteLine("Başkentin adı: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();   

            //Console.WriteLine(capital + " "+ country);


            //if (capital=="ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("bilgiler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("bilgiler yanlış");
            //}


            //int number;

            //Console.WriteLine("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 37)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı!!");
            //}


            //int  exam1, exam2, exam3, avarage;
            //string result =  "hata!";


            //Console.WriteLine("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //avarage = (exam1+ exam2+ exam3)/3;

            //Console.WriteLine("sınavların ortalaması: " + avarage);


            //if (avarage>0 & avarage<=50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (avarage>50 & avarage <=70)
            //{
            //    result = "sonuç orta";
            //}
            //if (avarage>70 & avarage<=84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (avarage>84 )
            //{
            //    result = "sonuç çok iyi";

            //}

            //Console.WriteLine(result); 




            //string city;
            //Console.WriteLine("şehir ismi giriş yapın: ");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{

            //    Console.WriteLine("şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}



            //Console.Write("kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez!!");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz!!");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 37;

            //int result = number % 5;
            //Console .WriteLine(result);


            //Console.WriteLine("1. sayı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayı/ 2. sayidan kalan: " + result);



            //Console.WriteLine("sayi girniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 ==0) { Console.WriteLine("sayi çift sayidir!!"); }
            //else
            //{
            //    Console.WriteLine("sayi tek sayidir!!");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.WriteLine("takım sembolünü giriniz");
            //team = char.Parse(Console.ReadLine());

            //if (team== 'k' | team== 'K')
            //{
            //    Console.WriteLine("Kastamonu Spor");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");

            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("C# eğitim kampı restoran");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("1-ana yemekler");
            //Console.WriteLine("2-çorbalar");
            //Console.WriteLine("3-pizzalar");
            //Console.WriteLine("4-içecekler");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("-----------------------");


            //string menuItem;


            //Console.WriteLine("Detayını görmek istediğiniz menü seçim: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---- ana yemekler ----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-köri soslu tavuk");
            //    Console.WriteLine("2-kızartma tabağı");
            //    Console.WriteLine("3-fasulye pilav");
            //    Console.WriteLine("4-fırında makarna");
            //    Console.WriteLine("5-banduma");
            //    Console.WriteLine("");
            //    Console.WriteLine("---- ana yemekler ----");
            //}

            //if (menuItem =="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---- çorbalar ----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-işkembe");
            //    Console.WriteLine("2-mercimek");
            //    Console.WriteLine("3-kızılcık tarhanası");
            //    Console.WriteLine("4-ecevit çorbası");
            //    Console.WriteLine("");
            //    Console.WriteLine("---- çorbalar ----");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---- pizzalar  ----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-sucuklu");
            //    Console.WriteLine("2-margarita");
            //    Console.WriteLine("3-peynir bol");
            //    Console.WriteLine("4-karışık");
            //    Console.WriteLine("5-mantarlı");
            //    Console.WriteLine("");
            //    Console.WriteLine("---- pizzalar ----");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---- içecekler ----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-ayran");
            //    Console.WriteLine("3-gazoz");
            //    Console.WriteLine("4-şalgam");
            //    Console.WriteLine("");
            //    Console.WriteLine("---- içecekler ----");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---- tatlılar ----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kemalpaşa");
            //    Console.WriteLine("2-ekler");
            //    Console.WriteLine("3-sütlaç");
            //    Console.WriteLine("4-triliçe");
            //    Console.WriteLine("");
            //    Console.WriteLine("---- tatlılar ----");
            //}




            #endregion

            #region Switch Case

            //Console.WriteLine("ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default: Console.WriteLine("hatalı veri girişi"); break;

            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.sayi: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayi: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplam : " + result);
            //        break;

            //    case '-':
            //        result = (number1 - number2);
            //        Console.WriteLine("toplam : " + result);

            //        break;

            //        case '*':
            //        result = (number1 * number2);
            //        Console.WriteLine("toplam : " + result);

            //        break;

            //    default: Console.WriteLine("hatalı veri girildi!!"); break;
            //}


            #endregion

            Console.Read();
        }
    }
}
