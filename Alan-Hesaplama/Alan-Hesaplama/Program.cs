
void AlanHesaplama()
{
    Console.WriteLine(" Şekil {1}: Daire\n Şekil {2}: Üçgen\n Şekil {3}: Dikdörtgen\n Şekil {4}: Kare");
    Console.Write("Lütfen Hesaplamak istediğiniz şeklin kodunu giriniz: ");
    string sekil = Console.ReadLine();
    int a, b = 0;
    switch (sekil)
    {
        case "1":
            Console.Write("Lütfen Dairenin Alanını Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Alanı: " + a * 3.14);
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Hacmi: " + (a * 2) * 3.14);
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Çevresi : " + (a * 3.14) * 2);
            break;
        case "2":
            Console.Write("Lütfen Üçgenin Tabanını Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Üçgenin Yüksekliğini Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Değerlere Göre Alan Hesabı: " + (a * b) / 2);
            Console.WriteLine("Girdiğiniz Değere Göre Üçgenin Hacmi: " + Math.Pow(a, b));
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Çevresi: " + a + b + b);

            break;
        case "3":
            Console.Write("Lütfen Dikdörtgenin Tabanını Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Dikdörtgenin Yüksekliğini Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Değerlere Göre Dikdörtgenin Alanı: " + a * b);
            Console.WriteLine("Girdiğiniz Değere Göre Dikdörtgen Hacmi: " + a * b * b);
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Çevresi: " + (a + b) * 2);
            break;
        case "4":
            Console.Write("Lütfen Karenin Alanını Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Karenin Yüksekliğini Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Değere Göre Karenin Alanı: " + a * a);
            Console.WriteLine("Girdiğiniz Değere Göre Karenin Hacmi: " + (a * a) *b );
            Console.WriteLine("Girdiğiniz Değere Göre Dairenin Çevresi: " + a * 4);

            break;

    }

}

void ikiliyazdir()
{
    Console.Write("Lütfen Kaç değer girmek istediğinizi belirtin: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    bool deger = false;
    int[] sayilar = new int[a];

    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.Write("Lütfen Değerleri Giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < sayilar.Length; i++)
    {
        toplam += sayilar[i];
        for (int j = i + 1; j < sayilar.Length; j++)
        {
            if (sayilar[i] == sayilar[j])
            {
                deger = true;
                break; 
            }
        }
    }

    if (deger)
    {
        Console.WriteLine(toplam * toplam);
    }
    else
    {

        Console.WriteLine(toplam);
    }


}

void MutlakKareAl()
{
    Console.Write("Kaç adet sayı gireceksiniz? ");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Sayı {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 67)
        {
            a += (67 - num);
        }
        else
        {
            b += (int)Math.Pow((num - 67), 2);
        }
    }

    Console.WriteLine($"Küçük olanların farklarının toplamı: {a}");
    Console.WriteLine($"Büyük olanların farklarının mutlak kareleri toplamı: {b}");
}

void karakterdegistirme()
{
    string kelime = "Merhaba Hello Algoritma x";
    string[] kelimeler = kelime.Split(" ");

    foreach (string item in kelimeler)
    {
        char ilkharf = item[0];
        string yeniKelime = item.Substring(1) + ilkharf;
        Console.Write(yeniKelime + " ");

    }
}

static void SessizHarf()
{
    Console.Write("Lütfen bir cümle giriniz: ");
    string cumle = Console.ReadLine();

    string[] kelimeler = cumle.Split(' ');

    foreach (string kelime in kelimeler)
    {
        if (Kontrol(kelime) || kontrol_2(kelime))
        {
            Console.Write("True ");
        }
        else
        {
            Console.Write("False ");
        }
    }
}

static bool Kontrol(string word)
{
    for (int i = 0; i < word.Length - 1; i++)
    {
        if (seslihafler(word[i]) && seslihafler(word[i + 1]))
        {
            return true;
        }
    }
    return false;
}

static bool kontrol_2(string word)
{
    for (int i = 0; i < word.Length - 1; i++)
    {
        if (!seslihafler(word[i]) && !seslihafler(word[i + 1]))
        {
            return true;
        }
    }
    return false;
}

static bool seslihafler(char c)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    return Array.IndexOf(vowels, c) != -1;
}


AlanHesaplama();
ikiliyazdir();
MutlakKareAl();
karakterdegistirme();
SessizHarf();