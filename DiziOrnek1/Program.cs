//Tabii! Dizi(Array), birden fazla aynı türdeki veriyi tek bir değişken adı altında 
//tutmamıza olanak sağlayan bir veri yapısıdır. Diziler, belirli bir veri türündeki 
//öğelerin sıralı bir koleksiyonunu temsil eder.

//Dizi Tanımı:
//Dizi, bir türdeki çok sayıda öğeyi tutmak için kullanılan bir yapıdır.
//Diziler, sabit bir uzunluğa sahip olup, tek bir türdeki verileri depolar.
//Dizilerin indeksleri 0'dan başlar, yani ilk eleman indeks 0'dır.
//Bir Boyutlu Dizi Oluşturma:
//Bir boyutlu dizi, yalnızca tek bir sıradaki öğeleri tutar.

//Dizi Tanımlama:
//Bir diziyi tanımlamak için önce dizinin türünü, ardından uzunluğunu belirtiriz.

int[] sayilar;  // int türünde bir dizi tanımlandı, henüz boyut belirlenmedi
sayilar = new int[5];  // Diziye 5 elemanlık yer ayrıldı

//Burada int[] sayilar ifadesi, sayilar adlı bir dizi tanımlar ve new int[5] ifadesi, 
//bu dizinin 5 elemandan oluştuğunu belirtir.

//Dizinin elemanlarına, indeks numaraları kullanılarak değer atanabilir.


sayilar[0] = 10;  // İlk elemana 10 değerini atıyoruz
sayilar[1] = 20;  // İkinci elemana 20 değerini atıyoruz
sayilar[2] = 30;  // Üçüncü elemana 30 değerini atıyoruz
sayilar[3] = 40;  // Dördüncü elemana 40 değerini atıyoruz
sayilar[4] = 50;  // Beşinci elemana 50 değerini atıyoruz

//Bir Boyutlu Dizi Elemanlarına Erişim:
//Dizinin elemanlarına, dizinin indeks numaralarını kullanarak erişilebilir. 
//Unutmayın, dizilerde indeksler 0'dan başlar.


Console.WriteLine(sayilar[0]);  // 10 yazdırır
Console.WriteLine(sayilar[1]);  // 20 yazdırır
Console.WriteLine(sayilar[2]);  // 30 yazdırır
Console.WriteLine(sayilar[3]);  // 40 yazdırır
Console.WriteLine(sayilar[4]);  // 50 yazdırır

Console.ReadLine();