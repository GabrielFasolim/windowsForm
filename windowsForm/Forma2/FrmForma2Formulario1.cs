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
    public partial class FrmForma2Formulario1 : Form
    {
        public FrmForma2Formulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmForma2Formulario2 frm = new FrmForma2Formulario2();
            frm.strParametro = txtParametroEnviar.Text;
            txtRespostaRecebida.Text = frm.strResposta;
            frm.ShowDialog();

        }

        private void txtParametroEnviar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
