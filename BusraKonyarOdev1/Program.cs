////1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız

//Console.Write("Sipariş numarasını giriniz: ");
//int orderNumber = Convert.ToInt32(Console.ReadLine());


//switch (orderNumber)
//{
//    case 1:
//        Console.WriteLine("Kahve");
//        break;
//    case 2:
//        Console.WriteLine("Çay");
//        break;
//    case 3:
//        Console.WriteLine("Süt");
//        break;
//    case 4:
//        Console.WriteLine("Portakal Suyu");
//        break;
//    case 5:
//        Console.WriteLine("Soda");
//        break;

//}









////2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız)


//Console.Write("Kaç ürün almak istediğinizi giriniz: ");
//int pruductQuantitiy = Convert.ToInt32(Console.ReadLine());
//int totalAmount = 0;

//for (int i = 0; i < pruductQuantitiy; i++)
//{
//    Console.Write((i+1)+". Ürünün fiyatını giriniz: ");
//    int pruductPrice = Convert.ToInt32(Console.ReadLine());
//    totalAmount += pruductPrice;
//}

//Console.WriteLine("Toplam alışveriş tutarı: "+ totalAmount.ToString());










////3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.


//Do-While döngüsü bir kod bloğunu döngüye girmeden önce en azından bir kere çalıştırmanıza olanak verir. Koşul do bloğunun sonunda kontrol edilir. Böylece kod bloğu en azından bir kere çalıştırılacaktır. Eğer koşul doğru ise, bloğuna başına sıçrayarak bloğu tekrardan çalıştıracaktır. Bir do..while döngüsü while döngüsüne oldukça benzer bir yapıdır. Aralarındaki ufak fark ise, do..while döngüsünün kod bloğunun en azından bir kere çalıştıracağının garantisini vermesidir. While döngüsü şunu söylerken: “Koşul doğru ise, kod bloğunu çalıştır“, do..while döngüsü şunu söyler: “Kod bloğunu çalıştır, koşul doğru ise döngüye devam et“.


//{
//    string kullanicidanAlinanSayi;
//    bool sayiMi;
//    int sayiDonen;
//    do
//    {
//        Console.WriteLine("bir sayı giriniz");
//        kullanicidanAlinanSayi = Console.ReadLine();
//        sayiMi = int.TryParse(kullanicidanAlinanSayi, out sayiDonen);

//    } while (sayiMi == false);

//    Console.WriteLine("girdiğiniz sayı: " + sayiDonen);

//}



//While döngüsünde koşul kısmına yazılan ifadeler doğru olduğu sürece işlemler gerçekleşir.Döngü çalışmaya başlar.Örneğin girilen sayının kaç basamaklı olduğunu söyleyen programın algoritması bulurken while döngüsü kullanalım. Burada sayı 9 dan büyük olduğu sürece while döngüsüne girecek ve bölünme sonucu elde edilen sayı yine 9 dan büyük olursa tekrarlanacak.Her tekrarda sayaç çalışacak ve sayının kaç basamaklı olduğunu bize söyleyecek.


//Console.WriteLine("bir sayıyı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int count = 1;
//while (sayi > 9)
//{
//    sayi = sayi / 10;
//    count++;
//}
//Console.WriteLine(count);










////4-Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)


//Random random = new Random();
//int rastgeleSayi = random.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı üret

//Console.Write("1 ile 10 arasında bir sayı tahmin edin.");

//int tahmin;
//bool dogruTahmin = false;
//while (!dogruTahmin)
//{
//    Console.Write("Tahmininiz: ");
//    tahmin = Convert.ToInt32(Console.ReadLine());

//    if (tahmin < rastgeleSayi)
//    {
//        Console.WriteLine("Daha büyük bir sayı girin.");
//    }
//    else if (tahmin > rastgeleSayi)
//    {
//        Console.WriteLine("Daha küçük bir sayı girin.");
//    }
//    else
//    {
//        dogruTahmin = true;
//    }
//}

//Console.WriteLine("Tebrikler! Doğru sayıyı buldunuz.");










////5- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.Mükemmel sayı bölenleri toplamı kendine eşit olan sayıdır. 6,28... gibi sayılar.

//Console.Write("Bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;
//for (int i = 1; i < sayi; i++)
//{
//    if (sayi % i == 0)
//    {
//        toplam = toplam + i;
//    }
//}
//if (toplam == sayi)
//{
//    Console.WriteLine(sayi+ " mükemmel sayıdır.");
//}
//else
//{
//    Console.WriteLine(sayi+ " mükemmel sayı değildir.");
//}








