using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsForm.Forma1;
using windowsForm.Forma2;
using windowsForm.Forma3;

namespace windowsForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void forma3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma3Formulario1 frm = new FrmForma3Formulario1();
            frm.Show();
        }

        private void forma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMFormulario1 frm = new FRMFormulario1();
            // frm.MdiParent = this;
            frm.Show();

        }

        private void forma2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmForma2Formulario1 frm = new FrmForma2Formulario1();
           frm.Show();

        }
    }
 }
