using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Linux
{
    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in Linux style.");

        }
    }
}
