using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    public class WindowsWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering a window in Windows style.");
        }

    }
}
