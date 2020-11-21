using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Medicine_BLL
    {
        public static List<Medicine_DTO> getMedicine()
        {
            return Medicine_DAL.getMedicine();
        }
        public static bool addMedicine(Medicine_DTO m)
        {
            return Medicine_DAL.addMedicine(m);
        }

    }
}
