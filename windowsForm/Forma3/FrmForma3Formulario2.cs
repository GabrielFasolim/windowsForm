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
    public partial class FrmForma3Formulario2 : Form
    {
        public string Parametro
        { 
            set
            { 
                txtParametroRecebido.Text = value;
            } 
        }

        public string Resposta
        {
            get 
            {
               return txtRespostaDevolver.Text;
               
            }

        }


        public FrmForma3Formulario2()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
