using AbstractFactory.MacOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();  
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new MacOSWindow();
        }
    }
}
