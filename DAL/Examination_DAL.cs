using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Examination_DAL
    {
        public static List<Examination_DTO> getExamination()
        {

            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from examination");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Examination_DTO> lst = new List<Examination_DTO>();
                Examination_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Examination_DTO(
                        Int32.Parse(table.Rows[i]["rec_id"].ToString()),
                        table.Rows[i]["exa_place"].ToString(),
                        table.Rows[i]["exa_content"].ToString(),
                        table.Rows[i]["exa_result"].ToString());
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        public static bool updateResultExamination(int rec_id, string exa_result)
        {
            string query = string.Format("update examination set exa_result = N'{0}' where rec_id={1}", exa_result, rec_id);
            return DataProvider.ExecuteNonQuery(query);
        }
        
    }
}
