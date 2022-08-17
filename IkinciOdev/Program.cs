public class Program
{



    struct PratikVKI
    {
        public double kilogram;
        public double boy;
        public double vki;
        public string teshis;

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
        }
    }

    public static void Main()
    {
        Console.Clear();
        NewHesap();
    }

    static void NewHesap()
    {

        PratikVKI a = new();
        Console.Write("Kilonuzu Giriniz: ");
        a.kilogram = Convert.ToDouble(Console.ReadLine());
        Console.Write("Boyunuzu metre cinsinden giriniz: ");
        a.boy = Convert.ToDouble(Console.ReadLine());
        a.vki = a.VKISonuc();
        Console.WriteLine($"VKISonuc : %{a.vki}");

        if (a.vki < 18.49)
        {
            Console.WriteLine("Teşhis : Zayıf"); 
        }
        else if (a.vki > 18.49 && a.vki <24.99)
        {
            Console.WriteLine("Teşhis : İdeal");
        }
        else if (a.vki > 25 && a.vki <29.99)
        {
            Console.WriteLine("Teşhis : Hafif Kilolu");
        }
        else
        {
            Console.WriteLine("Teşhis : Obez");
        }
        YeniHesapIsterMisin();
    }

    static void YeniHesapIsterMisin()
    {

        Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunz? (E/H)");
        string cevap = Console.ReadLine().ToUpper();
        if (cevap == "E")
            NewHesap();
        else if (cevap =="H")
            Environment.Exit(0);
        else
        {
            Console.WriteLine("Hatalı Giriş Yaptınız.");
            YeniHesapIsterMisin();
        }
        

    }








}