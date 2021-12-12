using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ExamType_BLL
    {
        public static List<ExamType_DTO> getExamType()
        {
            return ExamType_DAL.getExamType();
        }
    }
}
