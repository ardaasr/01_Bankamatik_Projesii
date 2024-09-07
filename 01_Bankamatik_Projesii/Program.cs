using System.Drawing;

namespace _01_Bankamatik_Projesii
{
    class Program
    {
        #region BANKAMATİK 
        /*
            *   2500 tl parası olacak 
           Bir bankamatik düşünülerek tasarlanacak bir program  için 
           Kartlı işlem    1
           Kartsız işlem   2
           //********Kartlı işlem bölümü
           Şifre istenecek=> Şifre:ab18
           ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
           //*******************Ana Menü 
           Para Çekmek için    1
           Para yatırmak için  2
           Para Transferleri   3
           Eğitim Ödemeleri    4
           Ödemeler            5
           Bilgi Güncelleme    6
           //*********************Seçim 1************
           Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
           Ana menüye dönmek için   9
           Çıkmak için             0
           //******************Seçim 2***********************
           Kredi Kartına   1
           Kendi Hesabınıza yatırmak için  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
           Kredi kardı için en az 12 haneli kart numarasını girsin
           bakiye yeterli ise hesaptan kredi kartına para yatırılaca
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------------
           //***************Seçim 6
           Şifre değiştirmek için 1
           Şifre değiştirme işlemi gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0


          //********Kartsız işlem bölümü

          //*******************Ana Menü 
          CepBank Para Çekmek 1
           Para yatırmak için  2
           Kredi Kartı Ödeme   3
           Eğitim Ödemeleri    4
           Ödemeler            5

           //*********************Seçim 1************
           TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
           Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
Ana menüye dönmek için   9
           Çıkmak için              0
           //******************Seçim 2***********************
           Nakit ödeme     1
           Hesaptan ödeme  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
        Kredi kartı için en az 12 haneli kart numarasını girsin

        Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
           Nakit olarak ödeme gerçekleştirin.
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           Kredi kartı için en az 12 haneli kart numarasını girsin
Hesap numarasını girsin

           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           */


        static double bakiye = 2500; // static olarak işaretlenmiş bir üye sınıfın tüm örneklerinde ortak bir özellik veya işlev olarak kullanılır.
        static string sifre = "ab18";

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\nQ-Çıkış\nSeçiminiz:");
                string kartli = Console.ReadLine().ToUpper();

