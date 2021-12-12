using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Prescription_BLL
    {
        public static bool addPrescription(string rec_id, Prescription_DTO p)
        {
            return Prescription_DAL.addPrescription(rec_id, p);
        }
        public static List<Prescription_DTO> getPrescriptionByRecId(string rec_id)
        {
            return Prescription_DAL.getPrescriptionByRecId(rec_id);
        }

    }
}
