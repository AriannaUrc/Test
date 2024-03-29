﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal abstract class Componente
    {
        public List<Componente> risposte;

        private string _testo;
        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }
        public abstract void Add(object obj);
        public abstract object GetChild(int index);
        public abstract void Remove(int index);
        public abstract string ToString(object obj);
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
        public abstract int Punteggio(List<Componente> risposteUtente);
    }
}
