//Cevap1();
//Cevap2();
//Cevap3();
//Cevap4();
//Cevap5();
//Cevap6();
//Cevap7();
//Cevap8a();
//Cevap8b();
//Cevap8c();
//Cevap8d();
//Cevap8e();
//Cevap8f();
//Cevap8g();
//Cevap8h();
//Cevap9();
//Cevap10();
static void Cevap1()
{
    //Klavyeden girilen iki sayıdan büyük olanı ekrana 
    //yazdıran programı yapınız(if deyimi ile)
    Console.Write("birinci sayıyı girin :");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayıyı girin :");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b)//ilyas Bozdemir
    {
        Console.WriteLine("Büyük Olan Sayı :" + a);
    }
    else//ilyas Bozdemir
        Console.WriteLine("Büyük Olan Sayı :" + b);
}
static void Cevap2()
{
    // Dört işlem hesap makinası yapan 
    // programı yazınız.(switch-case)
    Console.Write("birinci sayıyı girin :");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayıyı girin :");//ilyas Bozdemir
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("1.Toplama\n2.Cıkarma\n3.Carpma\n4.Bölme\nİşlemleri için seçim yapınız.");
    int secim = Convert.ToInt32(Console.ReadLine());
    int topla = a + b;
    int cıkar = a - b;
    int carp = a * b;
    double bol = a / b;//ilyas Bozdemir
    switch (secim)
    {
        case 1: Console.Write("Toplama :" + topla); break;
        case 2: Console.Write("Çıkarma :" + cıkar); break;
        case 3: Console.Write("Çarpma :" + carp); break;
        case 4: Console.Write("Bölme :" + bol); break;//ilyas Bozdemir
        default: Console.Write("listeden değer seçiniz!!!"); break;
    }
}
static void Cevap3()
{
    //Dört işlem hesap makinası yapan programı yazınız.(if deyimi)
    Console.Write("birinci sayıyı girin :");
    int a = Convert.ToInt32(Console.ReadLine());//ilyas Bozdemir
    Console.Write("İkinci sayıyı girin :");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("1.Toplama\n2.Cıkarma\n3.Carpma\n4.Bölme\nİşlemleri için seçim yapınız.");
    int secim = Convert.ToInt32(Console.ReadLine());
    int topla = a + b;
    int cıkar = a - b;//ilyas Bozdemir
    int carp = a * b;
    double bol = a / b;
    if (secim == 1)
    {
        Console.Write("Toplama :" + topla);
    }
    else if (secim == 2)
    {
        Console.Write("Çıkarma :" + cıkar);
    }
    else if (secim == 3)
    {
        Console.Write("Çarpma :" + carp);
    }
    else if (secim == 4)//ilyas Bozdemir
    {
        Console.Write("Bölme :" + bol);
    }
    else Console.WriteLine("\aListeden seçim yapın.!!!");
}
static void Cevap4()
{
    // Klavyeden girilen numara ile bölüm adını
    //yazan programı yazınız(switch-case deyimi).
    Console.WriteLine("Bölüm Seçimi yapın: \n1.Bilgisayar Programcılıgı\n2.Saglık Yönetimi" +
   " \n3.Elektrik elektronik\n4.Muhasebe\n5.işletme");
    Console.Write("Bölüm İçin Seçim yapın  :");

    int bolum = Convert.ToInt32(Console.ReadLine());
    switch (bolum)//ilyas Bozdemir
    {
        case 1: Console.WriteLine("Seçiminiz :" + "Bilgisayar Programcılıgı "); break;
        case 2: Console.WriteLine("Seçiminiz :" + "Saglık Yönetimi"); break;
        case 3: Console.WriteLine("Seçiminiz :" + "Elektrik elektronik"); break;
        case 4: Console.WriteLine("Seçiminiz :" + "Muhasebe"); break;
        case 5: Console.WriteLine("Seçiminiz :" + "işletme "); break;//ilyas Bozdemir
        default: Console.WriteLine("\a 1-5 arası değer girin !!! "); break;
    }
}
static void Cevap5()
{
    Console.WriteLine("Bölüm Seçimi yapın: \n1.Bilgisayar Programcılıgı\n2.Saglık Yönetimi" +
          " \n3.Elektrik elektronik\n4.Muhasebe\n5.işletme");
    Console.Write("Bölüm İçin Seçim yapın  :");

    int bolum = Convert.ToInt32(Console.ReadLine());
    if (bolum == 1)
    {
        Console.WriteLine("Seçiminiz :" + "Bilgisayar Programcılıgı ");
    }
    else if (bolum == 2)//ilyas Bozdemir
    {
        Console.WriteLine("Seçiminiz :" + "Saglık Yönetimi");
    }
    else if (bolum == 3)
    {
        Console.WriteLine("Seçiminiz :" + "Elektrik elektronik");
    }
    else if (bolum == 4/*ilyas Bozdemir*/)
    {
        Console.WriteLine("Seçiminiz :" + "Muhasebe");
    }
    else if (bolum == 5)
    {
        Console.WriteLine("Seçiminiz :" + "işletme ");
    }
    else
    {
        Console.WriteLine("\a 1-5 arası değer girin !!! ");
    }

}
static void Cevap6()
{
    /*Beşlik not sistemine göre :
    5:Pekiyi,
    4:İyi,
    3:Orta,
    2:Geçer,
    1:Kaldı,
    Bunların dışında girilen rakamlar için hata mesajı verecek program, 
    klavyeden girilen değere göre notun karşılığını yazıyla ekranda göstersin("switch-case").*/
    Console.Write("1-5 Arası Not Giriniz :");
    int not = Convert.ToInt32(Console.ReadLine());
    switch (not)//ilyas Bozdemir
    {
        case 1: Console.WriteLine("Seciminiz :" + not + " Pekiyi"); break;//ilyas Bozdemir
        case 2: Console.WriteLine("Seciminiz :" + not + " İyi"); break;
        case 3: Console.WriteLine("Seciminiz :" + not + " Orta"); break;
        case 4: Console.WriteLine("Seciminiz :" + not + " Geçer"); break;
        case 5: Console.WriteLine("Seciminiz :" + not + " Kalır"); break;
        default: Console.WriteLine("lutfen 1-5 arası değer girin"); break;//ilyas Bozdemir
    }
}
static void Cevap7()
{
    /* Harfle gösterilen not sistemine göre :
   A:100-90 
   B:89-80 
   C:79-70 
   D:69-60 
   E:59-50 
   F:50 ve altı,
   eğer 0 ila 100 arasında bir sayı girmezse “yanlış not girdiniz” diye bir uyarı ekrana getiren program,
   klavyeden girilen değere göre harf notunu ekranda göstersin(if deyimi- if else deyimi).*/

    Console.Write("1-100 Arası Not Giriniz :");

    int not = Convert.ToInt32(Console.ReadLine());
    if (not >= 90 && not <= 100)
    {
        Console.WriteLine("not ve harfiniz :" + not + " A");
    }
    else if (not >= 80 && not < 89)//ilyas Bozdemir
    {
        Console.WriteLine("not ve harfiniz :" + not + " B");
    }
    else if (not >= 70 && not <= 79)
    {
        Console.WriteLine("not ve harfiniz :" + not + " C");
    }
    else if (not >= 60 && not <= 69)
    {//ilyas Bozdemir
        Console.WriteLine("not ve harfiniz :" + not + " D");
    }
    else if (not >= 50 && not <= 59)
    {
        Console.WriteLine("not ve harfiniz :" + not + " E");
    }
    else if (not < 50)
    {//ilyas Bozdemir
        Console.WriteLine("not ve harfiniz :" + not + " F");
    }
    else
    {
        Console.WriteLine("\a 1-100 Arası değer girin...");
    }
}
static void Cevap8a()
{
    for (int i = 99; i < 111; i++)
    {
        Console.WriteLine(i);
    }
}
static void Cevap8b()
{

    //b.	0 ila 14 arasındaki sayıların karelerini gösteriniz(while).
    int a = 0;
    while (a < 15)
    {
        a++;
        Console.Write("b. ");
        Console.WriteLine(a * a);
    }
}
static void Cevap8c()
{
    //c.	0 ila 9 arasındaki sayıların küplerini gösteriniz(for).

    for (int t = 0; t <= 9; t++)
    {
        Console.Write("c.");
        Console.WriteLine(Math.Pow(t, 3));//math.pow üslü sayılar içindir.
    }//ilyas Bozdemir
}
static void Cevap8d()
{
    //d.	0 ila 10 arasındaki sayıların toplamını bulunuz(while).
    int toplam = 0;
    int y = 0;//baslangıc 
    while (y <= 10)//bitiş 
    {
        Console.Write("d.");
        toplam = y + toplam;
        Console.WriteLine(toplam);
        y++;//artırma/(azaltma)
    }
}
static void Cevap8e()
{
    /*  e.	1 ila 100 arasındaki sayılardan 5’e bölümünde kalan 1 olan
* sayıları ekrana yazdır(for).*/
    for (int b = 0; b < 101; b++)
    {

        if (b % 5 == 1)
        {
            Console.WriteLine(b);
            Console.Write("e.");
        }
    }//ilyas Bozdemir
}
static void Cevap8f()
{
    //f.	0 ila 100 arasındaki sayılardan 10 ve 10’un 
    //katlarında ekrana “BOM” yazdıran programı yazınız(for-while).
    for (int x = 0; x < 101; x++)
    {
        Console.Write("f.");
        Console.WriteLine(x);
        if (x % 10 == 9)
        {
            Console.WriteLine("BOM!!!");
            //ilyas Bozdemir
        }
    }
}
static void Cevap8g()
{
    /*100 ila 500 arasındaki sayılardan(100 ve 500 dahil)
               *  3’e bölünen fakat 5’e bölünmeyen sayıları
               *  bulan ve ekranda gösteren kodları yazınız (while).
               */
    int i = 100;
    int say = 0;
    while (i < 500)
    {
        if (i % 3 == 0)//sayi 3'e tam bolunuyorsa
        {
            if (i % 5 != 0)//fakat sayı 5'in katı değilse 
            {
                Console.WriteLine("i =>> {0}", i);//Consol'a Yazdır
                say++;
            }
        }
        i++;
    }
    Console.WriteLine("Toplamda {0} Tane Vardır.", say);
}
static void Cevap9()
{
/*9.	Altıncı sorudaki programı, hatalı giriş yapıldığında uyarı mesajı
 * geldikten sonra program kapanmadan 
 * tekrar giriş yapılıp sonucu ekranda görünecek şekilde düzenleyiniz(goto). */
baslangıc: Console.Write("1-5 Arası Not Giriniz :");//baslangıc
    int not = Convert.ToInt32(Console.ReadLine());
    switch (not)//ilyas Bozdemir
    {
        case 1: Console.WriteLine("Seciminiz :" + not + " Pekiyi"); break;
        case 2: Console.WriteLine("Seciminiz :" + not + " İyi"); break;
        case 3: Console.WriteLine("Seciminiz :" + not + " Orta"); break;
        case 4: Console.WriteLine("Seciminiz :" + not + " Geçer"); break;
        case 5: Console.WriteLine("Seciminiz :" + not + " Kalır"); break;
        default: Console.WriteLine("lutfen 1-5 arası değer girin"); break;
            //ilyas Bozdemir
    }
    goto baslangıc;//1-5 arası olmazsa hata verir basar sarar
}
static void Cevap10()
{
    /* 10.	3 basamaklı sayılardan 10 un katlarını 
 * do-while ile ekrana yazdıran programı yapınız.*/

    int i = 0;
    do//ilyas Bozdemir
    {
        if (i % 10 == 0)
        {
            Console.WriteLine(i);

        } //ilyas Bozdemir
        i++;

    } while (i < 1000);

}