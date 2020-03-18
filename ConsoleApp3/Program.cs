using System;
//enable varnings nullable
//#nullable disable
//enable varnings warnings nullable
#nullable disable warnings

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

        static int GetMiddleNameLenght(Person? person)
        {
            //recursive pattern
            if (person is { }) return 1; // checking is null //recursive patterns
            if (person is {FirstName:"Sheldon", LastName: var last}) return last.Length; //recursive patterns

            var middle = person.MiddleName;
            //if (middle is null) return 0; //ver 1
            if (string.IsNullOrEmpty(middle)) return 0; //ver 2
            return middle.Length;
        }
    }
}
