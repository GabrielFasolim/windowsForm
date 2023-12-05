using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm.Forma1
{
    public partial class FRMFormulario2 : Form
    {
        private TextBox txtResposta;
        public FRMFormulario2()
        {
            InitializeComponent();
        }

        public FRMFormulario2(TextBox txt) : this()
        {
            txtResposta = txt;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            txtResposta.Text = txtRespostaDevolver.Text;

            Close();
        }

        private void FRMFormulario2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
