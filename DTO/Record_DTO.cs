using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Record_DTO
    {
        public Record_DTO(int rec_id, DateTime rec_date, int par_id, string doc_usr, string rec_diagnostic, string hospital, int exam_type_id, string rec_note)
        {
            Rec_id = rec_id;
            Rec_date = rec_date;
            Par_id = par_id;
            Doc_usr = doc_usr;
            Rec_diagnostic = rec_diagnostic;
            Hospital = hospital;
            Exam_type_id = exam_type_id;
            Rec_note = rec_note;
        }

        public int Rec_id { get; set; }
        public DateTime Rec_date { get; set; }
        public int Par_id { get; set; }
        public string Doc_usr { get; set; }
        public string Rec_diagnostic { get; set; }
        public string Hospital { get; set; }
        public int Exam_type_id { get; set; }
        public string Rec_note { get; set; }

        public string Doc_fullname { get; set; }
        public Record_DTO(int rec_id, DateTime rec_date, string doc_fullname, string rec_diagnostic)
        {
            Rec_id = rec_id;
            Rec_date = rec_date;
            Doc_fullname = doc_fullname;
            Rec_diagnostic = rec_diagnostic;
        }
    }


}
