﻿namespace windowsForm.Forma3
{
    partial class FrmForma3Formulario1
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
            btnEnviar = new Button();
            label2 = new Label();
            txtRespostaRecebida = new TextBox();
            label1 = new Label();
            txtParametroEnviar = new TextBox();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(129, 94);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(161, 27);
            btnEnviar.TabIndex = 24;
            btnEnviar.Text = "Enviar para form 2";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 143);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 23;
            label2.Text = "Resposta recebida";
            // 
            // txtRespostaRecebida
            // 
            txtRespostaRecebida.Font = new Font("Segoe UI", 12F);
            txtRespostaRecebida.Location = new Point(14, 170);
            txtRespostaRecebida.Margin = new Padding(5, 6, 5, 6);
            txtRespostaRecebida.Name = "txtRespostaRecebida";
            txtRespostaRecebida.Size = new Size(276, 29);
            txtRespostaRecebida.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 21;
            label1.Text = "Parâmetro para enviar ";
            // 
            // txtParametroEnviar
            // 
            txtParametroEnviar.Font = new Font("Segoe UI", 12F);
            txtParametroEnviar.Location = new Point(14, 47);
            txtParametroEnviar.Margin = new Padding(5, 6, 5, 6);
            txtParametroEnviar.Name = "txtParametroEnviar";
            txtParametroEnviar.Size = new Size(276, 29);
            txtParametroEnviar.TabIndex = 20;
            // 
            // FrmForma3Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 278);
            Controls.Add(btnEnviar);
            Controls.Add(label2);
            Controls.Add(txtRespostaRecebida);
            Controls.Add(label1);
            Controls.Add(txtParametroEnviar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmForma3Formulario1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "FrmForma3Formulario1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label label2;
        private TextBox txtRespostaRecebida;
        private Label label1;
        private TextBox txtParametroEnviar;
    }
}