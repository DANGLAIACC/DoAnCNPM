using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.global;
using GUI.Forms;

namespace GUI.UserControls
{
    public partial class UC_Hospital : UserControl
    {
        private List<Record_DTO> lstRecord= new List<Record_DTO>();
        public UC_Hospital()
        {
            InitializeComponent();
        }
        private void UC_Hospital_Load(object sender, EventArgs e)
        {
            lstRecord = Record_BLL.getRecordHospital();
            loadLstMedicineToGrv(lstRecord);

            grvLstHospital.Columns[0].Width = grvLstHospital.Columns[1].Width = 130;
        } 
        private void loadLstMedicineToGrv(List<Record_DTO> lst)
        {
            grvLstHospital.Rows.Clear();
            foreach (Record_DTO m in lst)
            {
                grvLstHospital.Rows.Add(ToArrayStringHospital(m));
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                loadLstMedicineToGrv(lstRecord);
            else
            {
                grvLstHospital.Rows.Clear();
                // filter by ID
                string filter = txtFilter.Text.Trim().ToLower();
                foreach (Record_DTO r in lstRecord)
                    if (r.Pat_fullname.ToLower().IndexOf(filter) > -1)
                        grvLstHospital.Rows.Add(ToArrayStringHospital(r));
            }
        }

        private void grvLstHospital_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hiện bảng in giấy giới thiệu cho bệnh viện");
        }
        /// <summary>
        /// Trả về mảng điền vào grid view
        /// </summary>
        /// <returns></returns>
        public string[] ToArrayStringHospital(Record_DTO r)
        {
            Console.Write(r.Rec_id);
            return new string[]{
                r.Rec_id.ToString(),
                r.Rec_date.ToString("HH:mm:ss dd/MM/yyyy"),
                r.Pat_fullname,
                r.Hospital
            };
        }

    }
}
