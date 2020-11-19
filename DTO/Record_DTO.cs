using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Record_DTO
    {
        public int Rec_id { get; set; }
        public DateTime Rec_date { get; set; }
        public int Par_id { get; set; }
        public string Doc_id { get; set; }
        public string Rec_diagnostic { get; set; }
        public string Hospital { get; set; }
        public int Exam_type_id { get; set; }
        public string Rec_note { get; set; }
    }

}
