using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyoLibrary
{
    public class Kniha
    {
        private string nazov = "";
        private int _rokVydania = 0;
        public SkrinaNaKnihy _skrina = null;
        public int _zanerKnihy;

        public string Nazov { get => nazov; set => nazov = value; }

        public SkrinaNaKnihy GetSkrina()
        {
            return _skrina;
        }

        public void SetSkrina(SkrinaNaKnihy skrina)
        {
            _skrina = skrina;
        }

        public Kniha(string meno, int rok) //konstructor
        {
            Init();
            Nazov = meno;
            _rokVydania = rok;
            _zanerKnihy = ((int)Codes.ZanerKnihy.Detske);

        }

        public Kniha(string meno, int rok, SkrinaNaKnihy skrina) //konstructor
        {
            Init();
            Nazov = meno;
            _rokVydania = rok;
            SetSkrina(skrina);
        }

        void Init()
        {
            Nazov = "";
            _rokVydania = 0;
        }

        public int VekKnihy()
        {
            return DateTime.Now.Year - _rokVydania;
        }
    }
}
