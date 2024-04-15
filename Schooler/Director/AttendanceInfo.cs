using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schooler.Director
{
    internal class AttendanceInfo
    {
        public string FullName { get; set; }
        public DateTime start { get; set; }
        public DateTime? end { get; set; }
    }
}
