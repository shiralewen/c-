using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class EventDto
    {
        public int idEvent { get; set; }
        public Nullable<int> idActivity { get; set; }
        public string TZChild { get; set; }
        public string TzVolunteer { get; set; }

    }
}
