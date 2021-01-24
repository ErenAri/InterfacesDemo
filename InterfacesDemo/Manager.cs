using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat metodu uygulandı");
        }

        public void Salary()
        {
            Console.WriteLine("Manager Salary metodu uygulandı");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work metodu uygulandı");
        }
    }
}
