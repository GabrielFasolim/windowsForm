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
    public partial class FRMFormulario1 : Form
    {
        public FRMFormulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FRMFormulario2 frm = new FRMFormulario2(txtRespostaRecebida);

            frm.txtParametroRecebido.Text = txtParametroEnviar.Text;
           
            frm.Show();
        }
    }
}
