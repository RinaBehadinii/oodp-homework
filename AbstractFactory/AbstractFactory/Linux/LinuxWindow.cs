using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Linux
{
    public class LinuxWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering a window in Linux style.");
        }
    }
}
