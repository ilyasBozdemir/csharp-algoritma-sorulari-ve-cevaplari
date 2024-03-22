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
static void Cevap1()
{
    Console.Write("vize notu girin :");
    double vize1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("vize2 notunu girin :");//ilyas Bozdemir
    double vize2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("final notunu girin :");
    double final = Convert.ToInt32(Console.ReadLine());
    double ort = ort = (vize1 * 0.2 + vize2 * 0.2 + final * 0.6);
    string durum = ort > 70 ? "Geçti" : "Kaldı";
    Console.WriteLine("Durum :" + durum);
}
static void Cevap2()
{
    // 1.487 Amerikan Dolarına 
    //Fransız Frank’ı $0.172
    //Alman Mark’ı $0.584 
    //Japon Yen’i $0.00955 
    Console.Write("Dolar İçin Değer Giriniz :");
    double a = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
    double dolar = 1.487, frank = 0.172, mark = 0.584, Yen = 0.00955;
    Console.WriteLine("ABD Doları :" + dolar * a);//ilyas Bozdemir
    Console.WriteLine("Fransız Frank’ı :" + frank * a);
    Console.WriteLine("Alman Mark’ı :" + mark * a);
    Console.WriteLine("Japon Yen’i :" + Yen * a);
}
static void Cevap3()
{
    Console.Write("Celsius degeri girin :");
    double Celsius = Convert.ToDouble(Console.ReadLine());
    double Fahrenheit = Celsius * 9 / 5 + 32;//ilyas Bozdemir
    Console.WriteLine("Fahrenheit değeri :" + Fahrenheit);
}
static void Cevap4()
{
    Console.Write("Eski sistem pence değerini girin :");  //ilyas Bozdemir
    double pence = Convert.ToDouble(Console.ReadLine());
    Console.Write("Eski sistem shilling değerini girin :");
    double shilling = Convert.ToDouble(Console.ReadLine());
    Console.Write("Eski sistem pound değerini girin :");  //ilyas Bozdemir
    double pound = Convert.ToDouble(Console.ReadLine());
    double new_pence = (shilling * 12 + pence) * 5 / 12;
    Console.WriteLine("Yeni para birimine göre {0}", new_pence);
}
static void Cevap5()
{
    Console.Write("Yeni  sistem pence değerini girin :");  //ilyas Bozdemir
    double pence = Convert.ToDouble(Console.ReadLine());
    Console.Write("Yeni  sistem pound değerini girin :");
    double pound = Convert.ToDouble(Console.ReadLine());
    double shilling = (pence * 12 / 5) / 12;//ilyas Bozdemir
    Console.Write("Eski para birimine göre £{0}.{1}:", pound, shilling);
}
static void Cevap6()
{
    /* Bir ürün için klavyeden girilen fiyat ve kdv değerlerine
                 göre ürünün kdv’li fiyatını bulan programı yazınız.*/
    Console.Write("Fiyat giriniz :");
    double fiyat = Convert.ToDouble(Console.ReadLine());
    double kdvli = fiyat + (fiyat * 0.18);
    Console.Write("Kdvli fiyat :" + kdvli);//ilyas Bozdemir
}
static void Cevap7()
{
tekrar:
    Console.Write("Saat :" + " ");
    int Saat = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dakika :" + " ");
    int Dakika = Convert.ToInt32(Console.ReadLine());
    Console.Write("Saniye :");
    int Saniye = Convert.ToInt32(Console.ReadLine());
    if (Saniye > 60)//ilyas Bozdemir
    {
        Console.WriteLine("Saniye 60'dan yukarı olmaz \n tekrar deneyin");
        goto tekrar;
    }
    Console.WriteLine("Saat/Dakika/Saniye :" + Saat + ":" + Dakika + ":" + Saniye);//ilyas Bozdemir
    int toplam = (Saat * 3600) + (Dakika * 60) + Saniye;
    Console.Write("Toplam Süre :" + toplam);
}
static void Cevap8()
{
    int saat, dakika, saniye, sure;
    Console.Write("Süre Giriniz :");//ilyas Bozdemir
    sure = Convert.ToInt32(Console.ReadLine());
    saat = sure / 3600;
    dakika = (sure - (saat * 3600)) / 60;
    saniye = sure - (saat * 3600) - (dakika * 60);//ilyas Bozdemir
    Console.WriteLine("Saat/Dakika/Saniye" + saat + ":" + dakika + ":" + saniye);
}
static void Cevap9()
{
    double a, b, c;
    //Kullanıcıdan iki adet kesirli sayı girmesini isteyen ve bu
    //sayıların toplamını kesirli biçimde görüntüleyen bir program yazın.
    //not :paydaları eşit olacak.
    Console.WriteLine("a/c + b/c seklinde olacak sekilde kesirli sayı girin");
    Console.Write("a sayısını girin :");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b sayısını girin :");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c sayısını girin :");
    c = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
    double sonuc = (a / c) + (b / c);
    Console.WriteLine("sonuc :" + a + "/" + c + "+" + b + "/" + c);
    Console.WriteLine("sadeleştirmeyi görmek için herhangi bir tusa basın...");
    Console.ReadLine();
    Console.WriteLine("sadeleştirme :" + (a + b) + "/" + c);//ilyas Bozdemir
    Console.ReadLine();
    Console.WriteLine("sonucu  görmek için herhangi bir tusa basın...");
    Console.WriteLine("sonuc :" + (a + b) / c);
}
static void Cevap10()
{
    /* Kullanıcıdan iki adet kesirli sayı girmesini isteyen  ve bu 
              sayıların toplamını kesirli biçimde görüntüleyen bir program yazın.*/
    //not:10.	Eğer Paydaları eşit olmayan iki adet kesirli sayı olcak.
    double a, b, c, d;
    Console.WriteLine("a/b + c/d şeklinde sırasıyla değer girin ");
    Console.Write("a değerini girin :");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b değerini girin :");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c değerini girin :");
    c = Convert.ToDouble(Console.ReadLine());
    Console.Write("d değerini girin :");
    d = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
    Console.WriteLine();
    Console.WriteLine("kesirli hali :" + a + "/" + b + " " + "+" + " " + c + "*" + d);
    Console.WriteLine("Sonuc için Enter'a tusa basın...");
    Console.ReadLine();
    double sonuc = ((a * d) + (b * c)) / (b * d);//ilyas Bozdemir
    Console.WriteLine("sonuc :" + sonuc);
}