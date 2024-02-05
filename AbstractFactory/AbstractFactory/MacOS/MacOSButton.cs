using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in MAC OS style.");
        }
    }
}
