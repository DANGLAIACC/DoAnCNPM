using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace GUI.global
{
    public class List
    {
        public static List<Patient_DTO> lstPatient = new List<Patient_DTO>();
        public static Doctor_DTO curentDoctor = new Doctor_DTO("dqlai", "Đặng Quốc Lai", "BS. Chuyên khoa I", "0772470922", 1);
    }
}
