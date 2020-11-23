using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Guna.UI2.WinForms;
namespace GUI.global
{
    public class Function
    {
        public static void styleButtonEnter(Guna2Button btn)
        {
            btn.Enter += (o, e) =>
            {
                btn.Checked = true;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
            };
            btn.Leave += (o, e) =>
            {
                btn.Checked = false;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            };
        }
    }
}
