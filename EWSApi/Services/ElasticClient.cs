using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using EWSApi.Utils.Configuration;
using Microsoft.Extensions.Options;

namespace EWSApi.Services
{
    public abstract class ElasticClient
    {
        protected readonly ElasticConfiguration config;

        public ElasticClient(IOptions<ElasticConfiguration> options)
        {
            config = options.Value;
        }

        protected ElasticsearchClient getElasticClient()
        {
            var settings = CreateSettings();
            return new ElasticsearchClient(settings);
        }

        protected ElasticsearchClient getElasticClient(string indexName)
        {
            var settings = CreateSettings()
                .DefaultIndex(indexName);

            return new ElasticsearchClient(settings);
        }

        private ElasticsearchClientSettings CreateSettings()
        {
            if (string.IsNullOrWhiteSpace(config.Uri))
            {
                throw new Exception("Elasticsearch:Uri nuk eshte konfiguruar.");
            }

            var settings = new ElasticsearchClientSettings(new Uri(config.Uri));

            if (!string.IsNullOrWhiteSpace(config.ApiKey))
            {
                return settings.Authentication(new ApiKey(config.ApiKey.Trim()));
            }

            if (!string.IsNullOrWhiteSpace(config.Username) && !string.IsNullOrEmpty(config.Password))
            {
                return settings.Authentication(new BasicAuthentication(config.Username, config.Password));
            }

            return settings;
        }
    }
}
