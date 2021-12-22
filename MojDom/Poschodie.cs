using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojDom
{
    public class Poschodie
    {
        public int i_poschodia = 0;
        public string s_nazov = "";
        public Izba v_izba1 = null;
        public Izba v_izba2 = null;

        public Poschodie(int poschodia, string nazov)
        {
            i_poschodia = poschodia;
            s_nazov = nazov;
        }
    }
}
