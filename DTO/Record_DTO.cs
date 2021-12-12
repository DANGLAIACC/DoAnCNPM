using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Record_DTO
    {
        public Record_DTO(int rec_id, DateTime rec_date, int pat_id, string doc_usr, string rec_diagnostic, string hospital, int exam_type_id, string rec_note)
        {
            Rec_id = rec_id;
            Rec_date = rec_date;
            Pat_id = pat_id;
            Doc_usr = doc_usr;
            Rec_diagnostic = rec_diagnostic;
            Hospital = hospital;
            Exam_type_id = exam_type_id;
            Rec_note = rec_note;
        }

        public Record_DTO(int rec_id, DateTime rec_date, string doc_fullname, string rec_diagnostic)
        {
            Rec_id = rec_id;
            Rec_date = rec_date;
            Doc_fullname = doc_fullname;
            Rec_diagnostic = rec_diagnostic;
        }
        public Record_DTO() { }

        public int Rec_id { get; set; }
        public DateTime Rec_date { get; set; }
        public int Pat_id { get; set; }
        public string Doc_usr { get; set; }
        public string Rec_diagnostic { get; set; }
        public string Hospital { get; set; }
        public int Exam_type_id { get; set; }
        public string Rec_note { get; set; }

        public string Doc_fullname { get; set; }
        public string Exa_result { get; set; }
        public string Pat_fullname { get; set; }

        public string[] ToArrayString()
        {
            string recId = Exa_result == null ? Rec_id.ToString() : Rec_id.ToString() + "*";
            return new string[] {
                        recId.ToString(),
                        Rec_date.ToString("HH:mm:ss dd/MM/yyyy"),
                        Doc_fullname,
                        Rec_diagnostic
                    };
        }
        

    }


}
