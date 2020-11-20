using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Record_BLL
    {
        public static List<Record_DTO> getRecord()
        {
            return Record_DAL.getRecord();
        }
        public static List<Record_DTO> getRecordByPatId(int pat_id)
        {
            return Record_DAL.getRecordByPatId(pat_id);
        }

    }
}
