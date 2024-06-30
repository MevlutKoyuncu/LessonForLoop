using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Nedir Nasıl Kullanılır

            //For aynı While gibi bir döngüdür. Ancak kullanımı daha derli topludur. 
            //Başlangıç koşul ve iterasyon üçlüsünü yönetmek daha kolaydır.







            #endregion

            #region While'a tekrardan bakalım

            //int sayac = 0;

            //while (sayac <= 100)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}

            #endregion

            #region For Kullanımı BAŞLANGIÇ, KOŞUL VE İTERASYON

            //for (int sayac = 0; sayac <= 10; sayac++)
            //{
            //    Console.WriteLine(sayac);
            //}

            #endregion

            #region Adınızı 10 kere yazdırınız.


            //for (int sayac = 0; sayac <= 10; sayac++)
            //{
            //    string isim = "Mevlut";
            //    Console.WriteLine(isim);
            //}


            #endregion

            #region Çarpım Tablosunun 3ler basamağını yazdırınız.


            //for (int carpan = 0; carpan <=10; carpan++)
            //{

            //    Console.WriteLine("3 X " + carpan + " = " + (carpan *3));

            //}

            #endregion

            #region Çarpım Tablosunun Kullanıcıdan alınan basamağını yazdırınız.

            //Console.Write("Basamak değerini giriniz = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int carpan = 1; carpan <= 10; carpan++)
            //{
            //    Console.WriteLine(sayi + " x " + carpan + " = " + (carpan * sayi));

            //}

            #endregion

            #region  TÜM ÇARPIM TABLOSUNU YAZDIRINIZ.

            //for (int basamak = 1; basamak <= 10; basamak++)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine(basamak + "lar/ler basamağı");
            //    for (int carpan = 1; carpan <= 10; carpan++)
            //    {
            //        Console.WriteLine(basamak + " x " + carpan + " = " + (basamak * carpan));
            //    }
            //}

            #endregion

            #region Konsoldan alınan sayı asal mı?

            //Console.WriteLine("Sayı giriniz = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool asalmi = true;
            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine("Sayı asal değildir");
            //        //i = sayi;
            //        asalmi = false;
            //        break;

            //    }
            //}
            //if (asalmi == true)
            //{
            //    Console.WriteLine("Sayı asaldır");
            //}

            #endregion

            #region ÖDEV 1 -Konsoldan alınan 2 sayı arasında tüm asalları yazdırınız.

            Console.WriteLine("1. Sayıyı giriniz = ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz = ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

           

            for (int i = 2; i < sayi2; i++)
            {

                if (sayi++ % i == 0 && sayi < sayi2)
                {
                    
                    Console.WriteLine("");
                }

            }
            
                

            #endregion

            #region ÖDEV 2 -Konsoldan alınan 2 sayı arasındaki ikiz asalları yazdırınız. (İkiz Asal = 2 Sayı arasında 1 tane asal olmayan sayı olacak.)

            #endregion

            #region a - z küçük karakterleri yazınız.

            //for (int i = 97; i <= 122; i++)
            //{
            //    char karakter = (char)i;
            //    Console.WriteLine(karakter);

            //}



            #endregion

        }
    }
}
