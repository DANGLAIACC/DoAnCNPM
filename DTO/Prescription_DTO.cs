using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Prescription_DTO
    {
        public Prescription_DTO(int rec_id, string med_id, int pre_morning, int pre_middle, int pre_afternoon, string pre_note)
        {
            Rec_id = rec_id;
            Med_id = med_id;
            Pre_morning = pre_morning;
            Pre_middle = pre_middle;
            Pre_afternoon = pre_afternoon;
            Pre_note = pre_note;
        }

        public int Rec_id { get; set; }
        public string Med_id { get; set; }
        public int Pre_morning { get; set; }
        public int Pre_middle { get; set; }
        public int Pre_afternoon { get; set; }
        public string Pre_note { get; set; }

        public override string ToString()
        {
            return string.Format("Rec_id: {0}\nMed_id: {1}\nPre_morning: {2}\nPre_middle: {3}\nPre_afternoon: {4}\nPre_note: {5}\n",
            Rec_id, Med_id, Pre_morning, Pre_middle, Pre_afternoon, Pre_note);
        }
    }
}
