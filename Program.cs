namespace TekCift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç değeri giriniz.");
            int basdeger = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş değeri giriniz.");
            int bitdeger = int.Parse(Console.ReadLine());
            Console.WriteLine("Tek/Çift");
            string tekcift = Console.ReadLine().ToLower();
            int toplam = 0;

            if (basdeger > bitdeger)
            {
                int temp = bitdeger;
                bitdeger = basdeger;
                basdeger = temp;
            }

            for (int i = basdeger; i <= bitdeger; i++)
            {
                if (tekcift == "tek" && i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                    toplam += i;
                }
                else if (tekcift == "çift" && i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                    toplam += i;
                }
            }

            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}
