using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal abstract class Domanda : Componente
    {
        public List<Componente> risposte;


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
        public abstract override string ToString(object obj);
        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();
        public abstract override int Punteggio(List<Componente> risposteUtente);
    }
}
