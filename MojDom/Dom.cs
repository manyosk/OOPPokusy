using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojDom
{
    public class Dom
    {
        string s_mesto = "";
        string s_ulica = "";
        int i_cislo = 0;
        public string s_id = "";
        public Poschodie v_poschodie1 = null;
        public Poschodie v_poschodie2 = null;

        public Dom(string mesto, string ulica, int cislo, string id)
        {
            s_mesto = mesto;
            s_ulica = ulica;
            i_cislo = cislo;
            s_id = id;
        }

        public void VypisDom()
        {
            Console.WriteLine("Dom:" + s_id);
            Console.WriteLine("Prve poschodie: " + v_poschodie1.s_nazov);
            Console.WriteLine(v_poschodie1.v_izba1.s_meno + ": " + v_poschodie1.v_izba1.Rozloha() + "m2");
            Console.WriteLine(v_poschodie1.v_izba2.s_meno + ": " + v_poschodie1.v_izba2.Rozloha() + "m2");
            Console.WriteLine("Druhe poschodie: " + v_poschodie2.s_nazov);
            Console.WriteLine(v_poschodie2.v_izba1.s_meno + ": " + v_poschodie2.v_izba1.Rozloha() + "m2");
            Console.WriteLine(v_poschodie2.v_izba2.s_meno + ": " + v_poschodie2.v_izba2.Rozloha() + "m2");

        }
    }
}
