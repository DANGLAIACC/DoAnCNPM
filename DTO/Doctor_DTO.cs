using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Doctor_DTO
    {
        public Doctor_DTO(string doc_usr, string doc_fullname, string doc_title, string doc_phone, int doc_role)
        {
            Doc_usr = doc_usr;
            Doc_fullname = doc_fullname;
            Doc_title = doc_title;
            Doc_phone = doc_phone;
            Doc_role = doc_role;
        }

        public string Doc_usr { get; set; }
        public string Doc_pwd { get; set; }
        public string Doc_fullname { get; set; }
        public bool Doc_gender { get; set; }
        public DateTime Doc_dob { get; set; }
        public string Doc_title { get; set; }
        public string Doc_address { get; set; }
        public string Doc_phone { get; set; }
        public int Doc_role { get; set; }
    }

}
