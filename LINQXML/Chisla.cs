using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQXML
{
    class Chisla
    {
        public int[] Chislo;
        public Chisla(string chislo)
        {
            int i = 0;
            Chislo = new int[chislo.Split(' ').Length];
            while (i < chislo.Split(' ').Length)
            {
                var items = chislo.Split(' ');
                Chislo[i] = int.Parse(items[i]);
                i++;
            }
        }
    }
}
