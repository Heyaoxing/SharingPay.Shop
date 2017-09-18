using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace Common.ElasticsearchDb
{
    public class ElasticClientBase
    {
        public ElasticClient GetClient(string indexName= "defaultindex")
        {
            var host = "http://192.168.1.82:9200";
            var node = new Uri(host);

            var settings = new ConnectionSettings(node);
            settings.DefaultIndex(indexName);
            var client = new ElasticClient(settings);
            return client;
        }
    }
}
