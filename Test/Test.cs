using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test : Componente
    {
        public override void Add(object obj)
        {
            risposte.Add((obj as Componente));
        }
        public override object GetChild(int index)
        {
            return risposte[index];
        }
        public override void Remove(int index)
        {
            risposte.RemoveAt(index);
        }
        public override string ToString(object obj)
        {
            string risp = "";
            for (int i = 0; i < risposte.Count; i++)
            {
                risp += risposte.ToString() + "\n";
            }
            return Testo + "\n\nDomande: \n" + risp;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Test);
        }

        public bool Equals(Test other)
        {
            bool uguale = true;
            if (risposte.Count == other.risposte.Count)
            {
                for (int i = 0; i < risposte.Count; i++)
                {
                    if (!(risposte[i].Equals(other.risposte[i])))
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
            return risposte.GetHashCode();
        }

        public override int Punteggio(List<Componente> risposteUtente = null)
        {
            int punteggio = 0;
            for (int i = 0; i < risposte.Count; i++)
            {
                punteggio += risposte[i].Punteggio(risposteUtente);
            }

            return punteggio;
        }
    }
}
