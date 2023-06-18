using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMGuideTech
{
    internal class Generic
    {
        static void Main(string[] args)
        {
            GenericList<Animal> listOfAnimals = new GenericList<Animal>();
            GenericList<double> listOfNumbers = new GenericList<double>();
            listOfNumbers.DoSomething(2.5);
            listOfAnimals.DoSomething(new Animal());
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public List<string> Habitats { get; set; }
    }

    public class GenericList<T>
    {
        public void DoSomething(T obj)
        {
            Console.WriteLine("Foo Generic");
        }
    }
}