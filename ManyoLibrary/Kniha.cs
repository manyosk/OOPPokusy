using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyoLibrary
{
    public class Kniha
    {
        public string _sNazov = "";
        public int _iRokVydania = 0;
        public SkrinaNaKnihy _cSkrina = null;

        public Kniha(string meno, int rok) //konstructor
        {
            Init();
            _sNazov = meno;
            _iRokVydania = rok;
        }

        public Kniha(string meno, int rok, SkrinaNaKnihy skrina) //konstructor
        {
            Init();
            _sNazov = meno;
            _iRokVydania = rok;
            _cSkrina = skrina;
        }

        void Init()
        {
            _sNazov = "";
            _iRokVydania = 0;
        }

        public int VekKnihy()
        {
            return DateTime.Now.Year - _iRokVydania;
        }
    }
}
