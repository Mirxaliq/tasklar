using System;

class Program
{
    static void Main()
    {
        #region Benzin Hesaplama
        Console.WriteLine("1-km ya gore islenen benzinin miqdari");
        int km = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qalan benzinin miqdari");
        int benzin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("getmey istediyiniz mesafeni yazin km");
        int mesafe = Convert.ToInt32(Console.ReadLine());
        int istifade = km * mesafe;

        if (istifade <= benzin)
        {
            Console.WriteLine("masin bu mesafeni gedecek");
        }
        else
        {
            Console.WriteLine("masin bu mesafeni gede bilmeyecek");
        }
        #endregion
        #region en boyuk eded
        Console.WriteLine("reqemleri daxil edin");
        int enboyuk = int.MinValue;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"reqem{i + 1}:");
            int reqem = Convert.ToInt32(Console.ReadLine());

            if (reqem > enboyuk)
            {
                enboyuk = reqem;
            }
        }

        Console.WriteLine($"En boyuk reqem: {enboyuk}");
        #endregion
        #region tek reqemlerin cemi
        Console.WriteLine("4 dene reqem daxil edin:");

        int cem = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Reqem {i + 1}: ");
            int reqem = Convert.ToInt32(Console.ReadLine());

            if (reqem % 2 != 0)
            {
                cem += reqem;
            }
        }

        Console.WriteLine("Tek reqemlerin cemi: " + cem);
        #endregion
        #region 2 ye bolunen reqemler
        Console.WriteLine("reqemleri daxil edin");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        int a = x % 2;
        int b = y % 2;
        int c = z % 2;
        int q = 3 - a - b - c;

        if (q == 3)
        {
            Console.WriteLine("Reqemlerin 3 de 2 ye bolunur");
        }
        if (q == 0)
        {
            Console.WriteLine("Reqemlerden hec birisi 2 ye bolunmur");
        }
        else
        {
            Console.WriteLine($"{q} reqem 2 ye bolunur");
        }
        #endregion
        #region son
        char ulduz = '*';
        Console.WriteLine("setirlerin sayini  yazın:");
        int u = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= u; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(ulduz);
            }
            Console.WriteLine();
        }
        #endregion
    }

}