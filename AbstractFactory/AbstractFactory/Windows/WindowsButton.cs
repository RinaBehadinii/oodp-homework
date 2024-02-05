using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in Windows style.");
        }

    }
}
