using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Examination_BLL
    {
        public static List<Examination_DTO> getExamination()
        {
            return Examination_DAL.getExamination();
        }
        public static bool updateResultExamination(int rec_id, string exa_result)
        {
            return Examination_DAL.updateResultExamination(rec_id, exa_result);
        }
}
