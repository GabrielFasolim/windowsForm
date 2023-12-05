using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm.Forma2
{
    public partial class FrmForma2Formulario2 : Form
    {

        public string strParametro;
        public string strResposta;

        public FrmForma2Formulario2()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            strResposta = txtRespostaDevolver.Text;
            Close();
        }

        //private void FrmForma2Formulario2_Load(object sender, EventArgs e)
        //{
        //    txtParametroRecebido.Text = strParametro;
        //}

        private void FrmForma2Formulario2_Load(object sender, EventArgs e)
        {
            txtParametroRecebido.Text = strParametro;

        }
    }
}
