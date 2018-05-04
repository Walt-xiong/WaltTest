using Mysoft.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestModel test = new TestModel();
            DateTime start = DateTime.Parse("2017-01");
            DateTime end = start.AddMonths(1).AddDays(-1);
            Console.WriteLine(start.ToString("yyyy-MM-dd") + " | " + end.ToString("yyyy-MM-dd"));

            List<string> ts = new List<string>()
            {
                "","","北京","深圳"
            };

            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach(var temp in ts){
                dic.Add(temp,temp);
            }

            Console.ReadKey();

        }
    }
}
