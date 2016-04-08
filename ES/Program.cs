using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Elasticsearch;
using Elasticsearch.Net;

using Nest;

namespace ES
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            string result = string.Empty;

            ElasticSearchService searchService = new ElasticSearchService();
            //清除已建索引
            result = searchService.DeleteIndex();
            Console.WriteLine(result);

            //创建索引
            result = searchService.CreateIndex();
            Console.WriteLine(result);

            //添加数据
            var doctorList = searchService.BuiDoctorEntities();
            result = searchService.AddDoctorInfoToIndex(doctorList);
            Console.WriteLine(result);

            Thread.Sleep(2000); //等待索引数据生成
            //更新数据
            var doctors = searchService.QueryDoctors("55882350");
            doctors.ForEach(o=>o.DoctorName="Zery-Zhang");
            result = searchService.UpdateDoctorInfoToIndex(doctors);
            Console.WriteLine(result);

            //删除数据
            //result = searchService.DeleteDoctorInfoToIndex(doctors);
            //Console.WriteLine(result);


            Console.Read();
        }



    }


}
