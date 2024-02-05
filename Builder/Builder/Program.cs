using Builder.ConcreteBuilders;
using Builder.Director;
using Builder.TheBuilder;

var director = new WebsiteDirector();
IWebsiteBuilder builder;

builder = new PortfolioWebsiteBuilder();
director.ConstructPortfolioWebsite(builder);
Console.WriteLine(builder.GetWebsite().Describe());

builder = new BusinessWebsiteBuilder();
director.ConstructBusinessWebsite(builder);
Console.WriteLine(builder.GetWebsite().Describe());

builder = new PersonalBlogBuilder();
director.ConstructBlogWebsite(builder);
Console.WriteLine(builder.GetWebsite().Describe());