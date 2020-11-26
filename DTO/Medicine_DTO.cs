using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Medicine_DTO
    {
        public Medicine_DTO(string med_id, string med_name)
        {
            Med_id = med_id;
            Med_name = med_name;
        }

        public string Med_id { get; set; }
        public string Med_name { get; set; }

        public string[] ToArrString()
        {
            return new string[]
            {
                Med_id,
                Med_name
            };
        }
    }

}
