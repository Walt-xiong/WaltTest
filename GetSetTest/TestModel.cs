using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest
{
    public class TestModel
    {
        public string Name { get; set; }


        public TestModel()
        {
            Name = "Defalut Name";
        }


        public TestModel(string name)
        {
            Name = name;
        }



        public string getName(){
            return Name;
        }
    }
}
