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
            string query = "select a.*,exa_result from RECORD a inner join EXAMINATION b on a.rec_id = b.rec_id";
            
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
                    l.Exa_result = table.Rows[i]["exa_result"].ToString();
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
            string query = "select a.rec_id,rec_date,doc_fullname,rec_diagnostic, exa_result from record a inner join doctor b on a.doc_usr = b.doc_usr left join EXAMINATION c on a.rec_id = c.rec_id where pat_id = " + pat_id;

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
                    if (DBNull.Value.Equals(table.Rows[i]["exa_result"]))
                        l.Exa_result = null;
                    else
                        l.Exa_result = table.Rows[i]["exa_result"].ToString();
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
        /// <summary>
        /// Thêm dữ liệu vào bảng Record (id auto)
        /// </summary>
        /// <param name="r">record cần thêm</param>
        /// <returns>id vừa thêm</returns>
        public static string addRecord(Record_DTO r)
        {
            string query = string.Format("INSERT INTO RECORD(rec_date, pat_id, doc_usr, rec_diagnostic, hospital, exam_type_id, rec_note)  OUTPUT Inserted.rec_id VALUES('{0}', {1}, '{2}', N'{3}', N'{4}', {5}, N'{6}')", r.Rec_date,r.Pat_id,r.Doc_usr,r.Rec_diagnostic,r.Hospital, r.Exam_type_id,r.Rec_note);

            DataTable table = new DataTable();
            table = DataProvider.Execute(query);

            return table.Rows[0]["rec_id"].ToString();
        }
        /// <summary>
        /// Lấy các kết quả dùng cho form nhập viện
        /// </summary>
        /// <returns></returns>
        public static List<Record_DTO> getRecordHospital()
        {
            DataTable table = new DataTable();
            string query = "select a.rec_id,rec_date, pat_fullname, hospital from record a inner join PATIENT d on a.pat_id=d.pat_id where hospital is not null";

            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Record_DTO> lst = new List<Record_DTO>();
                Record_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Record_DTO();
                    l.Rec_id = Int32.Parse(table.Rows[i]["rec_id"].ToString());

                    l.Rec_date = DateTime.Parse(table.Rows[i]["rec_date"]
                        .ToString());
                    l.Pat_fullname = table.Rows[i]["pat_fullname"].ToString();
                    l.Hospital = table.Rows[i]["hospital"].ToString();
                    
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        /// <summary>
        /// Lấy các kết quả giữa 2 ngày, dùng trong form Analytic 
        /// </summary>
        /// <returns>Mảng các mảng con (đại diện cho 1 record)</returns>
        public static List<Analytic_DTO> getRecordByDate(string doc_usr, string start, string end)
        {
            DataTable table = new DataTable();
            string query = string.Format("select rec_id, pat_fullname, CONVERT(VARCHAR(10), rec_date, 103) rec_date, exam_type_price from RECORD a inner join PATIENT b on a.pat_id = b.pat_id inner join EXAM_TYPE c on a.exam_type_id = c.exam_type_id where (doc_usr = '{0}') and(rec_date between '{1}' and '{2} 23:59:59.999')", doc_usr,start,end);

            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Analytic_DTO> lst = new List<Analytic_DTO>();
                for (int i = 0; i < count; i++)
                {
                    lst.Add(new Analytic_DTO (
                        table.Rows[i]["rec_id"].ToString(),
                        table.Rows[i]["pat_fullname"].ToString(),
                        table.Rows[i]["rec_date"].ToString(),
                        Int32.Parse(table.Rows[i]["exam_type_price"].ToString())
                    ));
                }
                return lst;
            }
            return null;
        } 
    }
}
