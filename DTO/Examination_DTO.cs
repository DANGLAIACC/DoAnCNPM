using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Examination_DTO
    { 
        public Examination_DTO(int rec_id, string exa_place, string exa_content, string exa_result, string doc_fullname, string pat_fullname, int pat_id, DateTime rec_date)
        {
            Rec_id = rec_id;
            Exa_place = exa_place;
            Exa_content = exa_content;
            Exa_result = exa_result;
            Doc_fullname = doc_fullname;
            Pat_fullname = pat_fullname;
            Pat_id = pat_id;
            Rec_date = rec_date;
        }
        public Examination_DTO(int rec_id, string exa_place, string exa_content, string exa_result)
        {
            Rec_id = rec_id;
            Exa_place = exa_place;
            Exa_content = exa_content;
            Exa_result = exa_result;
        }
        public int Rec_id { get; set; }
        public string Exa_place { get; set; }
        public string Exa_content { get; set; }
        public string Exa_result { get; set; }

        public string Doc_fullname { get; set; }
        public string Pat_fullname { get; set; }
        public int Pat_id { get; set; }
        public DateTime Rec_date { get; set; }

        public string[] ToArrString()
        {
            return new string[]{
               Pat_id.ToString(), Rec_id.ToString(), Exa_content, Exa_result
            };
        }
    }

}
