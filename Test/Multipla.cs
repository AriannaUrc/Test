﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    internal class Multipla : Domanda
    {
        public Multipla(List<Componente> risposte, string testo)
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
            return Equals(obj as Multipla);
        }

        public bool Equals(Multipla other)
        {
            bool uguale = true;
            if (risposte.Count == other.risposte.Count)
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
            for (int i = 0; i < risposte.Count; i++)
            {
                for (int j = 0; j < risposteUtente.Count; j++)
                {
                    if (risposte[i].Testo == risposteUtente[j].Testo)
                    {
                        punteggio += risposte[i].Punteggio(risposteUtente);
                    }
                }
            }

            return punteggio;
        }
    }
}
