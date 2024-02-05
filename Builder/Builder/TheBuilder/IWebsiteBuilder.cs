using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Product;

namespace Builder.TheBuilder
{
    public interface IWebsiteBuilder
    {
        void BuildHomePage();
        void BuildAboutPage();
        void BuildContactForm();
        void BuildGalleryPage();
        void BuildBlogPage();
        Website GetWebsite();
    }
}
