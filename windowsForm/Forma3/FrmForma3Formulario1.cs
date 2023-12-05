using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm.Forma3
{
    public partial class FrmForma3Formulario1 : Form
    {
        public FrmForma3Formulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmForma3Formulario2 frm = new FrmForma3Formulario2();
            frm.Parametro = txtParametroEnviar.Text;
            
           
            frm.ShowDialog();

            txtRespostaRecebida.Text = frm.Resposta;
            
            
        }
    }
}
