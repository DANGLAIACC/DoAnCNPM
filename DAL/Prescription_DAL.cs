using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Prescription_DAL
    {
        /// <summary>
        /// Thêm đơn thuốc
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool addPrescription(string rec_id, Prescription_DTO p)
        {
            string query = string.Format("INSERT INTO PRESCRIPTION VALUES ({0}, '{1}', {2}, {3}, {4}, N'{5}')", rec_id, p.Med_name, p.Pre_morning, p.Pre_middle,
              p.Pre_afternoon, p.Pre_note);
            
            return DataProvider.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Lấy thông tin đơn thuốc bằng mã bản ghi khám bệnh
        /// </summary>
        /// <param name="rec_id"></param>
        /// <returns></returns>
        public static List<Prescription_DTO> getPrescriptionByRecId(string rec_id)
        {
            DataTable table = new DataTable();
            string query = string.Format("select * from prescription where rec_id = {0}", rec_id);
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {

                List<Prescription_DTO> lst = new List<Prescription_DTO>();
                Prescription_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Prescription_DTO(
                        Int32.Parse(rec_id),
                        table.Rows[i]["med_name"].ToString(),
                        Int32.Parse(table.Rows[i]["pre_morning"].ToString()),
                        Int32.Parse(table.Rows[i]["pre_middle"].ToString()),
                        Int32.Parse(table.Rows[i]["pre_afternoon"].ToString()),
                        table.Rows[i]["pre_note"].ToString());
                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
