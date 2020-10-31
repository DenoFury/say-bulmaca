using System;



namespace SayiBulmaca
{

    class Program
    {

        static void Main(String[] args)
        {
            Random r = new Random();

            int dogrusayi = r.Next(0, 100);


            bool kazanmak = false;

            do
            {
                Console.WriteLine("0 ve 100 arasındaki sayıyı bul");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < dogrusayi)
                {
                    Console.WriteLine("Çok alçak azcık yüksel .");
                }
                else if (sayi > dogrusayi)
                {
                    Console.WriteLine("Çok yüksek  alçalmayı dene");
                }
                else if (sayi == dogrusayi)
                {
                    Console.WriteLine("TEBRIKLER KAZANDIN!!");
                    kazanmak = true;
                }

                Console.WriteLine();
            } while (kazanmak == false);
            Console.WriteLine("Oynadığın için teşekkürler ");
            Console.WriteLine("Çıkmak için herhangi bir butona bas.");
            Console.ReadKey(true);
        }






    }
































}