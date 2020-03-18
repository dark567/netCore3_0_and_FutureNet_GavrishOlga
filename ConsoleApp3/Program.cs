using System;
#nullable disable

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sheldon = new Person("Sheldon", "Cooper");
            var lenght = GetMiddleNameLenght(sheldon);
            Console.WriteLine(lenght);
            Console.ReadLine();
        }

        static int GetMiddleNameLenght(Person person)
        {
            var middle = person.MiddleName;
            //if (middle is null) return 0; //ver 1
            if (string.IsNullOrEmpty(middle)) return 0; //ver 2
            return middle.Length;
        }
    }
}
