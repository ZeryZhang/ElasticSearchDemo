using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Nest;

namespace ES
{
    /// <summary>
    /// ES配置
    /// </summary>
    public static class ElasticSearchConfig
    {
        public static  string esUrl = "http://192.168.0.180:9200";
        public static IElasticClient  EsClient;
        /// <summary>
        /// 索引别名
        /// </summary>
        public static string IndexName = "doctor-index";

        static ElasticSearchConfig()
        {
            EsClient = new ElasticClient(new ConnectionSettings(new Uri(esUrl)));
        }

    }
 }
