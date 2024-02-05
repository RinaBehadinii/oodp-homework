using AbstractFactory.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
           return new WindowsCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new WindowsWindow();
        }
    }
}
