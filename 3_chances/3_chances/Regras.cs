﻿using System;
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
    public partial class frmRegras : Form
    {
        public frmRegras(Form corFundo)
        {
            InitializeComponent();
            this.BackColor = corFundo.BackColor;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