////string metotlar

//string text = "Hello, World!";

////1.Length: Bir dizginin karakter sayısını alır.
//int length = text.Length; // length = 13

////2.IndexOf: Belirli bir karakterin veya alt dizginin ilk indeksini döndürür.Yani world kelimesi 7. indexten başlar.
//int index = text.IndexOf("World"); // index = 7

////3.Substring: Belirtilen başlangıç indeksinden başlayarak bir alt dizgi döndürür.
//string subString = text.Substring(7); // subString = "World!"

////4.ToUpper:Dizginin tüm karakterlerini büyük harfe dönüştürür.
//string upperCase = text.ToUpper(); // upperCase = "HELLO, WORLD!"

////5.ToLower:Dizginin tüm karakterlerini küçük harfe dönüştürür.
//string lowerCase = text.ToLower(); // lowerCase = "hello, world!"

////6.Replace: Belirli bir karakter veya alt diziyle eşleşen tüm karakterleri başka bir karakter veya alt diziyle değiştirir.
//string replacedText = text.Replace("Hello", "Merhaba"); // replacedText = "Merhaba, World!"

////7.Split: Belirli bir ayırıcıya göre diziye bölünmüş alt dizgileri içeren bir diziyi döndürür.
//string country = "Ankara,Adana,Malatya";
//string[] countiries = country.Split(','); // countiries = ["Ankara", "Adana", "Malatya"]

////8.Trim: Dizginin başındaki ve sonundaki boşlukları kaldırır.
//string trimmedText = text.Trim(); // trimmedText = "Hello, World!"

////9.Concat: İki veya daha fazla dizgiyi birleştirir.
//string firstName = "Büşra";
//string lastName = "Konyar";
//string fullName = string.Concat(firstName, " ", lastName); // fullName = "Büşra Konyar"

////10.Clone(): String değişkeni ile oluşturduğumuz içeriğin bir klonunu oluşturarak kopyasını çıkartır.
//string clonedText = (string)text.Clone(); //clonedText="Hello, World!"

////11.Contains(): Metot ile belirtilen karakter veya cümlenin string değişkeni içerisinde var olup olmama durumuna göre kontrol sağlar. Eğer varsa True yoksa False şeklinde geri döndürür.
//string  cText= "Hello";
//Console.WriteLine(text.Contains(cText));//true döner.

////12.Insert(): String değişkeni içerisinde ki metnin metot ile belirlenen pozisyonuna ekleme yapar.
//string cText2 = "Güzel";
//string insertedText = text.Insert(6, cText2);//insertedText=Hello,Güzel World!

////13.Remove(): String değişkeni içeresinde ki metin üzerinde silme işlemleri uygular. İki adet kullanım şekli vardır;
////1.Silinmesi istenen yerin başlangıç indeksi metotta belirtilir ve metinden başlangıç indeksinden sonra ki kısmı silinir.
//string removedText=text.Remove(5); //removedText=Hello

////2.Belli bir kısmın silinmesi istenme durumunda başlangıç indeksi ve nereye kadarlık kısmın silineceği metotta belirtilir bu sayede belirtilen değer kadar silme yapılmış olur.
//string removedText2 = text.Remove(5,2); //removedText2=HelloWorld!

////14.PadRight(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin sağına ekleme işlemi yapar.Yani textimiz 13 karakterliydi 15 karakter olana kadar sağına istediğimiz * işaretini ekledi.
//string newText = text.PadRight(15, '*'); //"Hello, World!**"


////15.PadLeft(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin soluna ekleme işlemi yapar.Yani textimiz 13 karakterliydi 15 karakter olana kadar soluna istediğimiz * işaretini ekledi.
//string newText2 = text.PadLeft(15, '*');//"**Hello, World!"









////7.kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)

Console.Write("Sınıftaki öğrenci sayısını girin: ");
int totalStudent = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < totalStudent; i++)
{
    Console.Write("Öğrenci adını girin: ");
    string firstName = Console.ReadLine();

    Console.Write("Öğrenci soyadını girin: ");
    string lastName = Console.ReadLine();

    Console.Write("Sınav 1. notunu girin: ");
    int grade1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sınav 2. notunu girin: ");
    int grade2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sınav 3. notunu girin: ");
    int grade3 = Convert.ToInt32(Console.ReadLine());

    double avarage = (grade1 + grade2+grade3) / 3;

    Console.WriteLine("Öğrenci:" + firstName + " " + lastName);
    Console.WriteLine("Not ortalaması:" + avarage);
    Console.WriteLine("-----------------");
}


