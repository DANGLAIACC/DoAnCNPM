using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Analytic_DTO
    {
        public Analytic_DTO(string rec_id, string pat_fullname, string rec_date, int exam_type_price)
        {
            Rec_id = rec_id;
            Pat_fullname = pat_fullname;
            Rec_date = rec_date;
            Exam_type_price = exam_type_price;
        }

        public string Rec_id { get; set; }
        public string Pat_fullname { get; set; }
        public string Rec_date { get; set; }
        public int Exam_type_price { get; set; }

    }
}
