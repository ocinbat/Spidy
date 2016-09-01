using HtmlAgilityPack;

namespace SpidyCore.Interfaces
{
    public interface IHtmlLoader
    {
        HtmlDocument Load(string url);
    }
}