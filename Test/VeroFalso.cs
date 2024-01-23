using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class VeroFalso : Domanda
    {
        public override string ToString(object obj)
        {
            return Testo + "\nRisposta: " + risposte[0].Testo;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as VeroFalso);
        }

        public bool Equals(VeroFalso other)
        {
            return other != null &&
                   risposte[0].Testo == other.risposte[0].Testo &&
                   Testo == other.Testo;
        }

        public override int GetHashCode()
        {
            return risposte.GetHashCode();
        }
        public override int Punteggio(List<Componente> risposteUtente)
        {
            int punteggio = 0;
            for(int i=0; i<risposte.Count; i++)
            {
                if (risposte[i].Testo == risposteUtente[i].Testo)
                {
                    punteggio++;
                }
            }

            return punteggio;
        }
    }
}
