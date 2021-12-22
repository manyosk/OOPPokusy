using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojDom
{
    public class Izba
    {
        float f_sirka = 0.0f;
        float f_dlzka = 0.0f;
        float f_vyska = 0.0f;
        public string s_meno = "";
        public string s_popis = "";

        public Izba(float sirka, float dlzka, float vyska)
        {
            f_sirka = sirka;
            f_dlzka = dlzka;
            f_vyska = vyska;
        }

        public Izba(string meno, string popis, float sirka, float dlzka, float vyska)
        {
            s_meno = meno;
            s_popis = popis;
            f_sirka = sirka;
            f_dlzka = dlzka;
        }

        public float Rozloha()
        {
            float m2 = f_sirka * f_dlzka;
            return m2;
        }
    }
}
