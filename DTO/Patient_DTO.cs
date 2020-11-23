using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Patient_DTO
    {
        public Patient_DTO(int pat_id, string pat_fullname, bool pat_gender, DateTime pat_dob, string pat_address, string pat_phone1,string phone2, string pat_anamnesis)
        {
            Pat_id = pat_id;
            Pat_fullname = pat_fullname;
            Pat_gender = pat_gender;
            Pat_dob = pat_dob;
            Pat_address = pat_address;
            Pat_phone1 = pat_phone1;
            Pat_phone2 = phone2;
            Pat_anamnesis = pat_anamnesis;
        }

        public int Pat_id { get; set; }
        public string Pat_fullname { get; set; }
        public bool Pat_gender { get; set; }
        public DateTime Pat_dob { get; set; }
        public string Pat_address { get; set; }
        public string Pat_phone1 { get; set; }
        public string Pat_phone2 { get; set; }
        public string Pat_anamnesis { get; set; }

        public string[] ToArrString()
        {
            return new string[] {Pat_id.ToString(), Pat_fullname, Pat_phone1, Pat_phone2, Pat_dob.ToString("dd/MM/yyyy"), Pat_anamnesis, Pat_address};
        }
    }

}
