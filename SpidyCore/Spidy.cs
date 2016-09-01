using Entities;
using HtmlAgilityPack;
using SpidyCore.Interfaces;

namespace SpidyCore
{
    public class Spidy : ISpidy
    {
        private readonly IHtmlLoader _htmlLoader;
        private readonly ISpidyParser _parser;

        public Spidy()
        {
            IHtmlLoader htmlLoader = new HtmlLoader(new HtmlWeb());
        }

        public Spidy(IHtmlLoader htmlLoader, ISpidyParser parser)
        {
            _htmlLoader = htmlLoader;
            _parser = parser;
        }

        public void Get(ParseInfo parseInfo)
        {
            if (parseInfo != null)
            {
                HtmlDocument document = _htmlLoader.Load(parseInfo.Url);

                if (document != null)
                {
                    
                }
            }
        }

        public void GetWithPagination()
        {
            throw new System.NotImplementedException();
        }
    }
}