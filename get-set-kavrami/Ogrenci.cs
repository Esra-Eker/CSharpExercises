using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set_kavrami
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string ADI
        {
            get { return ad; }  //klavyeden girilecek olan ad değerini döndür (karşıma çıkar) demek.
            set { ad = value; } //klavyeden girilen value değeri benim ad ım olacak.
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string ALANI
        {
            get { return alan; }
            set { alan = value; }
        }
        public int YASI
        {
            get { return yas; }
            set                  
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;   //yaşı 18den büyük olanlarda değeri yas a aktar ama 18den küçük olanlarda yas a hep 18 değerini yaz. 
                }
            }

        }
    }
}
