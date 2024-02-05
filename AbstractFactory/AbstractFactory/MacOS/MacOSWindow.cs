using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    public class MacOSWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering a window in MAC OS style.");
        }
    }
}
