using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program:Animal
    {
        static void Main(string[] args)
        {

            Animal Cat = new Animal();
            Console.WriteLine("Enter the name of the animal");
            Cat.setName(Console.ReadLine());
            Cat.setAge(2);
            Cat.setSex("boy");
            Cat.setType("Perusian");

            Console.WriteLine(Cat.getName() + " is " + Cat.getAge() + " years old and a " + Cat.getSex() + " of " + Cat.getType() + " breed");
        }
    }
}
//program version 2 below
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program:Animal
    {
        static void Main(string[] args)
        {

            Animal Cat = new Animal();

            Console.WriteLine("Enter the name of the animal");
            Cat.setName(Console.ReadLine());

            Console.WriteLine("Enter the age of the animal");
           // Cat.setAge(Console.ReadLine(int.TryParse()));

            Console.WriteLine("Enter the sex of the animal");
            Cat.setSex(Console.ReadLine());

            Console.WriteLine("Enter the type/breed of the animal");
            Cat.setType(Console.ReadLine());

            Console.WriteLine(Cat.getName() + " is " + Cat.getAge() + " years old and a " + Cat.getSex() + " of " + Cat.getType() + " breed");
        }
    }
}
