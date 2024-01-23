using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    internal class Singola : Domanda
    {
        public Singola(Componente risposta, string testo)
        {
            risposte.Add(risposta);
            Testo = testo;
        }

        public override string ToString(object obj)
        {
            return Testo + "\nRisposta: " + risposte[0].Testo;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Singola);
        }

        public bool Equals(Singola other)
        {
            bool uguale = true;
            if (risposte.Count == other.risposte.Count)
            {
                if (!(risposte[0].Testo == other.risposte[0].Testo))
                {
                    uguale = false;
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
            if (risposte[0].Testo == risposteUtente[0].Testo)
            {
                punteggio = risposte[0].Punteggio(risposteUtente);
            }

            return punteggio;
        }
    }
}
