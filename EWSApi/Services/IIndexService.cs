namespace EWSApi.Services
{
    public interface IIndexService
    {
        Task IndexData<T>(T[] data, string index) where T : class;
        Task CreateIndex(string name);
    }
}
