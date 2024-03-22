//Cevap1();
//Cevap2();
//Cevap3();
//Cevap4();
//Cevap5();
//Cevap6();
//Cevap7();
//Cevap8();

static void Cevap1()
{
    /*Klavyeden girilen kilo değerine kişinin
     * ideal kilosununda – altında yada üzerinde 
     * olduğunu bildiren programı yazınız.
     * İdeal kilo hesaplama formülü 
     * İdeal kilo = boy - ((150-boy)/4)+110 şeklinde verilmiştir.
     * Programın kodlarını c# console kodları ile yazınız. 
     * */
    double boy, Idealkilo;
    Console.Write("Boy : ");
    double.TryParse(Console.ReadLine(), out boy);
    Idealkilo = boy - ((150 - boy) / 4) + 110;
    Console.WriteLine($"İdeal kilo = {Idealkilo}");
}
static void Cevap2()
{
    /*Bugün günlerden cumartesi ise X gün sonra hangi gün olur?” 
   * diye sorulan bir LYS sınav sorusunu klavyeden girilen 
  * sayıya göre hesaplayan programı C# Console kodları ile çözünüz .
Örnek: X=100 için Cevap: Pazartesi
*/
    int x_gün = Convert.ToInt32(Console.ReadLine());
    int sonuc = x_gün % 7;
    switch (sonuc)//ilyas bozdemir
    {
        case 0: Console.Write("persembe"); break;
        case 1: Console.Write("cuma"); break;
        case 2: Console.Write("cumartesi"); break;
        case 3: Console.Write("pazar"); break;
        case 4: Console.Write("pazartesi"); break;
        case 5: Console.Write("salı"); break;
        case 6: Console.Write("carsamba"); break;
    }
}
static void Cevap3()
{
    /*Üç basamaklı rakamları dokuzdan farklı
          * tüm sayıları ekranda gösteren ve bu kurala uygun kaç tane 
          * sayı olduğunu söyleyen programı C# Console kodları ile yazınız. */
    int sayi=0;
    int a, b, c, sayac = 0;
    for (a = 1; a < 10; a++)
    {
        for (b = 0; b < 10; b++)//ilyas bozdemir
        {
            for (c = 0; c < 10; c++)
            {
                for (int i = 0; i < 10; i++)
                {
                    sayi = (a * 100) + (b * 10) + c;
                }
                Console.WriteLine(sayi);//ilyas bozdemir
                sayac++;
                Console.Write("sayac :" + sayac);
                Console.ReadLine();


            }
        }
    }
}
static void Cevap4()
{
    Console.Write("kitap_sayısı girin :");
    int kitap_sayısı = Convert.ToInt32(Console.ReadLine());
    Console.Write("gecikme_gün girin :");
    int gecikme_gün = Convert.ToInt32(Console.ReadLine());
    Console.Write("gecikme_tutarı girin :");
    int gecikme_tutarı = Convert.ToInt32(Console.ReadLine());
    double ilk = (kitap_sayısı * gecikme_tutarı);// ilk bes
    double orta = (ilk * 0.10);// 6-10
    double son = (orta * 0.25);//+10
}
static void Cevap5()
{
    double krediMiktari = 0,
               sonuc = 0, faiz = 0,
               kFaiz = 1.08, tFaiz = 1.25;
    byte vadeMiktari = 0;
    Console.Write("kredi miktari : ");
    double.TryParse(Console.ReadLine(), out krediMiktari);
    Console.Write("vade miktari : ");
    byte.TryParse(Console.ReadLine(), out vadeMiktari);
    Console.WriteLine("kredi türü :\nkonut kredisi için 1"
        + "\n taşıt kredisi için 2");
    faiz = Console.ReadLine() == "1" ? kFaiz : tFaiz;

    sonuc = (krediMiktari * faiz) /
        (1 - (1 / Math.Pow(1 + faiz, vadeMiktari)));

    Console.Write("Aylık Ödeme Miktarı = " + sonuc);
    Console.Write($" Toplam Ödenecek Miktar = " + sonuc * vadeMiktari);
}
static void Cevap6()
{
    Console.Write("Sayı Girin :");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    for (int i = 1; i <= sayi / 2; i++)
    {
        if (sayi % i == 0)//ilyas bozdemir
        {
            toplam = toplam + i;
        }
    }
    if (sayi == toplam)
    {
        Console.WriteLine("Girdiğiniz Sayı Bir Mükemmel Sayıdır");
    }
    else//ilyas bozdemir
    {
        Console.WriteLine("Girdiğiniz Sayı Bir Mükemmel Sayı Değildir");
    }
}
static void Cevap7()
{
    Random rastgele = new Random();
    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    for (int i = 0; i < 8; i++)
    {//ilyas bozdemi
        int ascii = rastgele.Next(32, 127);
        char karakter = Convert.ToChar(ascii);
        sb.Append(karakter);

    }//ilyas bozdemir
    Console.WriteLine(sb.ToString());

}
static void Cevap8()
{
    int sayi;
    int yazilacak_rakam;//ilyas bozdemi
    Console.Write("Sayiyi giriniz : ");
    sayi = Convert.ToInt32(Console.ReadLine());
    Console.Write("Sayinin tersi : ");
    while (sayi > 10)
    {
        yazilacak_rakam = sayi % 10;
        Console.Write(yazilacak_rakam);
        sayi /= 10; //sayi=sayı/10
    }//ilyas bozdemir
    Console.WriteLine(sayi);
}