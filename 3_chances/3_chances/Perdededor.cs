using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_chances
{
    public partial class Frm_Perdededor : Form
    {
        public Frm_Perdededor()
        {
            InitializeComponent();
        }

        private void Btn_dica_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
