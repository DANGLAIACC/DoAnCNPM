using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Patient_BLL
    {
        public static List<Patient_DTO> getPatient()
        {
            return Patient_DAL.getPatient();
        }
        public static bool addPatient(Patient_DTO p)
        {
            return Patient_DAL.addPatient(p);
        }
    }
}
