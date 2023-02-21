using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hakim1 = 2500, hakim2 = 3300, juri = 50, tplmjurifiyati ,sayi, sum1, sum2, sum3, sum4, sum5; 
            Random rnd = new random(1,20);//maksimum 20 jüri katılacak gibi düşünerek ilerledim
            sayi = rnd.Next(1,20);
            tplmjurifiyati = juri * sayi;//toplamda jüriye ödenmesi gereken para
            sum1 = hakim1;
            sum2 = hakim2; 
            sum3 = (hakim1 / 2) + (tplmjurifiyati / 2);
            sum4 = (hakim2 / 2) + (tplmjurifiyati / 2);
            sum5 = tplmjurifiyati;
            int[] dizi = new int[5];
            dizi[0] = sum1;
            dizi[1] = sum2;
            dizi[2] = sum3;
            dizi[3] = sum4;
            dizi[4] = sum5;
            int Kucuksayi=dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            { 
            Kucuksayi = dizi[0];
            if (dizi[i] < Kucuksayi)
            {
                Kucuksayi = dizi[i];
            }
        }
            Console.WriteLine(Kucuksayi);
            Console.ReadLine();
        }
    }
}
