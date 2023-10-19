using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.Models
{
    public class DetectAnswer
    {
        public DateTime dateTime { get; set; }
        public string Fan { get; set; }=String.Empty;
        public int Test_number { get; set; }
        public string Quize { get; set; } = String.Empty;
        public string A { get; set; } = String.Empty;
        public string B { get; set; } = String.Empty;
        public string C { get; set; } = String.Empty;
        public string D { get; set; } = String.Empty;
        public string Correct { get; set; } = String.Empty;
        public string Student_answear { get; set; }=String.Empty;
        public bool True_answ { get; set; }
    }
}
