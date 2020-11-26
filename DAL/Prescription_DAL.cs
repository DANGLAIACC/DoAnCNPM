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
        public static Prescription_DTO getPrescriptionByRecId(int rec_id)
        {
            DataTable table = new DataTable();
            string query = string.Format("select * from prescription where rec_id = {0}", rec_id);
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                Prescription_DTO d = new Prescription_DTO(
                    rec_id,
                    table.Rows[0]["mec_name"].ToString(),
                    Int32.Parse(table.Rows[0]["pre_morning"].ToString()),
                    Int32.Parse(table.Rows[0]["pre_middle"].ToString()),
                    Int32.Parse(table.Rows[0]["pre_afternoon"].ToString()),
                    table.Rows[0]["pre_note"].ToString());
                return d;
            }
            return null;
        }
    }
}
