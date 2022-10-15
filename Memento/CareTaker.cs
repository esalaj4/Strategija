using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6_4
{
    class CareTaker
    {
        private List<Memento> mementos;

        public CareTaker()
        {
            mementos = new List<Memento>();
        }

        public void AddMemento(Memento memento)
        {
            this.mementos.Add(memento);
        }

        public void RemoveMemento(Memento memento)
        {
            this.mementos.Remove(memento);
        }

        public void ShowMementos()
        {
            Console.WriteLine("Here is a list of mementos by owners name:");
            int i = 1;
            foreach (var memento in mementos)
            {
                Console.WriteLine($"{i}:");
                Console.WriteLine(memento.OwnerName);
                i++;
            }
        }
    }
}
