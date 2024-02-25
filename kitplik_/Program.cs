using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kitplik_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            string secim;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("               *****************************************************************************************");
            Console.WriteLine("               *****      Türkçe Eserler Kategorisi          *****     Yabancı Eserler Kategorisi  *****");
            Console.WriteLine();
            Console.WriteLine("                1 - İçimizdeki Şeytan : Sabahattin Ali                  7 - Budala : Dostoyevski        "); 
            Console.WriteLine("                2 - Serenad : Zülfü Livaneli                            8 - 1984 : George Orwel         "); 
            Console.WriteLine("                3 - Dokuzuncu Hariciye Koğuşu : Peyami Safa             9 - Devlet : Platon             "); 
            Console.WriteLine("                4 - Çalıkuşu : Reşat Nuri Gültekin                     10 - Ütopya : Thomas More        "); 
            Console.WriteLine("                5 - Sergüzeşt : Sami Paşazade Sezai                    11 - Öteki : Dostoyevski         "); 
            Console.WriteLine("                6 - Aşkname : İskender Pala                            12 - Martı : Jonathan Liwingston ");
            Console.WriteLine();
            Console.WriteLine("               *****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("                                           ****  İŞLEMLER MENÜSÜ  ****                                  ");
            Console.WriteLine();
            Console.WriteLine("              1 - Fiyat Sorgulama ");
            Console.WriteLine("              2 - Yeni Kayıt");
            Console.WriteLine("              3 - Günün Kitabı");
            Console.WriteLine("              4 - Kitap Arşivi");
            Console.WriteLine("              5 - Kitap Satın Al");
            Console.WriteLine("              6 - Oyun");
            Console.WriteLine();
            Console.Write("              Yapmak İstediğiniz İşlemin Numarası : ");
            Char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if(islem == '1')
            {
                Console.WriteLine();
                Console.Write("LÜTFEN İŞLEM YAPMAK İSTEDİĞİNİZ KİTAP NUMARASINI GİRİNİZ :");
                string n;
                n = Console.ReadLine();
                switch (n)
                {
                    case "1": Console.WriteLine("içimizdeki şeytan : 160 tl"); break;
                    case "2": Console.WriteLine("serenad : 250 tl"); break;
                    case "3": Console.WriteLine("dokuzuncu hariciye koğuşu : 60 tl"); break;
                    case "4": Console.WriteLine("çalıkuşu : 240 tl"); break;
                    case "5": Console.WriteLine("sergüzeşt : 50 tl"); break;
                    case "6": Console.WriteLine("aşkname : 70 tl"); break;
                    case "7": Console.WriteLine("budala  : 200 tl"); break;
                    case "8": Console.WriteLine("1984 : 190 tl"); break;
                    case "9": Console.WriteLine("devlet : 230 tl"); break;
                    case "10": Console.WriteLine("ütopya : 150 tl"); break;
                    case "11": Console.WriteLine("öteki : 120 tl"); break;
                    case "12": Console.WriteLine("martı : 50 tl"); break;
                    default: Console.WriteLine("böyle bir kitap mevcut değil lütfen girilrn degeri kontrol ediniz");break;
                }

                }
            if (islem == '2')
            {
                string a, s, u;
                Console.Write("ADINIZ :");
                a = Console.ReadLine();
                Console.Write("SOYADINIZ :");
                s = Console.ReadLine();
                Console.Write("UNİVERSİTENİZ :");
                u = Console.ReadLine();
                string dosya = @"C:\Users\Rüveyde\Desktop\deneme5.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("ADINIZ :" + a);
                sw.WriteLine("SOYADINIZ :" + s);
                sw.WriteLine("UNİVERSİTENİZ :" + u);
                sw.Close();

            }
            if (islem == '3')
            {
                Console.WriteLine();
                string[] ktp = { "içimizdeki şeytan", "serenad", "dokuzuncu hariciye kogusu", "calıkusu", "serguzest", "askname", "budala", "1984", "devlet", "utopya", "otekı", "martı" };
                int gnk;
                Random r = new Random();
                gnk = r.Next(0, ktp.Length);
                Console.Write("GÜNÜN KİTABI :");
                Console.Write(ktp[gnk]);
            }
            if (islem == '4')
            {
                FileStream fs = new FileStream(@"C:\Users\Rüveyde\Desktop\kitap arsivi.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string m = sr.ReadLine();
                while(m != null)
                {
                    Console.WriteLine(m);
                    m = sr.ReadLine();
                }
                fs.Close();
                sr.Close();
            }
            if (islem == '5')
            {
               
                
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write("alacagınız kitabın numarası :");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplam = toplam + 160;

                    }
                    else if (secim == "2")
                    {
                        toplam = toplam + 250;

                    }
                    else if (secim == "3")
                    {
                        toplam = toplam + 60;

                    }
                    else if (secim == "4")
                    {
                        toplam = toplam + 240;

                    }
                    else if (secim == "5")
                    {
                        toplam = toplam + 50;

                    }
                    else if (secim == "6")
                    {
                        toplam = toplam + 70;

                    }
                    else if (secim == "7")
                    {
                        toplam = toplam + 200;

                    }
                    else if (secim == "8")
                    {
                        toplam = toplam + 190;

                    }
                    else if (secim == "9")
                    {
                        toplam = toplam + 230;

                    }
                    else if (secim == "10")
                    {
                        toplam = toplam + 150;

                    }
                    else if (secim == "11")
                    {
                        toplam = toplam + 120;

                    }
                    else if (secim == "12")
                    {
                        toplam = toplam + 50;

                    }
                    else
                    
                        Console.WriteLine();
                        Console.Write("baska bir kitap almak istermisisniz :");
                        string c = Console.ReadLine();
                        if (c == "hayır" || c == "Hayır") break;
                    
                    

                      
                    
                    

                }
                Console.WriteLine("toplam tutar : " + toplam);


            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random ra = new Random();
                int sayi = ra.Next(1, 100);
                while (tahmin != sayi )
                {
                    Console.Write("sayi giriniz :");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin < sayi)
                    {
                        Console.Write("daha büyük");
                    }
                    if (tahmin > sayi)
                    {
                        Console.Write("daha küçük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("bildiniz");
                        break;
                    }
                }
            }


            Console.Read();
            
            
        }
    }
}