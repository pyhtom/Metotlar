using System;

namespace Metotlar
{
    class SepetManager : SepetManagerBase
    {
        public void Ekle(Urun urun)
            mConsole.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);
        public void Ekle2(Urun urun)
        {

            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);

        }
    }
}
