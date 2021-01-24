using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat metodu uygulandı");
        }

        public void Salary()
        {
            Console.WriteLine("Worker Salary metodu uygulandı");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work metodu uygulandı");
        }
    }
}
