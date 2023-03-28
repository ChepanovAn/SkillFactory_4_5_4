using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            string result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }
            else User.HasPet = false;

        }
    }
}
