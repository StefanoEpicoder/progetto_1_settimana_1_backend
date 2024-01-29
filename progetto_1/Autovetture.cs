using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_1
{
    public class Autovetture
    {
        private string _marca;

        public string Marca
        {
            get// accede alla proprità
            {
                return _marca;
            }
            set// per settare il valore di una proprità privata
            {
                _marca = value;
            }
        }
        public string kmTagliando(int attuale)
        {
            if(attuale > 10000)
            {
                return "tagliando da effettuare";
            }
            else
            {
                return "puoi risparmiare, per ora";
            }
        }
    }

}
