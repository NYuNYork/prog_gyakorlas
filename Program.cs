namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat2();
            //Feladat4();
            Feladat5();
        }

        private static void Feladat5()
        {
            Console.Write("Add meg az A értékét");
            string KockaStr = Console.ReadLine();
            int Kocka = Int32.Parse(KockaStr);
        }

        //private static void Feladat4()
        //{
        //    Random rnd = new Random();

        //    int kocka1 = 0;
        //    int kocka2 = 0;
        //    int Osszeg = 0;
        //    int db11fel = 0;
        //    for (int i = 0; i < 6; i++)
        //    {
        //        kocka1 = rnd.Next(1, 9); 
        //        kocka2 = rnd.Next(1, 9);
        //        Osszeg = kocka1 + kocka2;
        //        Console.WriteLine($"{i+1}. kocka1:{kocka1} kocka2:{kocka2}");
        //        if (Osszeg >= 11)
        //        {
        //            db11fel += 1;
        //        }
        //    }
        //    Console.WriteLine($"11 feletti összeg ennyiszer: {db11fel}");
        //}

        //private static void Feladat2()
        //{
        //    Console.WriteLine("Héron képlet");
        //    Console.Write("Kérem adja meg az a oldalt");
        //    double Aoldal = double.Parse(Console.ReadLine());
        //    Console.Write("kérem adja meg a b oldalt");
        //    double Boldal = double.Parse(Console.ReadLine());
        //    Console.Write("kérem adja meg a c oldalt");
        //    double Coldal = double.Parse(Console.ReadLine());
        //    if(Aoldal + Boldal > Coldal &&
        //        Aoldal + Coldal > Boldal &&
        //        Boldal + Coldal > Aoldal)
        //    {
        //        double Kerulet = Aoldal + Boldal + Coldal;
        //        double S_ertek = Kerulet / 2;
        //        double Terulet = Math.Sqrt(S_ertek *
        //            (S_ertek - Aoldal) *
        //            (S_ertek - Boldal) *
        //            (S_ertek - Coldal));
        //        Console.WriteLine($"A háromszög területe: {Terulet:0.00} egység^2");
        //    }
        //    else
        //    {
        //        Console.WriteLine("nincs ilyen háromszög");
        //    }
        //}
        //private static void Feladat1()
        //{
        //    int Szam;
        //    for (int i = 1000; i <=9999; i++)
        //    {
        //        Szam = i;
        //        if (Szam%8 == 0)
        //        {
        //            if (i%5 == 0)
        //            {
        //                Console.WriteLine("\n");
        //            }
        //            Console.WriteLine($" {Szam} , ");
        //            if (Szam%9==0)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //            }
        //        }
        //    }
        //}
    }
}