using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Чурсин Станислав Викторович";

            byte age = 29;

            string mail = "stanislaw.chursin@mail.ru";

            double programming = 85.5;

            double mathematics = 67.8;

            double physics = 72.1;

            string newPattern = "ФИО:{0} \nВозраст:{1} \nПочта: {2} \nПрограммирование: {3} \nМатематика: {4} \nФизика: {5}";


            Console.WriteLine(newPattern,
            fullName,
            age,
            mail,
            programming,
            mathematics,
            physics);

            Console.ReadKey();

            double totalScore = programming + mathematics+ physics;

            double average = (programming + mathematics + physics) / 3;

            Console.WriteLine(totalScore);
            Console.WriteLine(average.ToString("#.##"));
            Console.ReadLine();

        }
    }
}
