﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    public class MacOSCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a checkbox in MAC OS style.");

        }
    }
}
