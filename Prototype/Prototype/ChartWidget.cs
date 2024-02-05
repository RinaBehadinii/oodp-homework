using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ChartWidget : IWidgetPrototype
    {
        public string ChartType { get; set; }

        public ChartWidget(string chartType)
        {
            ChartType = chartType;
        }

        public IWidgetPrototype Clone()
        {
            return  (IWidgetPrototype)this.MemberwiseClone();
        }
    }
}
