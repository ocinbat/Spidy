using HtmlAgilityPack;

namespace SpidyCore
{
    public interface ISpidyParser
    {
        void Parse(HtmlDocument document);
    }
}