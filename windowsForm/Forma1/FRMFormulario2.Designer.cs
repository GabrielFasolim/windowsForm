namespace windowsForm.Forma1
{
    partial class FRMFormulario2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDevolver = new Button();
            label2 = new Label();
            txtRespostaDevolver = new TextBox();
            label1 = new Label();
            txtParametroRecebido = new TextBox();
            SuspendLayout();
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(153, 195);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(161, 27);
            btnDevolver.TabIndex = 9;
            btnDevolver.Text = "Devolver para form 1";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 8;
            label2.Text = "Resposta para devolver";
            // 
            // txtRespostaDevolver
            // 
            txtRespostaDevolver.Font = new Font("Segoe UI", 12F);
            txtRespostaDevolver.Location = new Point(13, 142);
            txtRespostaDevolver.Margin = new Padding(4);
            txtRespostaDevolver.Name = "txtRespostaDevolver";
            txtRespostaDevolver.Size = new Size(301, 29);
            txtRespostaDevolver.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 6;
            label1.Text = "Parâmetro Recebido ";
            label1.Click += label1_Click;
            // 
            // txtParametroRecebido
            // 
            txtParametroRecebido.Font = new Font("Segoe UI", 12F);
            txtParametroRecebido.Location = new Point(13, 54);
            txtParametroRecebido.Margin = new Padding(4);
            txtParametroRecebido.Name = "txtParametroRecebido";
            txtParametroRecebido.Size = new Size(301, 29);
            txtParametroRecebido.TabIndex = 5;
            // 
            // FRMFormulario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 278);
            Controls.Add(btnDevolver);
            Controls.Add(label2);
            Controls.Add(txtRespostaDevolver);
            Controls.Add(label1);
            Controls.Add(txtParametroRecebido);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMFormulario2";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "FRMFormulario2";
            Load += FRMFormulario2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDevolver;
        private Label label2;
        private TextBox txtRespostaDevolver;
        private Label label1;
        public TextBox txtParametroRecebido;
    }
}