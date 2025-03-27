using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment
{
    internal class Assignment
    {
        private String _name;

        static void assignmentAuthors()
        {
            Console.WriteLine("This assignment was created by Blake Miller and Gabe Galiatsatos");
        }

        public string Name { get { return _name; } set { _name = value; } }
    }
}
