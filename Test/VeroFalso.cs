using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class VeroFalso : Domanda
    {
        public VeroFalso(List<Componente> risposte, string testo)
        {
            this.risposte = risposte;
            Testo = testo;
        }
        public override string ToString(object obj)
        {
            string risp = "";
            for (int i = 0; i < risposte.Count; i++)
            {
                risp += risposte[i].Testo + "; ";
            }
            return Testo + "\nRisposta: " + risp;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as VeroFalso);
        }

        public bool Equals(VeroFalso other)
        {
            bool uguale = true;
            if(risposte.Count == other.risposte.Count)
            {
                for (int i = 0; i < risposte.Count; i++)
                {
                    if (!(risposte[i].Testo == other.risposte[i].Testo))
                    {
                        uguale = false;
                    }
                }
            }
            else
            {
                uguale = false;
            }
            

            return other != null &&
                   uguale &&
                   Testo == other.Testo;
        }

        public override int GetHashCode()
        {
            return risposte.GetHashCode() + Testo.GetHashCode();
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
