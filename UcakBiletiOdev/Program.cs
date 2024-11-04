using UcakBiletiOdev.controller;
using UcakBiletiOdev.db;
using UcakBiletiOdev.entity;
using UcakBiletiOdev.service;

namespace UcakBiletiOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
             birÜstMenü:
            int anaMenü = -1;

            while (anaMenü != 0)
            {
                Console.WriteLine("**************ANA MENÜ***************");
                Console.WriteLine("1_Yolcu Girişi \n2_Yönetici Girişi \n0_Çıkış");
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
                int anaMenüSecim = Convert.ToInt32(Console.ReadLine());

                switch (anaMenüSecim)
                {
                    case 1:
                        int kullaniciMenu = -1;
                        while (kullaniciMenu != 0)
                        {
                            Console.WriteLine("**************YOLCU MENÜ***************");
                            Console.WriteLine("1_Uçak1 Bilet Satın Al \n2_Uçak2 Bilet Satın Al \n0_Bir Üst Menüye Dön");
                            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
                            int kullaniciMenüSecim = Convert.ToInt32(Console.ReadLine());

                            switch (kullaniciMenüSecim)
                            {
                                case 1:
                                    StokKontrol ucak1Stokkontrol = new StokKontrol();
                                    if (ucak1Stokkontrol.ucak1StokKontrol())
                                    {
                                        Console.WriteLine("Stoklarımızda Bilet Kalmadı");
                                        break;
                                    }
                                    else
                                    {


                                        Console.WriteLine("adinizi giriniz...");
                                        String ad = Console.ReadLine();

                                        Console.WriteLine("soyadinizi giriniz...");
                                        String soyad = Console.ReadLine();

                                        YolcuKaydetme yolcuKaydetme = new YolcuKaydetme();
                                        yolcuKaydetme.ucak1YolcuKaydet(ad, soyad);

                                        StokKontrolİsi ucak1StokKontrolIsi = new StokKontrolİsi();
                                        UcakBiletiStok.ucak1Stok = ucak1StokKontrolIsi.ucak1StokDusurmeIsı(UcakBiletiStok.ucak1Stok);

                                    }

                                    break;
                                case 2:
                                    StokKontrol ucak2Stokkontrol = new StokKontrol();
                                    if (ucak2Stokkontrol.ucak2StokKontrol())
                                    {
                                        Console.WriteLine("Stoklarımızda Bilet Kalmadı");
                                        break;
                                    }
                                    else { 


                                        Console.WriteLine("adinizi giriniz...");
                                        String ad1 = Console.ReadLine();

                                        Console.WriteLine("soyadinizi giriniz...");
                                        String soyad1 = Console.ReadLine();

                                        YolcuKaydetme yolcuKaydetme1 = new YolcuKaydetme();
                                        yolcuKaydetme1.ucak2YolcuKaydet(ad1, soyad1);

                                        StokKontrolİsi ucak2StokKontrolIsi = new StokKontrolİsi();
                                        UcakBiletiStok.ucak2Stok = ucak2StokKontrolIsi.ucak2StokDusurmeIsı(UcakBiletiStok.ucak2Stok);


                                    }


                                    break;
                                case 0:
                                    goto birÜstMenü;
                                    break;
                                default:
                                    Console.WriteLine("Hatalı Seçim Yapıldı");
                                    break;

                            }
                        }
                     break;
                        
                    case 2:
                        int adminMenu = -1;
                        while (adminMenu != 0)
                        {
                            Console.WriteLine("**************YÖNETİCİ MENÜ***************");
                            Console.WriteLine("1_Uçak1 Yolcu Listesini Görüntüle \n2_Uçak2 Yolcu Listesini Görüntüle \n3_Uçak1 Stok Güncelle \n4_Uçak2 Stok Güncelle \n0_Bir Üst Menüye Dön");
                            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
                            int adminMenüSecim = Convert.ToInt32(Console.ReadLine());

                            switch (adminMenüSecim)
                            {
                                case 1:

                                    YolcuListesiGoruntule ucak1YolcuListesiGoruntule = new YolcuListesiGoruntule();
                                    ucak1YolcuListesiGoruntule.ucak1YolcuGoruntule();


                                    break;

                                case 2:
                                    YolcuListesiGoruntule ucak2YolcuListesiGoruntule = new YolcuListesiGoruntule();
                                    ucak2YolcuListesiGoruntule.ucak2YolcuGoruntule();

                                    break;
                                case 3:
                                    Console.WriteLine("Uçak1 İçin Stok Giriniz");
                                    int ucak1Stok = Convert.ToInt32(Console.ReadLine());
                                    StokBelirleme ucak1StokBelirleme = new StokBelirleme();
                                    ucak1StokBelirleme.ucak1StokBelirleme(ucak1Stok);
                                    break;
                                case 4:
                                    Console.WriteLine("Uçak2 İçin Stok Giriniz");
                                    int ucak2Stok = Convert.ToInt32(Console.ReadLine());
                                    StokBelirleme ucak2StokBelirleme = new StokBelirleme();
                                    ucak2StokBelirleme.ucak2StokBelirleme(ucak2Stok);
                                    break;


                                case 0:
                                    goto birÜstMenü;
                                    break;
                                default:
                                    Console.WriteLine("Hatalı Seçim Yapıldı");
                                    break;

                            }

                        }break;

                    case 0:
                        Console.WriteLine("Çıkış Yapıldı");
                        anaMenü = 0;
                        break;

                    default:
                        Console.WriteLine("Hatalı Seçim Yapıldı");
                        break;
                }
            }
        }   
    }
}
