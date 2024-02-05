using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LinuxCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a checkbox in Linux style.");
        }
    }
}
