using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class RegisterDto
    {
        public int id { get; set; }
        public Nullable<int> idActivity { get; set; }
        public int userCode { get; set; }
        public string status { get; set; }
    }
}
