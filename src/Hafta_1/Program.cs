using System;

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


static void Cevap1()
{
    int sayi = int.Parse(Console.ReadLine());
    Console.WriteLine(Math.Pow(sayi, 2));
}
static void Cevap2()
{
    double a;
    Console.Write("Bir sayı giriniz :");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Girilen Sayının Karesi:" + Math.Pow(a, 2));
    Console.WriteLine("Girilen Sayının Küpü:" + Math.Pow(a, 3));
    Console.WriteLine("Girilen Sayının Karekökü :" + Math.Sqrt(a));
    Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
    Console.ReadKey();//ilyas Bozdemir
                      //cemberin çevresi 

    Console.Write("Cemberin yarıcapını giriniz:");
    double r = Convert.ToDouble(Console.ReadLine());
    r = 2 * Math.PI * r;//ilyas Bozdemir
    Console.WriteLine("Cemberin çevresi :" + r);
    Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
    Console.ReadKey();
    //dairenin alanı

    Console.Write("Dairenin yarıcapını giriniz:");
    double r2 = Convert.ToDouble(Console.ReadLine());

    double alan = Math.PI * Math.Pow(r2, r2);

    Console.WriteLine("Dairein alanı :" + r2);
    Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
    Console.ReadKey();
    //silindirin alan hacmi

    Console.Write("Silindirin yarıcapını giriniz:");
    double r3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Silindirin yüksekliğini giriniz:");
    double h = Convert.ToDouble(Console.ReadLine());
    double alann = 2 * Math.PI * (r3 + h);
    double hacim = Math.PI * r3 * r3 * h;
    Console.WriteLine("Silindirin alanı :" + alann);
    Console.WriteLine("Silindirin hacmi :" + hacim);
    Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
    Console.ReadKey();
    // iki sayıdan büyük olanı yazdırma

    Console.Write("Birinci sayı giriniz:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayı giriniz:");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x > y)
    {
        Console.WriteLine(x);
    }
    else
        Console.WriteLine(y);
    // iki sayıdan küçük olanı yazdırma
    int s = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayı giriniz:");
    int d = Convert.ToInt32(Console.ReadLine());
    if (s < d)
    {
        Console.WriteLine(s);
    }
    else
        Console.WriteLine(d);
}
static void Cevap3()
{
    int x = 5, y = 8;
    Console.WriteLine("x = {0}", x);
    Console.WriteLine("{0} + {0} = {1}", x, (x + x));
    Console.Write("x =");//ilyas Bozdemir
    Console.WriteLine("{0} = {1}", (x + y), (y + x));
    Console.ReadLine();//ilyas Bozdemir
}
static void Cevap4()
{
    Console.WriteLine("{0}\n{1}\n{2}", "*", "***", "*****");
    Console.WriteLine("*\n**\n***\n****\n*****");
    Console.WriteLine("*");//ilyas Bozdemir
    Console.WriteLine("***");
    Console.WriteLine("*****");
    Console.WriteLine("****");
    Console.WriteLine("**");
    Console.Write("*");//ilyas Bozdemir
    Console.WriteLine("***");
    Console.WriteLine("*****");
    Console.Write("****");//ilyas Bozdemir
    Console.WriteLine("**");//ilyas Bozdemir
    Console.ReadLine();
}
static void Cevap5()
{
    int x = 2, a = 1;
    double sonucA = a * Math.Pow(x, 4) + 3;
    double sonucB = Math.Pow(a, 85) + Math.Pow(x, 25);
    double sonucC = Math.Abs(-a) + Math.Abs(a);
    double sonucD = Math.Abs(2 * a);
    double sonucE = Math.Abs(a + a);
    double sonucF = Math.Abs(a) + Math.Abs(a);
    double sonucG = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(x, 2));
    double sonucH =
        (-a + Math.Sqrt(Math.Pow(x, 2) - 4 * a * x)) / 2 * a;
    double sonucH2 =
       (-a - Math.Sqrt(Math.Pow(x, 2) - 4 * a * x)) / 2 * a;
    double[] sonuclar =
    {
        sonucA,
        sonucB,
        sonucC,
        sonucD,
        sonucE,
        sonucF,
        sonucG,
        sonucH,//NaN
        sonucH2//NaN
    };
    foreach (var sonuc in sonuclar)
    {
        Console.WriteLine("Sonuc: " + sonuc);
    }

}
static void Cevap6()
{
    //y=ax+7 denklemi için;
    //y = ax+ 7, denklemi için C# ifadelerinden hangileri doğrudur? 
    //y = a * x * x * x + 7; 
    //y = a * x * x * ( x + 7 )
    //y = ( a * x ) * x * ( x + 7 ); 
    //y = ( a * x ) * x * x + 7; 
    //y = a * ( x * x * x ) + 7; 
    //y = a * x * ( x * x + 7 );
    double a = 3, x = 4;
    double sonucA = a * x * x * x + 7;
    double sonucB = a * x * x * (x + 7);
    double sonucC = (a * x) * x * (x + 7);
    double sonucD = (a * x) * x * x + 7;
    double sonucE = a * (x * x * x) + 7;
    double sonucF = a * x * (x * x + 7);
    double[] sonuclar =
    {
        sonucA,
        sonucB,
        sonucC,
        sonucD,
        sonucE,
        sonucF
    };
    foreach (var sonuc in sonuclar)
    {
        Console.WriteLine("y değerleri: " + sonuc);
    }
}
static void Cevap7()
{
    double x = 7 + 3 * 6 / 2 - 1;
    Console.WriteLine(x);
    x = 2 % 2 + 2 * 2 - 2 / 2;
    Console.WriteLine(x);
}
static void Cevap8()
{
    Console.Write("1.Sayıyı Girin :");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2.Sayıyı Girin :");
    double b = Convert.ToDouble(Console.ReadLine());
    double topla = a + b;//ilyas Bozdemir
    double cıkarma = a - b;
    double carpma = a * b;//ilyas Bozdemir
    double bolme = a / b;
    Console.WriteLine("Toplama Sonucu :" + topla);
    Console.WriteLine("Çıkarma Sonucu :" + cıkarma);
    Console.WriteLine("Çarpma Sonucu :" + carpma);
    Console.WriteLine("Bölme Sonucu :" + bolme);
}
static void Cevap9()
{
    int a = 0, b = 1, c = 2;
    int d = (a >= b - c) ? (a + b + c) : (a * b * c);
    Console.WriteLine(d);
    a = 1;
    b = 3;
    c = 2;
    d = (a >= b - c) ? (a + b + c) : (a * b * c);
    Console.WriteLine(d);
    Console.ReadLine();//ilyas Bozdemir
    a = 5;
    b = 1;
    c = 2;
    d = (a >= b - c) ? (a + b + c) : (a * b * c);
    Console.WriteLine(d);
}
static void Cevap10()
{
    int a = 5;
    a = a + 1;//a += 1; ile aynıdır
    Console.WriteLine(a);
    a = 5;
    a += 1;//a = a + 1; ile aynıdır.
    Console.WriteLine(a);
    a = 5;
    a++;
    Console.WriteLine(a);
    a = 5;
    ++a;
    Console.WriteLine(a);
    a = 5;
    //a+1 kullanımı yoktur
    Console.WriteLine(a);
    a = 5;
}
static void Cevap11()
{
    int a = 5;
    a = a - 1;//a -= 1; ile aynıdır
    Console.WriteLine(a);
    a = 5;
    a -= 1;//a = a - 1; ile aynıdır.
    Console.WriteLine(a);
    a = 5;
    a--;
    Console.WriteLine(a);
    a = 5;
    --a;
    Console.WriteLine(a);
    a = 5;
    //a-1 kullanımı yoktur
    Console.WriteLine(a);
    a = 5;
}
static void Cevap12()
{
    int a = 12 % 3,b = 12 % 5, c = 12 / 4,d = 10 % 3;
    //ilyas Bozdemir
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
}