//Cevap1();
//Cevap2();
//Cevap3();
//Cevap4();
//Cevap5();
//Cevap6();
Cevap7();
//Cevap8();
//Cevap9();

static void Cevap1()
{
    /*1.	Klavyeden girilen değerler ile üniversite öğrencisinin
           * Türkçe dersinden ortalamasını hesaplayan ve ekrana geçip
         * kaldığını yazan programı koşul ifadeleri kullanarak 
          * yapınız, geçme notu 70’dir. ( Vize1 %20 + Vize2%20 + Final%60) */
    int vize1, vize2, final;
    Console.Write("vize1 değer girin :");
    vize1 = Convert.ToInt32(Console.ReadLine()); //ilyas bozdemir
    Console.Write("vize2 değer girin :");
    vize2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("final değer girin :");
    final = Convert.ToInt32(Console.ReadLine());
    double sonuc = (vize1 * 0.20) + (vize2 * 0.20) + (final * 0.60);
    if (sonuc > 70)

    {
        Console.WriteLine(sonuc + "= Geçti");
    }
    else
    {
        Console.WriteLine(sonuc + "= Kaldı");
    }
}
static void Cevap2()
{
    /*Girilen hava sıcaklığına göre, yapılması önerilen 
    * faaliyeti ekrana yazdıran programı yazınız.
•	30 dereceden yüksek ise YÜZME
•	20 dereceden yüksek ise TENİS
•	10 dereceden yüksek ise GOLF
•	0 dereceden yüksek ise SİNEMA
•	0 dereceden düşük ise KAYAK
 */
    Console.Write("Sıcaklık değeri Girin :");
    int sıcaklık = Convert.ToInt32(Console.ReadLine());
    if (sıcaklık > 30)
    {
        Console.WriteLine("YÜZME");
    }
    else if (sıcaklık > 20 && sıcaklık < 30)
    {
        Console.WriteLine("TENİS");
    }
    else if (sıcaklık > 10 && sıcaklık < 20)
    {
        Console.WriteLine("GOLF");//ilyas bozdemir
    }
    else if (sıcaklık > 0 && sıcaklık < 10)
    {
        Console.WriteLine("SİNEMA");
    }
    else
    {
        Console.WriteLine("KAYAK");
    }
}
static void Cevap3()
{
    /*3.	Klavyeden girilen değerler ile alan hesaplamaları yaparak
     * aşağıdaki menü seçeneklerini gerçekleştiren projeyi oluşturunuz.
    ******ALAN HESAPLARI******
    •	Dikdörtgen
    •	Üçgen
    •	Daire
    •	Programdan çıkış */
    Console.WriteLine("//Dikdörtgen// ");
    Console.Write("a kenarını girin :");
    int dik_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("b kenarını girin :");
    int dik_b = Convert.ToInt32(Console.ReadLine());
    int dik_alan = dik_a * dik_b;
    Console.WriteLine("dikdörtgenin alanı :" + dik_alan);
    Console.Write("üçgen için enter'a basın...");
    Console.ReadLine();
    Console.WriteLine("//Üçgen// ");
    Console.WriteLine("a kenarını girin :");//ilyas bozdemir
    int üçgen_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("yükseklik girin :");
    int üçgen_h = Convert.ToInt32(Console.ReadLine());
    int üçgen_alan = (üçgen_a * üçgen_h) / 2;
    Console.WriteLine("Üçgenin alanı :" + üçgen_alan);
    Console.Write("daire için enter'a basın...");
    Console.ReadLine();
    Console.WriteLine("//Daire// ");//ilyas bozdemir
    Console.WriteLine("r yarıcapı girin :");
    int r = Convert.ToInt32(Console.ReadLine());
    double daire_alan = Math.PI * Math.Pow(r, 2);
    Console.WriteLine("Dairenin Alanı :" + daire_alan);

}
static void Cevap4()
{
    /* N tane personelin maaşını hesaplayan programı yapınız. 
 (Aşağıdaki şirketin bölümlerinde çalışanların maaşlarının 
     nasıl hesaplandığı verilmiştir.)
       BÖLÜM A -->yaptığı satışın %15’i+ aylık 800TL
       BÖLÜM B -->yaptığı satışın %25’i
       BÖLÜM C -->çalıştığı saat başına 10 TL
       BÖLÜM D -->çalıştığı saat başına 8TL+ bir aydaki 160 saatten 
         sonra her saat için 10TL
        */

}
static void Cevap5()
{
    /* 5.	Klavyeden sıfır girilene kadar asal olup
    * olmadığını ekrana yazan programı yapınız. 
    * (yalnızca 1’e ve kendine bölünebilen sayılar asaldır.)*/

    Console.WriteLine("Sayı Girin :");
    int asal_sayı = Convert.ToInt32(Console.ReadLine());

    if (asal_sayı / asal_sayı == 1 || asal_sayı / 1 == asal_sayı)//ilyas bozdemir
    {
        Console.WriteLine(asal_sayı + " Sayı Asal Sayı Değildir.");
    }
    else//ilyas bozdemir
    {
        Console.WriteLine(asal_sayı + " Sayı Asal Sayıdır.");
    }
}
static void Cevap6()
{
    /*6.	1’den 50’ye kadar sayılardan çift sayıların karelerini 
         * tek sayıların küplerini alıp 
         * ekrana yazdıran programı  yapınız (Math.Pow ile yapılacak). */

    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0)
        {//ilyas bozdemir
            Console.WriteLine("çift :" + Math.Pow(i, 2));
        }
        else
        {
            Console.WriteLine("tek :" + Math.Pow(i, 3));
        }
    }//ilyas bozdemir
}
static void Cevap7()
{
    /* Klavyeden girilen 10 sayıdan 
•	100 ile 200 arasında olan sayıların karelerini
•	100’den küçük sayıların toplamını
•	200’den büyük sayıların 4’e kalansız olarak bölünenleri 
 * ekrana yazan programı yapınız.
*/
   

}
static void Cevap8()
{
    /*8.	Klavyeden önceden belirlenmiş bir PIN kodu girilmesini 
              * isteyin. Üç defa PIN numarasını yanlış girilmiş ise 
              * “Uygulama Bloke Olmuştur” mesajını, kullanıcı üç deneme 
              * hakkı içinde PIN kodunu doğru girerse
              * “Hoş Geldiniz…” mesajını veren programı yapınız. */
    string pin = "12345";
    byte cs = 0;
    while (cs < 3)
    {
        Console.Write("Pin Kodu giriniz:");
        string gpin = Console.ReadLine();
        if (gpin == pin)
        { Console.WriteLine("Hoşgeldiniz"); break; }//ilyas bozdemir
        else if (cs == 2)
        { Console.Write("Uygulamanız bloke olmuştur."); break; }
        else
        {
            Console.WriteLine("Pin Kodunu hatalı girdiniz tekrar deneyiniz");

        }//ilyas bozdemir
        cs++;
    }
}
static void Cevap9()
{
    /*9.	Klavyeden girilen sayı kadar aşağıdaki şekil gibi 
             * ekrana yıldız yazan programı yapınız.
*
**
***
****
      */
    for (int i = 1; i <= 4; i++)
    {//ilyas bozdemir
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        Console.Write("\n");
    }//ilyas bozdemir
}