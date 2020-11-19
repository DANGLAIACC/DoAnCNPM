using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Patient_DAL
    {
        public static List<Patient_DTO> getPatient()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from patient");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Patient_DTO> lst = new List<Patient_DTO>();
                Patient_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Patient_DTO(
                        Int32.Parse(table.Rows[i]["pat_id"].ToString()),
                        table.Rows[i]["pat_fullname"].ToString(),
                        (table.Rows[i]["pat_gender"].ToString())=="1",
                        DateTime.Parse( table.Rows[i]["pat_dob"].ToString()),
                        table.Rows[i]["pat_address"].ToString(),
                        table.Rows[i]["pat_phone1"].ToString(),
                        table.Rows[i]["pat_anamnesis"].ToString());
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        public static bool addPatient(Patient_DTO p)
        {
            string query = string.Format("INSERT INTO PATIENT(pat_fullname, pat_gender, pat_dob, pat_phone1, pat_phone2, pat_anamnesis) VALUES (N'{0}',{1},'{2}',N'{3}','{4}','{5}',N'{6}')"
                ,p.Pat_fullname,p.Pat_gender,p.Pat_dob,p.Pat_address,
                p.Pat_phone1, p.Pat_phone2,p.Pat_anamnesis);
            return DataProvider.ExecuteNonQuery(query);
        }

        /*Thêm tính năng xem lịch sử khám bệnh (bác sĩ khám, chẩn đoán bệnh tại thời điểm đó,...)*/
    }
}
