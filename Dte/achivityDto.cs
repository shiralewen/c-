using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class ActivityDto
    {

        public int id { get; set; }
        public System.DateTime date { get; set; }
        public string describtion { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public string address { get; set; }
        public int sumPeople { get; set; }

    }
}
