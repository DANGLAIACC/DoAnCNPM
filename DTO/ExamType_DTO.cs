using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamType_DTO
    {
        public ExamType_DTO(int exam_type_id, string exam_type_text, int exam_type_price)
        {
            Exam_type_id = exam_type_id;
            Exam_type_text = exam_type_text;
            Exam_type_price = exam_type_price;
        }

        public int Exam_type_id { get; set; }
        public string Exam_type_text { get; set; }
        public int Exam_type_price { get; set; }

        public override string ToString()
        {
            return Exam_type_text;
        }
    }
}
