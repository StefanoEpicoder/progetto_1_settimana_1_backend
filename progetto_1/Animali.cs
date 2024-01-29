using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_1
{
    public class Animali
    {
        private string _specie;

        public string Specie
        {
            get
            {
                return _specie;
            }
            set
            {
                _specie = value;
            }
        }
        public string profondità(int deep)
        {
            if(deep >1000)
            {
                return " è un pesce abissale";
            }
            else
            {
                return " non è un pesce abissale";
            }
        }
    }
}
