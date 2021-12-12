using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Doctor_DAL
    {
        public static Doctor_DTO getLogin(string doc_usr, string doc_pwd)
        {
            DataTable table = new DataTable();
            string query = string.Format("select * from doctor where doc_usr='{0}' and doc_pwd='{1}'", doc_usr, doc_pwd);
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                Doctor_DTO d = new Doctor_DTO(
                    table.Rows[0]["doc_usr"].ToString(),
                    table.Rows[0]["doc_fullname"].ToString(),
                    table.Rows[0]["doc_title"].ToString(),
                    table.Rows[0]["doc_phone"].ToString(),
                    Int32.Parse(table.Rows[0]["doc_role"].ToString())
                    );
                
                return d;
            }
            return null;

        }
    }
}
