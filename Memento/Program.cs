using System;

namespace RPPOON_LV6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Toni", "Pulska", 54513);
            Memento memento1 = account1.StoreState();

            account1.ChangeOwner("Ena");
            Memento memento2 = account1.StoreState();

            CareTaker careTaker = new CareTaker();

            careTaker.AddMemento(memento1);
            careTaker.AddMemento(memento2);

            careTaker.ShowMementos();

        }
    }
}
