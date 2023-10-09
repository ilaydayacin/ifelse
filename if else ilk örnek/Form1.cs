using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_ilk_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (cbSari.Checked == true)
            {
                lblYapildi.Text = "Hangi renk yapıldı: Sarı";
                this.BackColor = Color.Yellow;

            }
            else
            {
                lblYapildi.Text = "Hangi renk yapıldı: Sarı Kaldırıldı";
                this.BackColor = Color.White;
            }
        }
    }
}
