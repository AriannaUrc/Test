using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Domanda : Componente
    {
        List<Componente> risposte;
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
            return risposte.ToString();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return (ToString() == obj.ToString());
            }
        }

        public override int GetHashCode()
        {
            return risposte.GetHashCode();
        }
        public override int Punteggio()
        {
            return 0;
        }
    }
}
