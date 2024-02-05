using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Website
    {
        private List<string> _pages = new List<string>();

        public void AddPage(string page)
        {
            _pages.Add(page);
        }

        public string Describe()
        {
            return $"Website with pages: {string.Join(", ", _pages)}";
        }
    }
}
