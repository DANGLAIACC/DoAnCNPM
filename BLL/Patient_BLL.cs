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
        public static bool updatePatient(Patient_DTO p)
        {
            return Patient_DAL.updatePatient(p);
        }
        public static Patient_DTO getPatientByRecId(string rec_id)
        {
            return Patient_DAL.getPatientByRecId(rec_id);
        }
    }
}
