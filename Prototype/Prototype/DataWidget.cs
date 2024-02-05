using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DataWidget : IWidgetPrototype
    {
        public string Data { get; set; }

        public DataWidget(string data)
        {
            Data = data;
        }

        public IWidgetPrototype Clone()
        {
            return (IWidgetPrototype)this.MemberwiseClone();
        }
    }
}
