//Cevap1();
//Cevap2();
//Cevap3();
//Cevap4();
//Cevap5();
//Cevap6();
//Cevap7();
//Cevap8();
//Cevap9();
//Cevap10();
//Cevap11();
//Cevap12();
//Cevap13();
static void Cevap1()
{
    /*1.	Klavyeden girilen sayının asal olup olmadığını 
   * bulan programı yazınız. NOT: Bir ve kendisinden 
   * başka böleni olmayan sayılara asal sayı denir. (Örnek 11,13,7….) */
    Console.Write("Sayı Girin :");
    int sayı = Convert.ToInt32(Console.ReadLine());
    if (sayı / 1 == sayı || sayı / sayı == 1)
    {
        Console.Write("Sayı Asal Sayı Değildir:");
    }
    else//ilyas bozdemir
    {
        Console.Write("Sayı Asal Sayıdır:");   //ilyas bozdemir       
    }
}
static void Cevap2()
{
    /* Klavyeden girilen iki sayının 
      Ebob ve Ekok değerini bulan programı yazınız. */
    int sayı1, sayı2, obeb = 1;

    Console.WriteLine("1.sayıyı girin :");//ilyas bozdemir
    sayı1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2.sayıyı girin :");
    sayı2 = Convert.ToInt32(Console.ReadLine());
    int ebob = 0;

    if (sayı1 < sayı2)
    {//ilyas bozdemir
        for (int i = 1; i < sayı2; i++)
        {
            if (sayı2 % i == 0 && sayı1 % 1 == 0)
            {
                ebob = i;

            }
        }
    }
    if (sayı1 > sayı2)
    {
        for (int i = 1; i < sayı1; i++)
        {
            if (sayı2 % i == 0 && sayı1 % 1 == 0)
            {
                ebob = i;

            }
        }
    }
    Console.WriteLine("ebob : {0}", ebob);
    Console.WriteLine("ekok : {0}", (sayı1 * sayı2) / ebob);

}
static void Cevap3()
{
    Console.Write("kişi sayısını girin:");
    int kişi = Convert.ToInt32(Console.ReadLine());
    Console.Write("sandalye sayısını girin :");
    int sandalye = Convert.ToInt32(Console.ReadLine());
    int sonuc = 1;
    for (int i = 0; i < sandalye; i++)//ilyas bozdemir
    {
        sonuc = sonuc * kişi;
        kişi--;
    }
    //ilyas bozdemir
    Console.WriteLine(sonuc);

}
static void Cevap4()
{
    int sayac = 0;
    for (int a = 1; a < 10; a++)
    {
        for (int b = 1; b < 10; b++)
        {
            for (int c = 1; c < 10; c++)
            {
                int sayi = (a * 100) + (b * 10) + c;

                if (sayi % 10 == 9)
                {
                    Console.WriteLine(sayi);//ilyas bozdemir
                    sayac++;
                    Console.WriteLine("Sayac :" + sayac);
                    Console.ReadLine();//ilyas bozdemir

                    //ilyas bozdemir
                }


            }
        }
    }
}
static void Cevap5()
{
    int sayi = 220, sayi2 = 284, sayiT = 0, sayi2T = 0;
    Console.Write("1. sayı : ");
    sayi = int.Parse(Console.ReadLine());
    Console.Write("2. sayı : ");
    sayi2 = int.Parse(Console.ReadLine());
    for (int i = 1; i < sayi; i++)
        if (sayi % i == 0)
            sayiT += i;
    for (int i = 1; i < sayi2; i++)
        if (sayi2 % i == 0)
            sayi2T += i;
    string Message = (sayi == sayi2T && sayi2 == sayiT)
        ? $"{sayi} ve {sayi2} arkadaş sayılardır."
        : $"{sayi} ve {sayi2} arkadaş sayı değildir.";

    Console.WriteLine(Message);
}
static void Cevap6()
{
    //klavyeden girilen 4 basamaklı sayıyı ters çeviren program.
    string sayi = Console.ReadLine();
    Console.Write("Sonuç: ");
    for (int i = sayi.Length; i > 0; i--)
    {
        Console.Write(sayi.Substring(i - 1, 1));
    }
}
static void Cevap7()
{
    for (int a = 1; a < 10; a++)
    {
        for (int b = 1; b < 10; b++)
        {//ilyas bozdemir
            Console.Write("{0}*{1}={2}\t", a, b, (a * b));
        }
        Console.WriteLine();
    }//ilyas bozdemir
    Console.WriteLine();
}
static void Cevap8()
{
    double toplam = 0;
    double sonuc = 0;
    for (int i = 1; i < 100; i = i + 2)
    {//ilyas bozdemir
        sonuc = i * (i + i);
        toplam = toplam + Math.Sqrt(i * (i + 2));
    }//ilyas bozdemir
    Console.WriteLine(toplam);
}
static void Cevap9()
{
    int sayı = Convert.ToInt32(Console.ReadLine());
    //sayının asal olup olmadıgını bulan program
    int sayac = 0;
    for (int i = 1; i < sayı; i++)
    {
        if (sayı % i == 0)
        {
            sayac++;
        }//ilyas bozdemir
    }
    if (sayac == 0)
    {
        Console.WriteLine("asal");
    }
    else
    {//ilyas bozdemir
        Console.WriteLine("asal değil");
    }
}
static void Cevap10()
{
    Console.Write("girilen gün sayısı sonra :");
    int gün = Convert.ToInt32(Console.ReadLine());
    int sonuc = gün % 7;
    switch (sonuc)
    {//ilyas bozdemir
        case 0: Console.Write("Persembe"); break;
        case 1: Console.Write("Cuma"); break;
        case 2: Console.Write("Cumartesi"); break;
        case 3: Console.Write("Pazar"); break;
        case 4: Console.Write("Pazartesi"); break;
        case 5: Console.Write("Salı"); break;
        case 6: Console.Write("Carsamba"); break;
    }//ilyas bozdemir
}
static void Cevap11()
{
    double x1 = 0, y1 = 3,
           x2 = 3, y2 = 0,
           m = (y2 - y1) / (x2 - x1);
    Console.WriteLine("örnek 1");
    if (m == -1)
        Console.WriteLine("doğrunun eğimi sonsuzdur.");
    else if (y2 - y1 == 0 && y2 == y1)//iki kosulda aynıdır.
        Console.WriteLine("doğrunun eğimi sıfırdır.");
}
static void Cevap12()
{
    int sayı = Convert.ToInt32(Console.ReadLine());
    int sonuc = sayı % 8;
    switch (sonuc)
    {//ilyas bozdemir
        case 1: Console.Write("A"); break;
        case 2: Console.Write("B"); break;
        case 3: Console.Write("C"); break;
        case 4: Console.Write("D"); break;
        case 5: Console.Write("E"); break;
        case 6: Console.Write("D"); break;
        case 7: Console.Write("C"); break;
    }//ilyas bozdemir
}
static void Cevap13()
{
    //klavyeden girilen boy,
    //yaş ve kilo, cinsiyet bilgilerine
    //göre ideal kiloyu hesaplayıp ekrana
    //mesaj olarak yazacak bir program yazınız.
    double boy, kilo, sonuc;
    byte yas;
    bool cinsiyet;
    Console.Write("Boy : ");
    double.TryParse(Console.ReadLine(), out boy);
    Console.Write("Kilo : ");
    double.TryParse(Console.ReadLine(), out kilo);
    Console.Write("Yas : ");
    byte.TryParse(Console.ReadLine(), out yas);
    Console.WriteLine("Cinsiyet : Erkek(E), Kadın(K)");
    cinsiyet = Console.ReadLine().ToUpper() == "E" ? true : false;
    sonuc = (cinsiyet)
        ? 50 + 2.3 * ((boy - 152.4) / 2.54)
        : 45.5 + 2.3 * ((boy - 152.4) / 2.54);
    string cinsiyetM = (cinsiyet) ? "Erkek" : "Kadın";
    Console.WriteLine($"ideal kilo({cinsiyetM} için) {sonuc}");
}