using AbstractFactory.Linux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class LinuxFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
           return new LinuxCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new LinuxWindow();
        }
    }
}
