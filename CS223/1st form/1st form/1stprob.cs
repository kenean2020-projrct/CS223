using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_form
{
    class add
    {
        public string name { get; set; }
        public string inventoryName { get; set; }
        public string objectName { set; get; } 
        public int count { set; get; }
        public double price { get; set; }

    void  save()
        {
            Console.WriteLine("saved");
        }
    }
}
