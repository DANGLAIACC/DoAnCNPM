using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Medicine_DAL
    {
        public static List<Medicine_DTO> getMedicine()
        {

            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from medicine");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Medicine_DTO> lst = new List<Medicine_DTO>();
                Medicine_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Medicine_DTO(
                        table.Rows[i]["med_id"].ToString(),
                        table.Rows[i]["med_name"]
                        .ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        public static bool addMedicine(Medicine_DTO m)
        {
            string query = string.Format("INSERT INTO MEDICINE VALUES ('{0}',N'{1}')", m.Med_id, m.Med_name);
            return DataProvider.ExecuteNonQuery(query);
        }
        public static bool updateMedicine(Medicine_DTO m)
        {
            string query = string.Format("UPDATE MEDICINE SET med_name = N'{0}' WHERE med_id = '{1}'", m.Med_name, m.Med_id);

            return DataProvider.ExecuteNonQuery(query);
        }
    }
}
