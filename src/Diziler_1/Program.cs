//Cevap1a();
//Cevap1b();
//Cevap1c();
//Cevap1d();
//Cevap1e();
//Cevap2();
//Cevap3();
//Cevap4();
//Cevap5();
//Cevap6();
//Cevap7();
//Cevap8();
//Cevap9();
//Cevap10a();
//Cevap10b();
//Cevap10c();
//Cevap10d();
//Cevap10e();
//Cevap10f();
//Cevap10g();
//Cevap11a();
//Cevap11b();
//Cevap12();
//Cevap13();
//Cevap14();
//Cevap15();
//Cevap16();
//Cevap17();
//Cevap18();
//Cevap19();
//Cevap20();
//Cevap21();
//Cevap22a();
//Cevap22b();
//Cevap22c();
//Cevap22d();
//Cevap22e();
//Cevap22f();
//Cevap22g();
//Cevap22h();

static void Cevap1a()
{
    int[] sayılar = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write((i + 1) + "." + " sayı giriniz = ");
        sayılar[i] = Convert.ToInt32(Console.ReadLine());
    }
    //ilyas bozdemir
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"girilen sayılar : {sayılar[i]}");
        //ilyas bozdemir
    }

}
static void Cevap1b()
{
    int[] sayılar = new int[10];
    for (int i = 0; i < 10; i++)
    {

        Console.Write((i + 1) + "." + " sayı giriniz = ");

        sayılar[i] = Convert.ToInt32(Console.ReadLine());

    }//ilyas bozdemir
    int toplam = 0;
    for (int i = 0; i < 10; i++)
    {
        toplam = sayılar[i] + toplam;
        //ilyas bozdemir
    }
    Console.WriteLine("dizinin sayıları toplamı : {0} ", toplam);
}
static void Cevap1c()
{
    //ilyas bozdemir
    int[] sayılar = new int[10];
    for (int i = 0; i < 10; i++)
    {

        Console.Write((i + 1) + "." + " sayı giriniz = ");
        sayılar[i] = Convert.ToInt32(Console.ReadLine());
    }
    foreach (int eleman in sayılar)
    {//ilyas bozdemir
        if (eleman > 0) // Çift sayı olup olmadığı kontrol ediliyor.
            Console.WriteLine(eleman);
    }
}
static void Cevap1d()
{
    int[] sayılar = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write((i + 1) + "." + " sayı giriniz = ");
        sayılar[i] = Convert.ToInt32(Console.ReadLine());
    }//ilyas bozdemir
    foreach (int eleman in sayılar)
    {
        if (eleman % 2 == 1 && eleman > 0) // tek sayı olup olmadığı kontrol ediliyor.
            Console.WriteLine(eleman);
    }//ilyas bozdemir
}
static void Cevap1e()
{
    int[] sayılar = new int[10];
    for (int i = 0; i < 10; i++)
    {//ilyas bozdemir
        Console.Write((i + 1) + "." + " sayı giriniz = ");
        sayılar[i] = Convert.ToInt32(Console.ReadLine());
    }
    foreach (int eleman in sayılar)
    {
        if (eleman < 0) // tek sayı olup olmadığı kontrol ediliyor.
                        //ilyas bozdemir
        {
            Console.WriteLine("negatif => " + eleman);
        }
        else
        {
            Console.WriteLine("pozitif => " + eleman);
        }

    }
}
static void Cevap2()
{
    int[] dizi = new int[50];

    for (int i = 0; i < 50; i++)//ilyas bozdemir
    {
        if (i % 5 == 0)//sart koyma 5 ve 5in katları
        {
            dizi[i] = i;//i'yi diziye atadık
            Console.WriteLine(dizi[i]);//diziyi yazdırdık ekrana 
        }
        //ilyas bozdemir
    }
}
static void Cevap3()
{
    string[] Gün = { "Pazartesi", "Salı", "Carsamba", "Persembe", "Cuma", "Cumartesi", "Pazar" };
    Console.Write(" index numarası girin : ");
    int index = Convert.ToInt32(Console.ReadLine());
    int sonuc = index % 7;
    //6'dan buyuk değer girldiğinde hata vermemesi için döngü yapıyoruz.  
    switch (sonuc)
    {//ilyas bozdemir
        case 0: Console.WriteLine(Gün[0]); break;
        case 1: Console.WriteLine(Gün[1]); break;
        case 2: Console.WriteLine(Gün[2]); break;
        case 3: Console.WriteLine(Gün[3]); break;
        case 4: Console.WriteLine(Gün[4]); break;
        case 5: Console.WriteLine(Gün[5]); break;
        case 6: Console.WriteLine(Gün[6]); break;
    }//ilyas bozdemir
}
static void Cevap4()
{
    string[] gün = { "Haftanın 1.Günü", "Haftanın 2.Günü", "haftanın 3.Günü",
             "Haftanın 4.Günü", "Haftanın 5.Günü", "Haftanın 6.Günü",
         "Haftanın 7.Günü"};
    Console.Write("Gün Adı girin : ");
    string secim = Console.ReadLine();

    switch (secim)
    {//ilyas bozdemir
        case "Pazartesi": Console.WriteLine(gün[0]); break;
        case "Salı": Console.WriteLine(gün[1]); break;
        case "Carsamba": Console.WriteLine(gün[2]); break;
        case "Persembe": Console.WriteLine(gün[3]); break;
        case "Cuma": Console.WriteLine(gün[4]); break;
        case "Cumartesi": Console.WriteLine(gün[5]); break;
        case "Pazar": Console.WriteLine(gün[6]); break;
    }
}
static void Cevap5()
{
    int[] dizi = { 45, 12, 23, 65, 95, 47,
                 85, 32, 21, 78, 59, 83, 33, 70 };
    Console.Write("Sayı girin :");
    int sayı = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] == sayı)
        {//ilyas bozdemir
            Console.WriteLine("{0} Sayısı Dizimizde Mevcuttur.", dizi[i]);

        }
        //ilyas bozdemir
        else
        {
            Console.WriteLine("{0} Sayısı Dizimizde Mevcut Değildir.", dizi[i]);
        }

    }
}
static void Cevap6()
{
    int[] sayı = new int[10];
    int rastsayı;
    Random rastgele = new Random();//rasgele nesnesi olusturduk
    for (int i = 0; i < sayı.Length; i++)
    {
        rastsayı = rastgele.Next(1, 50); //nesneye 1-50 arası değer verdik
        sayı[i] = rastsayı;//değerleri diziye atadık
    }
    for (int i = 0; i < sayı.Length; i++)
    {//ilyas bozdemir
        Console.WriteLine(sayı[i]);//diziyi ekrana yazdırdık.
                                   //ilyas Bozdemir
    }//sayılar tekrar ediyo burda ama sro oyle istemiyo

}
static void Cevap7()
{
    int[] sayilar = { 12, 34, 54, 6, 65, 74, 51, 17, 98, 43, 32, 100 };
    for (int i = 0; i < sayilar.Length; i++)
    {

        Console.WriteLine(sayilar[i]);
    }
    int min = sayilar[0];//ilyas bozdemir
    int mak = sayilar[0];
    for (int i = 1; i < sayilar.Length; i++)
    {
        if (min > sayilar[i])
        {
            min = sayilar[i];
        }
        if (mak < sayilar[i])//ilyas bozdemir
        {
            mak = sayilar[i];
        }
    }
    Console.WriteLine("=====================================");
    Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);
    Console.WriteLine("Dizi içindeki en küçük sayı: > > > " + min);
}
static void Cevap8()
{
    int[] sayılar = { 11, 15, 24, 35, 56, 78, 98, 70, 34, 12 };
    Console.WriteLine("Dizideki Sayılar : ");
    for (int i = 0; i < sayılar.Length; i++)
    {
        Console.WriteLine("{0}.indeks =>{1}", i, sayılar[i]);
    }
    int mak = sayılar[0];
    int min = sayılar[0];//ilyas bozdemir

    for (int i = 1; i < sayılar.Length; i++)
    {
        if (mak < sayılar[i])
        {
            mak = sayılar[i];//ilyas bozdemir
        }
        if (min > sayılar[i])
        {
            min = sayılar[i];
        }
    }
    Console.WriteLine("=====================================");
    Console.WriteLine("Dizi içindeki en büyük sayı ===> " + mak);
    Console.WriteLine("Dizi içindeki en küçük sayı ===> " + min);
}
static void Cevap9()
{
    char[] sesli = { 'a', 'e', 'i', 'u', 'ı', 'ü', 'o', 'ö',
                             'A', 'E', 'İ', 'U', 'I', 'Ü', 'O', 'Ö' };
    int sayi = 0;
    Console.Write("Bir Cümle Girin :");
    string cumle = Console.ReadLine();
    int[] yer = new int[0];//sesli harflerin kacıncı hecede oldugunu göstermek için 
    for (int i = 0; i < cumle.Length; i++)//girilen cümle için
    {
        //ilyas bozdemir
        for (int j = 0; j < sesli.GetLength(0); j++)//sesli harfler için
        {
            if (cumle[i] == sesli[j])//kosul kosma
            {
                sayi++;//sayıyı arttır
                System.Array.Resize(ref yer, yer.GetLength(0) + 1);
                yer[yer.GetLength(0) - 1] = i;//i sesli katrakterin oldugu yer 
            }
        }//ilyas bozdemir
    }
    Console.WriteLine("Cümlede {0} tane sesli harf vardır. ", sayi);
    Console.WriteLine();
    Console.WriteLine("***********************");
    Console.WriteLine();
    for (int i = 0; i < yer.GetLength(0); i++)
    {
        Console.WriteLine("Cümlenin {0} hecesinde sesli harf vardır. ", yer[i] + 1);
    }//ilyas bozdemir
}
static void Cevap10a()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
    foreach (var sayı in sayilar)
    {
        if (sayı % 3 == 0)//ilyas bozdemir
        {
            Console.WriteLine(sayı);
        }
    }

}
static void Cevap10b()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);//ilyas bozdemir
    }
    Console.WriteLine("***********************");
    Console.WriteLine("tersten yazılmıs hali :");
    Array.Reverse(sayilar);//terse cevirir.
    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);//ilyas bozdemir
    }
}
static void Cevap10c()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };

    // tersi yazılacak  olan diziyi olustur.

    int[] tersDizi = new int[sayilar.Length];

    // dizinin tersini for döngüsü kullanarak al

    for (int i = 0; i < sayilar.Length; i++)
    {
        tersDizi[i] = sayilar[sayilar.Length - 1 - i];
    }
    foreach (int sayi in sayilar)//ilyas bozdemir
    {
        Console.WriteLine("Düzü :{0}", sayi);
    }
    Console.WriteLine("********************");
    foreach (int sayi in tersDizi)//tersdiziyi ekrana yazdır
    {
        Console.WriteLine("tersi :{0}", sayi);//ilyas bozdemir
    }

}
static void Cevap10d()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
    int teksayac = 0, ciftsayac = 0;
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] % 2 == 0)//sayılar dizi ikinin katı mı ?
        {
            ciftsayac++;  //true
        }
        else//ilyas bozdemir
        {
            teksayac++;  //false
        }
    }

    Console.WriteLine("dizide {0} tane tek sayı vardır", teksayac);
    Console.WriteLine("dizide {0} tane çift sayı vardır", ciftsayac);
}
static void Cevap10e()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
    int mak = 0;
    for (int i = 1; i < sayilar.Length; i++)
    {

        if (mak > sayilar[i])
        {//ilyas bozdemir
            mak = sayilar[i];
        }
    }
    //ilyas bozdemir
    Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);

}
static void Cevap10f()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100, };
    int neg = 0;
    for (int i = 1; i < sayilar.Length; i++)
    {
        if (sayilar[i] < 0)
        {
            neg = sayilar[i]; //// eksik kod var
        }
    }//ilyas bozdemir
     //ilyas bozdemir

    Console.WriteLine("Dizi içindeki en büyük negatif sayı: > > > " + neg);
}
static void Cevap10g()
{
    int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
    int gecici;
    for (int i = 0; i < sayilar.Length; i++)
    {
        for (int j = i + 1; j < sayilar.Length; j++)
        {
            if (sayilar[j] < sayilar[i])
            {
                gecici = sayilar[i];//ilyas bozdemir
                sayilar[i] = sayilar[j];
                sayilar[j] = gecici;
            }
        }//ilyas bozdemir
    }
    foreach (int i in sayilar)
    {
        Console.WriteLine(i);
    }
}
static void Cevap11a()
{
    Console.Write("İl Girin :");
    string[] plakakodlari ={"Kayıt Yok", "01",
           "02", "03", "04", "05", "06"};
    string seçim = Console.ReadLine();
    switch (seçim)
    {//ilyas bozdemir
        case "Adana": Console.WriteLine(plakakodlari[1]); break;
        case "Adıyaman": Console.WriteLine(plakakodlari[2]); break;
        case "Afyonkarahisar": Console.WriteLine(plakakodlari[3]); break;
        case "Ağrı": Console.WriteLine(plakakodlari[4]); break;
        case "Amasya": Console.WriteLine(plakakodlari[5]); break;
        case "Ankara": Console.WriteLine(plakakodlari[6]); break;
        default: Console.WriteLine(plakakodlari[0]); break;
    }//ilyas bozdemir
}
static void Cevap11b()
{
    Console.WriteLine("Plaka Kodu Girin");
    string[] plakakodlari ={"Kayıt Yok", "Adana",
        "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"};
    int seçim = Convert.ToInt32(Console.ReadLine());
    switch (seçim)
    {//ilyas bozdemir
        case 1: Console.WriteLine(plakakodlari[1]); break;
        case 2: Console.WriteLine(plakakodlari[2]); break;
        case 3: Console.WriteLine(plakakodlari[3]); break;
        case 4: Console.WriteLine(plakakodlari[4]); break;
        case 5: Console.WriteLine(plakakodlari[5]); break;
        case 6: Console.WriteLine(plakakodlari[6]); break;
    }//ilyas bozdemir
}
static void Cevap12()
{
    Console.Write("Sayı Gir :");
    int sayı = Convert.ToInt32(Console.ReadLine());
    int[] tekdizi = new int[(sayı + 1) / 2];
    int[] çiftdizi = new int[(sayı + 1) / 2];
    int teksay = 0, çiftsay = 0;

    for (int i = 0; i < sayı; i++)
    {
        if (i % 2 == 0)
            çiftdizi[çiftsay++] = i;
        else
            tekdizi[teksay++] = i;
    }
    Console.Write("Çift Sayılar");
    Console.WriteLine(" ");
    foreach (var çift in çiftdizi)
    {
        Console.Write("{0} ,", çift);
    }
    Console.WriteLine(" ");
    Console.WriteLine("Tek Sayılar");

    foreach (var tek in tekdizi)
    {
        Console.Write("{0} ,", tek);
    }
}
static void Cevap13()
{
    int[] sayılar = { -23, -41, -82, -73, -44, 0, 56, 23, 78, 45 };
    int pozsay = 0, negsay = 0, say = 0;
    foreach (var sayı in sayılar)
    {
        if (sayı > 0 && sayı != 0)
        {//ilyas bozdemir
            pozsay++;
        }
        else if (sayı < 0 && sayı != 0)
        {
            negsay++;
        }
    }
    say = (sayılar.Length) - (negsay + pozsay);
    Console.WriteLine("Dizimizde {0} tane  pozitif sayı vardır", pozsay);
    Console.WriteLine("Dizimizde {0} tane  negatif sayı vardır", negsay);
    Console.WriteLine("Dizimizde {0} tane  sıfır sayı vardır", say);
}
static void Cevap14()
{
    int[] dizi = { 15, 26, 7, 8, 56, 78, 34, -32, -58 };
    int toplam = 0;
    foreach (var diz in dizi)
    { //ilyas bozdemir
        toplam = toplam + diz;
    }
    Console.WriteLine("toplam : {0}", toplam);
}
static void Cevap15()
{
    string[] Dizi = { "Ahmet", "Hayri", "Recep", "Hüseyin", "Seda" };
    Array.Reverse(Dizi);
    foreach (var değer in Dizi)
    {//ilyas bozdemir
        Console.WriteLine(değer);
    }
}
static void Cevap16()
{
    string[] isimler = { "Ahmet", "ilyas", "Recep", "Hüseyin", "Seda",
            "Mehmet","Ali","Veli","Saban","Hayri"};

    string girilen;

    Console.Write("Aradığınız ismi giriniz = ");

    girilen = Console.ReadLine();
    int indeks = Array.IndexOf(isimler, girilen);

    if (indeks == -1)
        Console.Write(" Aradığınız isim bulunamadı");

    else Console.Write("Aradığınız isim {0}. sırada bulundu", indeks + 1);

}
static void Cevap17()
{
    int[] dizi = new int[5];
    int toplam = 0;
    int i;
    int çsay = 0;//ilyas bozdemir

    for (i = 0; i < 5; i++)//kullanıcdan 5 sayıyı alalım
    {
        Console.Write("{0}. Sayıyı Giriniz :", i + 1);
        dizi[i] = Convert.ToInt32(Console.ReadLine());

    }
    // cift sayılarının sayısını bulalım....
    for (i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] % 2 == 0)
        {
            çsay++;//ilyas bozdemir
            toplam += dizi[i];
        }
    }

    Console.WriteLine("Çift Sayıların Ortalaması : " + toplam / çsay);//toplam
    Console.WriteLine("Çift Sayıların Sayısı : " + çsay);//çift sayıların toplamını
}
static void Cevap18()
{
    Random rastgele = new Random();
    int[] loto = new int[6];
    for (int i = 0; i < loto.Length; i++)
    {
        loto[i] = rastgele.Next(1, 49);
    }
    foreach (var sayısal in loto)
    {
        Console.Write("{0} ", sayısal);
    }
}
static void Cevap19()
{
    int[] tahmin = new int[5];
    int[] tahmin1 = new int[1];
    int tahminsay = 0;
    int tahminsay1 = 0;
    int sonuc = 0;
    Random rastgel = new Random();
    Random rastgel1 = new Random();
    for (int i = 0; i < tahmin.Length; i++)
    {
        Console.Write("{0}. tahmini girin :", i + 1);
        tahmin[i] = Convert.ToInt32(Console.ReadLine());
        //tahmin[i] = rastgel.Next(1, 34);

    }
    for (int i = 0; i < 1; i++)
    {
        Console.Write("+ tahmini girin :");
        tahmin1[i] = Convert.ToInt32(Console.ReadLine());
        //tahmin1[i] = rastgel1.Next(1, 14);
    }

    Random rastgele = new Random();
    Random rastgele1 = new Random();
    int[] sans = new int[5];
    int[] sans1 = new int[1];
    for (int i = 0; i < sans.Length; i++)
    {
        sans[i] = rastgele.Next(1, 34);
    }
    for (int i = 0; i < sans1.Length; i++)
    {
        sans1[i] = rastgele1.Next(1, 14);
    }
    Console.WriteLine(" ");
    Console.Write("Benim tahminim : ");
    foreach (var tahminn in tahmin)
    {
        Console.Write("{0} ", tahminn);
    }
    foreach (var tahmn in tahmin1)
    {
        Console.Write(" +{0}", tahmn);
    }
    Console.WriteLine(" ");
    Console.Write("Pc'nin tahmini : ");
    foreach (var sayısal in sans)
    {
        Console.Write("{0} ", sayısal);
    }
    foreach (var sayısal1 in sans1)
    {
        Console.Write("+{0} ", sayısal1);
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    for (int i = 0; i < tahmin.Length; i++)
    {
        for (int j = 0; j < tahmin.Length; j++)
        {
            if (tahmin[i] == sans[j])
            {
                tahminsay++;
            }
        }
    }
    for (int i = 0; i < tahmin1.Length; i++)
    {
        for (int j = 0; j < tahmin1.Length; j++)
        {
            if (tahmin1 == sans1)
            {
                tahminsay1++;
            }
        }
    }
    sonuc = tahminsay + tahminsay1;
    if (sonuc > 2 && sonuc < 7)
    {
        Console.WriteLine("Tebrikler  İkramiye Kazandınız !!!");
    }
    else
    {
        Console.WriteLine(" İkramiye kazanamadınız");
    }
}
static void Cevap20()
{
    int[] tahminim = new int[22];
    for (int i = 0; i < tahminim.Length; i++)
    {
        Console.Write("{0}.Tahmini Girin :", i + 1);
        tahminim[i] = Convert.ToInt32(Console.ReadLine());
    }
    int sayac = 0;
    int[] OnNumara = new int[22];
    Random rastgele = new Random();
    for (int i = 0; i < OnNumara.Length; i++)
    {
        OnNumara[i] = rastgele.Next(1, 80);
    }
    foreach (var sayı in OnNumara)
    {
        Console.WriteLine("{0} ", sayı);

    }
    Console.WriteLine("  ");

    for (int i = 0; i < tahminim.Length; i++)
    {
        for (int j = 0; j < tahminim.Length; j++)
        {
            if (tahminim[j] == OnNumara[i])
            {
                sayac++;
            }
        }
    }
    if (sayac == 6)
    {
        Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
    }
    else if (sayac == 7)
    {
        Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
    }
    else if (sayac == 8)
    {
        Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
    }
    else if (sayac == 9)
    {
        Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
    }
    else if (sayac == 10)
    {
        Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
    }
    else
    {
        Console.WriteLine("Bilemediniz");
    }
}
static void Cevap21()
{
    int sonuc = 0;
    int i, j, AsalKontrol;
    Console.WriteLine("Sayı Girin :");
    int sayı = Convert.ToInt32(Console.ReadLine());
    for (i = sayı + 1; i > sayı; i++)
    {
        AsalKontrol = 1;// a sayı asal değilse 0 
        for (j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                AsalKontrol = 0;// burdaki gibi
                break;
            }
        }
        if (AsalKontrol == 1)//sayı 1'se hala 
        {
            sonuc = i;
            i = 0;
        }
    }
    Console.WriteLine("Sonraki Sayı {0}'dır.", sonuc);
    for (i = sayı - 1; i < sayı; i--)
    {
        AsalKontrol = 1;
        for (j = 2; j < i; j++)
        {
            if (i % j == 0)//asal sayı değilse 
            {
                AsalKontrol = 0;
                break;
            }
        }
        if (AsalKontrol == 1) // asal sayıysa
        {
            sonuc = i;
            i = sayı + 1;
        }
    }
    Console.WriteLine("Önceki Sayı {0}'dır.", sonuc);
}
static void Cevap22a()
{
    int[] dizilerim = new int[50];//50 sayı tutan dizi yaptık.
    Random rastgele = new Random();//rastgele sayı sınıfını cagırdık
    int rast, sayac = 0;
    double toplam = 0;
    while (sayac < 50)//ilyas bozdemir
    {
        rast = rastgele.Next(50, 150);
        if (Array.IndexOf(dizilerim, rastgele) == -1)//dizilerin içindekiler
                                                     // aynı olmasın diye
        {
            dizilerim[sayac] = rast;//rastgele sayıları sayac 50 oluncaya kadar
            sayac++;//sayacı arttır.                //diziye aktar
        }
    }
    Console.Write("Dizidekiler :");
    for (int i = 0; i < dizilerim.Length; i++)
    {
        Console.Write("{0},", dizilerim[i]);
    }
    Console.WriteLine("");
    Console.Write("toplamı: ");
    for (int i = 0; i < dizilerim.Length; i++)
    {
        foreach (var top in dizilerim)
        {
            toplam = dizilerim[i];//dizileri toplama aktar ve topla 
        }
    }
    Console.WriteLine("Toplam : {0}", toplam);
    Console.WriteLine("Ortalama : {0}", toplam / 50);
}
static void Cevap22b()
{
    int[] dizilerim = new int[50];//50 sayı tutan dizi yaptık.
    Random rastgele = new Random();//rastgele sayı sınıfını cagırdık
    int rast, sayac = 0;
    while (sayac < 50)
    {//ilyas bozdemir
        rast = rastgele.Next(50, 150);
        if (Array.IndexOf(dizilerim, rastgele) == -1)//dizilerin içindekiler
                                                     // aynı olmasın diye
        {
            dizilerim[sayac] = rast;//rastgele sayıları sayac 50 oluncaya kadar
            sayac++;//sayacı arttır.                //diziye aktar
        }
    }
    Console.Write("Dizidekiler :");
    for (int i = 0; i < dizilerim.Length; i++)
    {
        Console.Write("{0},", dizilerim[i]);
    }
    Console.WriteLine("----------------------------------");

    foreach (var buyuk in dizilerim)
    {
        if (buyuk >= 100)
        {
            Console.Write("{0},", buyuk);
        }
    }
    Console.WriteLine("");
}
static void Cevap22c()
{
    int[] dizilerim = new int[50];//50 sayı tutan dizi yaptık.
    Random rastgele = new Random();//rastgele sayı sınıfını cagırdık
    int rast, sayac = 0;
    while (sayac < 50)
    {
        rast = rastgele.Next(50, 150);
        if (Array.IndexOf(dizilerim, rastgele) == -1)//dizilerin içindekiler
                                                     // aynı olmasın diye
        {
            dizilerim[sayac] = rast;//rastgele sayıları sayac 50 oluncaya kadar
            sayac++;//sayacı arttır.                //diziye aktar
        }
    }//ilyas bozdemir
    Console.WriteLine("Dizidekiler :");
    for (int i = 0; i < dizilerim.Length; i++)
    {
        Console.Write("{0},", dizilerim[i]);
    }
    Console.WriteLine("----------------------------------");

    foreach (var kucuk in dizilerim)
    {
        if (kucuk <= 100)
        {
            Console.Write("{0},", kucuk);
        }
    }
    Console.WriteLine("");
}
static void Cevap22d()
{
    int[] sayilar = new int[50];
    Random rnd = new Random();
    int min, mak;
    //ilyas bozdemir
    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = rnd.Next(50, 150);
        Console.Write("{0},", sayilar[i]);
    }
    Console.WriteLine(" ");
    min = sayilar[0]; //ayrıntı burda
    mak = sayilar[0];
    for (int i = 1; i < sayilar.Length; i++)
    {
        if (min > sayilar[i])
        {
            min = sayilar[i];
        }
        if (mak < sayilar[i])
        {
            mak = sayilar[i];
        }
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);
    Console.WriteLine("Dizi içindeki en küçük sayı: > > > " + min);
    Console.WriteLine("--------------------------------------");
}
static void Cevap22e()
{
    int[] sayilar = new int[50];
    Random rnd = new Random();
    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = rnd.Next(50, 150);
        Console.Write("{0},", sayilar[i]);
    }//ilyas bozdemir
    Console.WriteLine(" ");
    int gecici;
    for (int i = 0; i < sayilar.Length; i++)
    {
        for (int j = i + 1; j < sayilar.Length; j++)
        {
            if (sayilar[j] > sayilar[i])
            {
                gecici = sayilar[i];
                sayilar[i] = sayilar[j];
                sayilar[j] = gecici;
            }
        }//ilyas bozdemir
    }
    Console.WriteLine(" ");
    Console.WriteLine("--------------------------------------");
    foreach (int i in sayilar)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("--------------------------------------");
}
static void Cevap22f()
{
    int[] sayilar = new int[50];
    Random rnd = new Random();
    Console.Write("Aradığınız sayıyı giriniz = ");
    int aranan = Convert.ToInt32(Console.ReadLine());
    if (Array.IndexOf(sayilar, aranan) == -1)
    {
        Console.WriteLine("Yok");
    }

    else//ilyas bozdemir
    {
        Console.WriteLine("Var");
    }

    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = rnd.Next(50, 150);
        Console.Write("{0},", sayilar[i]);
    }
    Console.WriteLine(" ");//ilyas bozdemir
}
static void Cevap20g()
{
    int sayac = 0;
    Random rastgele = new Random();
    int[] sayılar = new int[20];

    Console.WriteLine("Oluşturulan Dizi");
    Console.WriteLine();
    for (int i = 0; i < sayılar.Length; i++)
    {
        sayılar[i] = rastgele.Next(50, 150);
        Console.Write(sayılar[i].ToString() + " ");
    }
    Console.WriteLine();
    for (int i = 50; i <= 150; i++)
    {
        sayac = 0;
        for (int j = 0; j < sayılar.Length; j++)
        {
            if (i == sayılar[j])
            {
                sayac++;
            }
        }
        if (sayac != 0)
            Console.WriteLine("{0} sayısından  {1} tane vardır", i, sayac);
    }
}
static void Cevap22h()
{
    int[] sayilar = new int[50];
    Random rnd = new Random();
    double toplam = 0.0;
    Console.WriteLine("A dizisi ");
    Console.WriteLine(" ");//ilyas bozdemir
    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = rnd.Next(50, 150);
        Console.Write("{0},", sayilar[i]);
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.Write("B dizisindeki, ");//ilyas bozdemir
    int[] bdizisi = new int[50];
    Console.WriteLine("Sayıların Kareleri : ");
    Console.WriteLine(" ");
    for (int i = 0; i < sayilar.Length; i++)
    {
        bdizisi[i] = sayilar[i];
        Console.Write("{0},", Math.Pow(bdizisi[i], 2));
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("C dizisinde ki");
    Console.WriteLine("Sayıların Karekökleri : ");
    Console.WriteLine(" ");//ilyas bozdemir
    int[] cdizisi = new int[50];
    for (int i = 0; i < sayilar.Length; i++)
    {
        cdizisi[i] = sayilar[i];
        Console.Write("{0},", Math.Sqrt(cdizisi[i]));
    }
    Console.WriteLine();
    Console.WriteLine("D dizisi ");
    Console.WriteLine("b ve c dizisindeki sayıların toplamı :");
    for (int i = 0; i < sayilar.Length; i++)
    {
        toplam = toplam + bdizisi[i] + cdizisi[i];
        Console.WriteLine(toplam);
    }
    Console.WriteLine("sayıların toplamı :{0}", toplam);
}