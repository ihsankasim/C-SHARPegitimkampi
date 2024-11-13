using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double değişkenler

            //double teaprice = 90.80;
            //double milkprice = 30.50;
            //double cocoaprice = 26.30;
            //double sugarprice = 70.75;

            //Console.WriteLine("     ***** Fiyat Listesi *****     ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Çayın birim fıyatı: " + teaprice);
            //Console.WriteLine("Sütün birim fıyatı: " + milkprice);
            //Console.WriteLine("Kakaonun birim fıyatı: " + cocoaprice);
            //Console.WriteLine("Şekerin birim fıyatı: " + sugarprice);
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //double teagram = 1.300;
            //double milklt = 2.500;
            //double cocoagram = 130;
            //double sugargram = 3.500;

            //double teatotalprice = teaprice * teagram;
            //double milktotalprice = milkprice * milklt;
            //double cocoatotalprice = cocoaprice * cocoagram;
            //double sugartotalprice = sugarprice * sugargram;

            //Console.WriteLine("Çayın toplam fiyatı: " + teatotalprice);
            //Console.WriteLine("Sütün toplam fiyatı: " + milktotalprice);
            //Console.WriteLine("Kakaonun toplam fiyatı: " + cocoatotalprice);
            //Console.WriteLine("Şekerin toplam fiyatı: " + sugartotalprice);
            //Console.WriteLine();

            //double totalprice = teatotalprice + milktotalprice + cocoatotalprice + sugartotalprice;

            //Console.WriteLine("Toplam ödenecek tutar: " + totalprice);

            #endregion

            #region char değişkenleri

            //char symbol= 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region klavyeden string değişken girişleri

            //Console.WriteLine("     ***** Symphony Hava Yolları yolcu bilgisi *****     ");
            //Console.WriteLine();

            //string passengerIdentitynumber,passengername, passengersurname, passengerage, passengerdistrict, passengercity;

            //Console.Write("Yolcu tc kimlik no: ");
            //passengerIdentitynumber = Console.ReadLine();

            //Console.Write("Yolcu adı: ");
            //passengername = Console.ReadLine();

            //Console.Write("Yolcu  soyadı: ");
            //passengersurname = Console.ReadLine();

            //Console.Write("Yolcunun yaşı: ");
            //passengerage = Console.ReadLine();

            //Console.Write("Yolcunun ilçe bilgisi: ");
            //passengerdistrict = Console.ReadLine();

            //Console.Write("Yolcunun şehir bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcunun TC kimlik numarası: " + passengerIdentitynumber);
            //Console.WriteLine("Yolcunun adı: " + passengername + " " + passengersurname);
            //Console.WriteLine("Yolcunun yaşı: " + passengerage);
            //Console.WriteLine("yolcunun adres bilgileri: " + passengerdistrict + "/" + passengercity);
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümleri

            //int glassprice, pipetteprice, knifeprice, glueprice;
            //glassprice = 20;
            //pipetteprice = 10;
            //knifeprice = 100;
            //glueprice = 30;

            //int glasscount, pipettecount, knifecount, gluecount;

            //Console.Write("Alınan bardak sayısını giriniz: ");
            //glasscount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan pipet sayısını giriniz: ");
            //pipettecount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan bıçak sayısını giriniz: ");
            //knifecount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan yapıştırıcı sayısını giriniz: ");
            //gluecount = int.Parse(Console.ReadLine());

            //int totalprice = glasscount * glassprice + pipettecount * pipetteprice + knifecount * knifeprice + glueprice * gluecount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalprice);

            #endregion

            #region klavyeden ondalıklı sayı girişleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("ortalaması : " + result);

            #endregion

            #region klavyeden karakter girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyetinizi giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();

        }
    }
}
