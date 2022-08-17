public class Program
{
    struct PratikVKI
    {
        public double kilogram;
        public double boy;
        public double vki;
        public string teshis;
        public string hastaAdı;

        public double VKISonuc()
        {
            return (kilogram / (boy * boy));

        }
        public void EkranaYaz()
        {
            Console.WriteLine($"kilogram: {kilogram}");
            Console.WriteLine($"boy: {boy}");
            Console.WriteLine($"vki : {vki}");
            Console.WriteLine($"teşhis : {teshis}");
            Console.WriteLine($"VKISonuc : %{VKISonuc()}");
            Console.WriteLine($"hastaAdı: {hastaAdı}");
        }
    }


    static List<PratikVKI> pratik = new List<PratikVKI>();

    public static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("1.Yeni Hasta\n2.Hasta Listesi\n3.Çıkış");

        MenuSelection();

    }

    static void MenuSelection()
    {
        Console.Write("Yapmak istediğiniz İşlemi Seçiniz: ");
        string secim = Console.ReadLine();
        switch (secim)
        {
            case "1":
                YeniHasta();
                break;
            case "2":
                HastaListesi();
                break;
            case "3":
                Environment.Exit(0);
                break;
        }
    }

    static void HastaListesi()
    {
        foreach (var vki in pratik)
        {
            vki.EkranaYaz();
        }
        Again();
    }

    static void YeniHasta()
    {

        PratikVKI a = new();
        Console.Write("Adınız: ");
        a.hastaAdı = Console.ReadLine();
        Console.Write("Kilonuz: ");
        a.kilogram = Convert.ToDouble(Console.ReadLine());
        Console.Write("Boyunuzu metre cinsinden giriniz: ");
        a.boy = Convert.ToDouble(Console.ReadLine());
        a.vki = a.VKISonuc();
        Console.WriteLine($"VKISonuc : %{a.vki}");


        if (a.vki < 18.49)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            a.teshis = "Teşhis : Zayıf";
            Console.WriteLine(a.teshis);
        }
        else if (a.vki > 18.49 && a.vki < 24.99)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            a.teshis = "Teşhis: Normal";
            Console.WriteLine(a.teshis);
        }
        else if (a.vki > 25 && a.vki < 29.99)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            a.teshis = "Teşhis: Hafif Kilolu";
            Console.WriteLine(a.teshis);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            a.teshis = "Teşhis : Obez";
            Console.WriteLine(a.teshis);
        }
        Console.ForegroundColor = ConsoleColor.White;

        pratik.Add(a);
        Again();
    }

    static void Again()
    {

        Console.WriteLine("Menüye dönmek için Enter tuşuna, çıkmak için ise herhangi bir tuşa basınız.");
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Menu();
        }
        else
        {
            Environment.Exit(0);

        }


    }
}