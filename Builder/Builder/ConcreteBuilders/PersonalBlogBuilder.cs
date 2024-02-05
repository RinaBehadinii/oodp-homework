using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Product;
using Builder.TheBuilder;

namespace Builder.ConcreteBuilders
{
    public class PersonalBlogBuilder : IWebsiteBuilder
    {
        private Website _website = new Website();

        public void BuildHomePage()
        {
            _website.AddPage("Home Page");
        }
        public void BuildAboutPage()
        {
            _website.AddPage("About Page");
        }
        public void BuildContactForm()
        {
            _website.AddPage("Contact Form");
        }
        public void BuildGalleryPage()
        {
            _website.AddPage("Gallery Page");
        }
        public void BuildBlogPage()
        {
            _website.AddPage("Blog Page");
        }

        public Website GetWebsite()
        {
            return _website;
        }
    }
}
