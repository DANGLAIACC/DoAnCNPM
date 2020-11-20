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
        public static bool addPrescription(Prescription_DTO p)
        {
            return Prescription_DAL.addPrescription(p);
        }

    }
}