                if (kartli == "1")
                {
                    KartliIslem();
                }
                else if (kartli == "2")
                {
                    KartsizIslem();
                }
                else if (kartli == "Q")
                {
                    Console.WriteLine("Sistem Kapatılıyor.");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!!");
                }
            }
        }

        static void KartliIslem()
        {
            int hak = 3;
            bool giris = false;
            while (hak > 0)
            {
                Console.Clear();
                Console.Write("Şifreniz: ");
                string sfr = Console.ReadLine();
                hak--;
                if (sfr == sifre)
                {
                    giris = true;
                    break;
                }
                else if (hak == 0)
                {
                    Console.WriteLine("3 defa yanlış giriş yapıldı. Sistem 5 saniye kitlendi.");
                    Thread.Sleep(5000);
                    hak = 3;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Şifreniz Hatalı. Tekrar Deneyiniz.");
                }
            }

            if (giris)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("****** ANA MENÜ *******");
                    Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Transfer\n4-Eğitim Ödemeleri\n5-Ödemeler\n6-Bilgi Güncelleme\n0-Çıkış\nSeçiminiz:");
                    string anaMenu = Console.ReadLine();

                    if (anaMenu == "1")
                    {
                        ParaCekme();
                    }
                    else if (anaMenu == "2")
                    {
                        ParaYatirma();
                    }
                    else if (anaMenu == "3")
                    {
                        Transfer();
                    }
                    else if (anaMenu == "4")
                    {
                        Console.WriteLine("Eğitim Ödemeleri Bölümü ARIZALI!!!");
                    }
                    else if (anaMenu == "5")
                    {
                        Odeme();
                    }
                    else if (anaMenu == "6")
                    {
                        SifreGuncelleme();
                    }
                    else if (anaMenu == "0")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ana Menü Seçimi!!");
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        static void ParaCekme()
        {
            Console.Write("Çekilmek istenilen miktar: ");
            int miktar = Convert.ToInt32(Console.ReadLine());
            if (miktar <= bakiye)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} lira çekildi. Yeni bakiyeniz: {bakiye}");
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye");
            }
            AnaMenuDon();
        }

        static void ParaYatirma()
        {
            Console.WriteLine("1-Kredi Kartı\n2-Hesaba\nSeçiminiz:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Kredi kart numarası (en az 12 haneli): ");
                string kartNo = Console.ReadLine();

                if (kartNo.Length >= 12 && long.TryParse(kartNo, out _))
                {
                    Console.Write("Yatırılacak Miktar Girişi: ");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} lira kredi kartına yatırıldı. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                else
                {
                    Console.WriteLine("Kart numarası hatalı!!");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Yatırılacak Miktar Girişi: ");
                bakiye += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz: " + bakiye);
            }
            else
            {
                Console.WriteLine("Hatalı Para Yatırma Seçimi!!");
            }
            AnaMenuDon();
        }

        static void Transfer()
        {
            Console.WriteLine("1-EFT\n2-Havale\nSeçiminiz:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("IBAN bilgisini başında TR olacak şekilde giriniz: ");
                string Iban = Console.ReadLine().ToUpper();
                if (Iban.StartsWith("TR") && Iban.Length == 14 && long.TryParse(Iban.Substring(2), out _))
                {
                    Console.Write("EFT Miktar Girişi: ");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} lira EFT edildi. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                else
                {
                    Console.WriteLine("IBAN bilgisi hatalı!!");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Hesap numarası (en az 12 haneli): ");
                string hesapNo = Console.ReadLine();

                if (hesapNo.Length == 12 && long.TryParse(hesapNo, out _))
                {
                    Console.Write("Havale Miktar Girişi: ");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} lira havale edildi. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                else
                {
                    Console.WriteLine("Hesap numarası hatalı!!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Havale Seçimi!!");
            }
            AnaMenuDon();
        }

        static void Odeme()
        {
            Console.WriteLine("1-Elektrik\n2-Telefon\n3-İnternet\n4-Su\n5-OGS\nSeçiminiz:");
            string fatura = Console.ReadLine();

            if (fatura == "1" || fatura == "2" || fatura == "3" || fatura == "4" || fatura == "5")
            {
                Console.Write("Fatura bedeli: ");
                double miktar = Convert.ToDouble(Console.ReadLine());

                if (bakiye >= miktar)
                {
                    bakiye -= miktar;
                    Console.WriteLine($"{miktar} lira fatura ödendi. Yeni bakiyeniz: {bakiye}");
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz Fatura Türü!");
            }
            AnaMenuDon();
        }

        static void SifreGuncelleme()
        {
            Console.Write("Yeni şifre: ");
            string yeniSifre = Console.ReadLine();
            sifre = yeniSifre;
            Console.WriteLine("Şifre başarıyla güncellendi.");
            AnaMenuDon();
        }

        static void AnaMenuDon()
        {
            Console.WriteLine("Ana menü-9\nÇıkış-0\nSeçiminiz:");
            string exit = Console.ReadLine();
            if (exit == "0")
            {
                Environment.Exit(0);
            }
            else if (exit == "9")
            {
                return;
            }
        }

        static void KartsizIslem()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("****** KARTSIZ ANA MENÜ *******");
                Console.WriteLine("1-CepBank Para Çekmek\n2-Para Yatırmak\n3-Kredi Kartı Ödeme\n4-Eğitim Ödemeleri\n5-Ödemeler\n0-Çıkış\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    CepBankParaCekme();
                }
                else if (secim == "2")
                {
                    KartsizParaYatirma();
                }
                else if (secim == "3")
                {
                    KrediKartiOdeme();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Eğitim Ödemeleri Bölümü ARIZALI!!!");
                }
                else if (secim == "5")
                {
                    KartsizOdemeler();
                }
                else if (secim == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!!");
                    Thread.Sleep(1000);
                }
            }
        }

        static void CepBankParaCekme()
        {
            const string tcKimlikNo = "12345678901"; 
            const string cepTelefonu = "5324554994"; 
            int deneme = 3;

            while (deneme > 0)
            {
                Console.Write("TC Kimlik No: ");
                string girilenTC = Console.ReadLine();
                Console.Write("Cep Telefonu No: ");
                string girilenCep = Console.ReadLine();

                if (girilenTC == tcKimlikNo && girilenCep == cepTelefonu)
                {
                    Console.WriteLine("1000 TL ödeme yapılmıştır.");
                    return;
                }
                else
                {
                    deneme--;
                    if (deneme == 0)
                    {
                        Console.WriteLine("Hakkınız bitti. Sistem 5 saniye kilitlenecek.");
                        Thread.Sleep(5000);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Bilgiler hatalı. Kalan deneme hakkı: " + deneme);
                    }
                }
            }
        }

        static void KartsizParaYatirma()
        {
            Console.WriteLine("1-Nakit Ödeme\n2-Hesaptan Ödeme\nSeçiminiz:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Kredi kartı numarası (en az 12 haneli): ");
                string kartNo = Console.ReadLine();

                if (kartNo.Length >= 12 && long.TryParse(kartNo, out _))
                {
                    Console.Write("TC Kimlik No (11 haneli): ");
                    string tcKimlik = Console.ReadLine();

                    if (tcKimlik.Length == 11 && long.TryParse(tcKimlik, out _))
                    {
                        Console.Write("Nakit ödeme miktarı: ");
                        double miktar = Convert.ToDouble(Console.ReadLine());
                        bakiye += miktar;
                        Console.WriteLine($"{miktar} TL nakit olarak yatırıldı. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("TC Kimlik Numarası hatalı!");
                    }
                }
                else
                {
                    Console.WriteLine("Kredi kartı numarası hatalı!");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Kredi kartı numarası (en az 12 haneli): ");
                string kartNo = Console.ReadLine();
                Console.Write("Hesap numarası (en az 12 haneli): ");
                string hesapNo = Console.ReadLine();

                if (kartNo.Length >= 12 && long.TryParse(kartNo, out _) && hesapNo.Length >= 12 && long.TryParse(hesapNo, out _))
                {
                    Console.Write("Hesaba yatırılacak miktar: ");
                    double miktar = Convert.ToDouble(Console.ReadLine());
                    bakiye += miktar;
                    Console.WriteLine($"{miktar} TL hesaba yatırıldı. Yeni bakiyeniz: {bakiye}");
                }
                else
                {
                    Console.WriteLine("Kredi kartı veya hesap numarası hatalı!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Para Yatırma Seçimi!");
            }
            AnaMenuDon();
        }

        static void KrediKartiOdeme()
        {
            Console.WriteLine("1-Başka Hesaba EFT\n2-Başka Hesaba Havale\nSeçiminiz:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("EFT numarası (TR ve 12 haneli sayı): ");
                string eftNo = Console.ReadLine().ToUpper();

                if (eftNo.StartsWith("TR") && eftNo.Length == 14 && long.TryParse(eftNo.Substring(2), out _))
                {
                    Console.Write("EFT Miktar Girişi: ");
                    double miktar = Convert.ToDouble(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} TL EFT gerçekleştirildi. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                }
                else
                {
                    Console.WriteLine("EFT numarası hatalı!");
                }
            }
            else if (secim == "2")
            {
                Console.Write("Hesap numarası (11 haneli): ");
                string hesapNo = Console.ReadLine();

                if (hesapNo.Length == 11 && long.TryParse(hesapNo, out _))
                {
                    Console.Write("Gönderilecek miktar: ");
                    double miktar = Convert.ToDouble(Console.ReadLine());

                    if (bakiye >= miktar)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} TL havale gerçekleştirildi. Yeni bakiyeniz: {bakiye}");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                }
                else
                {
                    Console.WriteLine("Hesap numarası hatalı!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Seçim!");
            }
            AnaMenuDon();
        }

        static void KartsizOdemeler()
        {
            Console.WriteLine("1-Elektrik\n2-Telefon\n3-İnternet\n4-Su\n5-OGS\nSeçiminiz:");
            string fatura = Console.ReadLine();

            if (fatura == "1" || fatura == "2" || fatura == "3" || fatura == "4" || fatura == "5")
            {
                Console.Write("Fatura bedeli: ");
                double miktar = Convert.ToDouble(Console.ReadLine());

                if (bakiye >= miktar)
                {
                    bakiye -= miktar;
                    Console.WriteLine($"{miktar} TL fatura ödendi. Yeni bakiyeniz: {bakiye}");
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz Fatura Türü!");
            }
            AnaMenuDon();

            
        }
        #endregion
    }

}
