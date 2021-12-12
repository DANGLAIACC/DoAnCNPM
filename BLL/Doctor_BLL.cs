using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class Doctor_BLL
    {
        public static Doctor_DTO getLogin(string doc_usr, string doc_pwd)
        {
            return Doctor_DAL.getLogin(doc_usr, doc_pwd);
        }
    }
}
