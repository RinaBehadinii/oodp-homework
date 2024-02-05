using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Dashboard
    {
        private List<IWidgetPrototype> widgets = new List<IWidgetPrototype>();

        public void AddWidget(IWidgetPrototype widget)
        {
            widgets.Add(widget);
        }

        public void DuplicateWidget(int widgetIndex)
        {
            if (widgetIndex >= 0 && widgetIndex < widgets.Count)
            {
                widgets.Add(widgets[widgetIndex].Clone());
            }
            else
            {
                Console.WriteLine("Invalid widget index.");
            }
        }

        public void DisplayWidgets()
        {
            foreach (var widget in widgets)
            {
                if (widget is DataWidget dataWidget)
                {
                    Console.WriteLine($"Data Widget: {dataWidget.Data}");
                }
                else if (widget is ChartWidget chartWidget)
                {
                    Console.WriteLine($"Chart Widget: {chartWidget.ChartType}");
                }
            }
        }
    }
}
