/* 1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.  */
class Program
{
    static void Main()
    {
        Console.WriteLine("Sipariş numarasını girin: ");
        int siparisNumarasi = Convert.ToInt32(Console.ReadLine());

        string secilenUrun = SiparisBelirle(siparisNumarasi);

        Console.WriteLine("Sipariş Edilen Ürün: " + secilenUrun);
    }

    static string SiparisBelirle(int siparisNumarasi)
    {
        string secilenUrun = "";

        switch (siparisNumarasi)
        {
            case 1:
                secilenUrun = "Bilgisayar";
                break;
            case 2:
                secilenUrun = "Telefon";
                break;
            case 3:
                secilenUrun = "Tablet";
                break;
            case 4:
                secilenUrun = "Yazıcı";
                break;
            case 5:
                secilenUrun = "Kamera";
                break;
            default:
                secilenUrun = "Geçersiz Sipariş Numarası";
                break;
        }

        return secilenUrun;
    }
}


/* 2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız) */
class Program
{
    static void Main()
    {
       
        double bilgisayarFiyati = 1500.0;
        double telefonFiyati = 800.0;
        double tabletFiyati = 500.0;
        double yaziciFiyati = 200.0;
        double kameraFiyati = 700.0;

      
        Console.WriteLine("Ürün Adı\tFiyatı");
        Console.WriteLine("1. Bilgisayar\t" + bilgisayarFiyati.ToString("C"));
        Console.WriteLine("2. Telefon\t" + telefonFiyati.ToString("C"));
        Console.WriteLine("3. Tablet\t" + tabletFiyati.ToString("C"));
        Console.WriteLine("4. Yazıcı\t" + yaziciFiyati.ToString("C"));
        Console.WriteLine("5. Kamera\t" + kameraFiyati.ToString("C"));

        Console.Write("Kaç ürün almak istiyorsunuz? ");
        int urunAdedi = Convert.ToInt32(Console.ReadLine());

        double toplamTutar = 0.0;

        // Kullanıcıdan her ürünün adını ve adetini alarak toplam tutarı hesapla
        for (int i = 0; i < urunAdedi; i++)
        {
            Console.Write($"Ürün {i + 1} Adı (1-5 arası): ");
            int urunNumarasi = Convert.ToInt32(Console.ReadLine());

            switch (urunNumarasi)
            {
                case 1:
                    toplamTutar += bilgisayarFiyati;
                    break;
                case 2:
                    toplamTutar += telefonFiyati;
                    break;
                case 3:
                    toplamTutar += tabletFiyati;
                    break;
                case 4:
                    toplamTutar += yaziciFiyati;
                    break;
                case 5:
                    toplamTutar += kameraFiyati;
                    break;
                default:
                    Console.WriteLine("Geçersiz Ürün Numarası");
                    i--; // Geçersiz ürün numarası girildiyse, döngü adımını geri al
                    break;
            }
        }

        // Toplam tutarı ekrana yazdır
        Console.WriteLine($"Toplam Alışveriş Tutarı: {toplamTutar.ToString("C")}");
    }
}
//  3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
/* While döngüsü, belirli bir koşul doğru olduğu sürece bir bloğu tekrarlamak için kullanılır.
 Döngü, başlangıçta koşul doğru olduğunda çalışır ve her tekrarda koşul kontrol edilir.
 Eğer koşul hala doğru ise döngü devam eder, aksi takdirde döngü sona erer. */
class Program
{
    static void Main()
    {
        int sayac = 1;

        while (sayac <= 5)
        {
            Console.WriteLine($"While Döngüsü - İterasyon {sayac}");
            sayac++;
        }

        Console.WriteLine("While Döngüsü Bitti");
    }
}
/* Do-While döngüsü, While döngüsüne benzer, ancak koşul döngü bloğunu tamamladıktan sonra kontrol edilir. 
  Yani, döngü bloğu en az bir kez çalıştırılır, ardından koşul kontrol edilir ve koşul doğru ise döngü devam eder. */
class Program
{
    static void Main()
    {
        int sayac = 1;

        do
        {
            Console.WriteLine($"Do-While Döngüsü - İterasyon {sayac}");
            sayac++;
        } while (sayac <= 5);

        Console.WriteLine("Do-While Döngüsü Bitti");
    }
}
// 4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (MukemmelSayiKontrolu(sayi))
        {
            Console.WriteLine($"{sayi} mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} mükemmel bir sayı değildir.");
        }
    }

    static bool MukemmelSayiKontrolu(int sayi)
    {
        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        return toplam == sayi;
    }
}

// 6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.
class Program
{
    static void Main()
    {
        Console.Write("Ürün Fiyatını Girin: ");
        double urunFiyati = Convert.ToDouble(Console.ReadLine());

        double kargoUcreti = 0.0;

        if (urunFiyati >= 300)
        {
            Console.WriteLine("Kargo Ücreti Alınmamaktadır.");
        }
        else
        {
            kargoUcreti = 50.0;
            Console.WriteLine($"Kargo Ücreti: {kargoUcreti:C}");
        }

        double toplamTutar = urunFiyati + kargoUcreti;
        Console.WriteLine($"Toplam Ödeme Tutarı: {toplamTutar:C}");
    }
}

// 7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.
class Program
{
    static void Main()
    {
        Console.Write("1. Ürün Fiyatını Girin: ");
        double urun1Fiyati = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Ürün Fiyatını Girin: ");
        double urun2Fiyati = Convert.ToDouble(Console.ReadLine());

        double toplamFiyat = urun1Fiyati + urun2Fiyati;

        if (toplamFiyat > 500)
        {
            // 2. ürüne %40 indirim yap
            double indirimMiktari = urun2Fiyati * 0.40;
            double indirimliUrun2Fiyati = urun2Fiyati - indirimMiktari;

            Console.WriteLine($"2. Ürüne Yapılan %40 İndirim: {indirimMiktari:C}");
            Console.WriteLine($"Ödenecek Toplam Tutar: {(urun1Fiyati + indirimliUrun2Fiyati):C}");
        }
        else
        {
            Console.WriteLine($"Ödenecek Toplam Tutar: {toplamFiyat:C}");
        }
    }
}
// 8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

class Program
{
    static void Main()
    {
        int baslangic = 1;
        int bitis = 200;
        int toplamAdet = 0;

        Console.WriteLine("1-200 arasındaki 3'e veya 5'e tam bölünebilen sayılar:");

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.Write($"{i} ");
                toplamAdet++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Toplam Adet: {toplamAdet}");
    }
}