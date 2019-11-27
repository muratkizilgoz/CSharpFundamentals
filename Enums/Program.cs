using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var siparisDurumu = SiparisDurumu.SiparisTamamlandi;
            Console.WriteLine((int)siparisDurumu);
            Console.WriteLine(siparisDurumu.ToString());
            Console.WriteLine(siparisDurumu);

            var siparisDurumuId = 1;
            Console.WriteLine((SiparisDurumu)siparisDurumuId);

            var siparisDurumuAdi = "SiparisTamamlandi";
            Console.WriteLine(Enum.Parse(typeof(SiparisDurumu), siparisDurumuAdi));


        }
    }
}
