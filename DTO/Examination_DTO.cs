using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Examination_DTO
    {
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
    }

}
