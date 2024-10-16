﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objForm = new Form1();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias objForm = new materias();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docentes objForm = new docentes();
            objForm.MdiParent = this;   
            objForm.Show();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuario objForm = new frm_usuario();
            objForm.MdiParent = this;
            objForm.Show();
        }
    }
}
