using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Risposta : Componente
    {
        private int _peso;
        public int Peso
        {
            get { return _peso; }
            set { if (value > 0) { _peso = value; } else { _peso = 0; } }
        }

        public Risposta(int peso, string testo)
        {
            Peso = peso;
            Testo = testo;
        }

        public override void Add(object obj)
        {
            throw new NotImplementedException();
        }
        public override object GetChild(int index)
        {
            throw new NotImplementedException();
        }
        public override void Remove(int index)
        {
            throw new NotImplementedException();
        }


        public override string ToString(object obj)
        {
            return "\nRisposta: " + Testo;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as VeroFalso);
        }

        public bool Equals(VeroFalso other)
        {

            return other != null && Testo == other.Testo;
        }

        public override int GetHashCode()
        {
            return Testo.GetHashCode();
        }
        public override int Punteggio(List<Componente> risposteUtente = null)
        {
            return Peso;
        }
    }
}
