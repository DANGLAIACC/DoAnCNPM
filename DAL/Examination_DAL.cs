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
            string query = "select a.*, doc_fullname, pat_fullname, d.pat_id, rec_date from EXAMINATION a inner join RECORD b on a.rec_id = b.rec_id inner join DOCTOR c on b.doc_usr = c.doc_usr inner join PATIENT d on b.pat_id = d.pat_id";
            table = DataProvider.Execute(query);
            
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
                        table.Rows[i]["exa_result"].ToString(),

                        table.Rows[i]["Doc_fullname"].ToString(),
                        table.Rows[i]["Pat_fullname"].ToString(),
                        Int32.Parse(table.Rows[i]["Pat_id"].ToString()),
                        DateTime.Parse(table.Rows[i]["Rec_date"].ToString()));
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
        /// <summary>
        /// Trả về nơi xét nghiệm, nội dung xét nghiệm dùng cho frmExaminationResult
        /// </summary>
        /// <param name="rec_id">Mã bệnh án</param>
        /// <returns></returns>
        public static Examination_DTO getExaminationDetailById(string rec_id)
        {

            DataTable table = new DataTable();
            string query = "select exa_place, exa_content, exa_result from EXAMINATION a where a.rec_id = " + rec_id;
            table = DataProvider.Execute(query);
            return new Examination_DTO(Int32.Parse(rec_id), table.Rows[0]["exa_content"].ToString(), table.Rows[0]["exa_place"].ToString(), table.Rows[0]["exa_result"].ToString()); 
        }

        public static bool updateResultExamination(int rec_id, string exa_result)
        {
            string query = string.Format("update examination set exa_result = N'{0}' where rec_id={1}", exa_result, rec_id);
            return DataProvider.ExecuteNonQuery(query);
        }
        
    }
}
