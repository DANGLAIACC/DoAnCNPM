using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Record_DAL
    {
    
        /// <summary>
        /// Lấy toàn bộ bản ghi khám bệnh
        /// </summary>
        /// <returns></returns>
        public static List<Record_DTO> getRecord()
        {
            DataTable table = new DataTable();
            string query = "select * from record";
            
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Record_DTO> lst = new List<Record_DTO>();
                Record_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Record_DTO(
                        Int32.Parse(table.Rows[i]["rec_id"].ToString()),
                        DateTime.Parse(table.Rows[i]["rec_date"]
                        .ToString()),
                        Int32.Parse(table.Rows[i]["pat_id"]
                        .ToString()),
                        table.Rows[i]["doc_usr"].ToString(),
                        table.Rows[i]["rec_diagnostic"].ToString(),
                        table.Rows[i]["hospital"].ToString(),
                        Int32.Parse(table.Rows[i]["exam_type_id"]
                        .ToString()),
                        table.Rows[i]["rec_note"].ToString());
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        /// <summary>
        /// Lấy hồ sơ bệnh án theo mã bệnh nhân
        /// </summary>
        /// <param name="pat_id">Mã bệnh nhân</param>
        /// <returns></returns>
        public static List<Record_DTO> getRecordByPatId(int pat_id)
        {
            DataTable table = new DataTable();
            string query = "select rec_id,rec_date,doc_fullname,rec_diagnostic from record a inner join doctor b on a.doc_usr = b.doc_usr where pat_id = "+pat_id;

            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Record_DTO> lst = new List<Record_DTO>();
                Record_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Record_DTO(
                        Int32.Parse(table.Rows[i]["rec_id"].ToString()),
                        DateTime.Parse(table.Rows[i]["rec_date"]
                        .ToString()),
                        table.Rows[i]["doc_fullname"].ToString(),
                        table.Rows[i]["rec_diagnostic"].ToString());
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        public static bool addRecord(Record_DTO r)
        {
            // todo
            // string query = string.Format("")

            return true;

        }
    }
}
