using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class ExamType_DAL
    {
        /// <summary>
        /// Lấy tất cả các loại khám bệnh hiện có
        /// </summary>
        /// <returns></returns>
        public static List<ExamType_DTO> getExamType()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from exam_type");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<ExamType_DTO> lst = new List<ExamType_DTO>();
                ExamType_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new ExamType_DTO(
                        Int32.Parse(table.Rows[i]["exam_type_id"].ToString()),
                        table.Rows[i]["exam_type_text"].ToString(),
                        Int32.Parse(table.Rows[i]["exam_type_price"].ToString()));

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
