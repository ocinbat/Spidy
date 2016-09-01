using System;
using HtmlAgilityPack;
using SpidyCore.Interfaces;

namespace SpidyCore
{
    public class HtmlLoader : IHtmlLoader
    {
        private readonly HtmlWeb _htmlWeb;

        public HtmlLoader(HtmlWeb htmlWeb)
        {
            if (htmlWeb == null)
            {
                throw new ArgumentNullException(nameof(htmlWeb));
            }

            _htmlWeb = htmlWeb;
        }

        public HtmlDocument Load(string url)
        {
            HtmlDocument result;

            if (CheckUrlValid(url))
            {
                result = _htmlWeb.Load(url);
            }
            else
            {
                throw new ArgumentException(nameof(url));
            }

            return result;
        }

        private bool CheckUrlValid(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;

            return result;
        }
    }
}