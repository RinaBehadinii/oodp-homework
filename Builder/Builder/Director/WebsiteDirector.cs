using Builder.TheBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class WebsiteDirector
    {
        public void ConstructPortfolioWebsite(IWebsiteBuilder builder)
        {
            builder.BuildHomePage();
            builder.BuildAboutPage();
            builder.BuildGalleryPage();
            builder.BuildContactForm();
        }

        public void ConstructBusinessWebsite(IWebsiteBuilder builder)
        {
            builder.BuildHomePage();
            builder.BuildAboutPage();
            builder.BuildContactForm();
            builder.BuildBlogPage();
        }

        public void ConstructBlogWebsite(IWebsiteBuilder builder)
        {
            builder.BuildHomePage();
            builder.BuildBlogPage();
            builder.BuildContactForm();
        }
    }
}
