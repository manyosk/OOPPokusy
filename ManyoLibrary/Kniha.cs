using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyoLibrary
{
    public class Kniha
    {
        private string _sNazov = "";
        private int _iRokVydania = 0;
        public SkrinaNaKnihy _cSkrina = null;

        public string SNazov 
        { 
            get => _sNazov; 
            set => _sNazov = value + "pokus";
        }

        public Kniha(string meno, int rok) //konstructor
        {
            Init();
            SNazov = meno;
            _iRokVydania = rok;
        }

        public Kniha(string meno, int rok, SkrinaNaKnihy skrina) //konstructor
        {
            Init();
            SNazov = meno;
            _iRokVydania = rok;
            _cSkrina = skrina;
        }

        void Init()
        {
            SNazov = "";
            _iRokVydania = 0;
        }

        public int VekKnihy()
        {
            return DateTime.Now.Year - _iRokVydania;
        }
    }
}
