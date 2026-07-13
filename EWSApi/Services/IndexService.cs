using EWSApi.Utils.Configuration;
using Microsoft.Extensions.Options;

namespace EWSApi.Services
{
    public class IndexService : ElasticClient, IIndexService
    {
        public IndexService(IOptions<ElasticConfiguration> config) : base(config)
        {
        }

        public async Task IndexData<T>(T[] data, string index) where T : class
        {
            var client = getElasticClient(index);

            var existsResponse = await client.Indices.ExistsAsync(index);

            if (!existsResponse.Exists)
            {
                var createResponse = await client.Indices.CreateAsync(index, x => x
                    .Index(index)
                    .Settings(s => s.MaxResultWindow(1000000))
                );

                if (!createResponse.IsValidResponse)
                {
                    throw new Exception(createResponse.DebugInformation);
                }
            }

            if (data == null || data.Length == 0)
            {
                throw new Exception($"Nuk ka te dhena per indeksim ne index '{index}'.");
            }

            var options = new ParallelOptions { MaxDegreeOfParallelism = 100 };
            await Parallel.ForEachAsync(
               data,
               options,
               async (item, token) =>
               {
                   await client.IndexAsync(item, token);
               }
             );

            var refreshResponse = await client.Indices.RefreshAsync(index);

            if (!refreshResponse.IsValidResponse)
            {
                throw new Exception(refreshResponse.DebugInformation);
            }
        }

        public async Task CreateIndex(string name)
        {
            var client = getElasticClient();
            await client.Indices.CreateAsync(name, x =>
            {
                x.Index(name);
                x.Settings(new Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings
                {
                    MaxResultWindow = 1000000
                });
            });
        }
    }
}
