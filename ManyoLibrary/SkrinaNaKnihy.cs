using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyoLibrary
{
    public class SkrinaNaKnihy
    {
        public int _pocetPolic;
        public int _pocetKnihNaJednejPolici;
        float _sirka;
        float _vyska;

        public SkrinaNaKnihy(int pp, int aa)
        {
            Init();
            _pocetPolic = pp;
            _pocetKnihNaJednejPolici = aa;
        }

        private void Init()
        {
            _pocetPolic = 0;
            _pocetKnihNaJednejPolici = 0;
            _sirka = 0.0f;
            _vyska = 0.0f;
        }

        public int MaxPocetKnihVSkrini()
        {
            int pocet = _pocetPolic * _pocetKnihNaJednejPolici;

            return pocet;
        }

    }
}
