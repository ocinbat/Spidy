using Entities;

namespace SpidyCore.Interfaces
{
    public interface ISpidy
    {
        void Get(ParseInfo parseInfo);
        void GetWithPagination();
    }
}
