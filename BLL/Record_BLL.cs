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
        public static string addRecord(Record_DTO r)
        {
            return Record_DAL.addRecord(r);
        }
        public static List<Record_DTO> getRecordHospital()
        {
            return Record_DAL.getRecordHospital();
        }

        public static List<string[]> getRecordByDate(string doc_usr, string start, string end)
        {
            return Record_DAL.getRecordByDate(doc_usr, start, end);
        }

    }
}
