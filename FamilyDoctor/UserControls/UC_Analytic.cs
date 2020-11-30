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
    public partial class UC_Analytic : UserControl
    {
        public UC_Analytic()
        {
            InitializeComponent();
        }

        private void UC_Analytic_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            dtpStart.MaxDate = DateTime.Now;
            dtpEnd.MaxDate = DateTime.Now;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                Console.WriteLine("start: "+dtpStart.Value);
                Console.WriteLine("end:   "+dtpEnd.Value);

                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc.", "Lỗi lọc data");
                return;
            }
            grvLstRecord.Rows.Clear();
            List<string[]> lst = Record_BLL.getRecordByDate(List.curentDoctor.Doc_usr, dtpStart.Value.ToString("MM/dd/yyyy"), dtpEnd.Value.ToString("MM/dd/yyyy"));

            if(lst != null)
                foreach (string[] str in lst)
                    grvLstRecord.Rows.Add(str);
        }
    }
}
