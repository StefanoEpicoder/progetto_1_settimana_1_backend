using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_1
{
    public class Atleta
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string etaAnagrafica(int attuale)
        {
            if(attuale > 35)
            {
                return " prossimo al ritiro";
            }
            else
            {
                return " può giocare serenamente";
            }
        }
    }
}
