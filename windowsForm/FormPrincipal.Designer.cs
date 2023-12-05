namespace windowsForm
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            forma1ToolStripMenuItem = new ToolStripMenuItem();
            forma2ToolStripMenuItem = new ToolStripMenuItem();
            forma3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { forma1ToolStripMenuItem, forma2ToolStripMenuItem, forma3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // forma1ToolStripMenuItem
            // 
            forma1ToolStripMenuItem.Name = "forma1ToolStripMenuItem";
            forma1ToolStripMenuItem.Size = new Size(59, 20);
            forma1ToolStripMenuItem.Text = "Forma1";
            forma1ToolStripMenuItem.Click += forma1ToolStripMenuItem_Click;
            // 
            // forma2ToolStripMenuItem
            // 
            forma2ToolStripMenuItem.Name = "forma2ToolStripMenuItem";
            forma2ToolStripMenuItem.Size = new Size(59, 20);
            forma2ToolStripMenuItem.Text = "Forma2";
            forma2ToolStripMenuItem.Click += forma2ToolStripMenuItem_Click;
            // 
            // forma3ToolStripMenuItem
            // 
            forma3ToolStripMenuItem.Name = "forma3ToolStripMenuItem";
            forma3ToolStripMenuItem.Size = new Size(59, 20);
            forma3ToolStripMenuItem.Text = "Forma3";
            forma3ToolStripMenuItem.Click += forma3ToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem forma1ToolStripMenuItem;
        private ToolStripMenuItem forma2ToolStripMenuItem;
        private ToolStripMenuItem forma3ToolStripMenuItem;
    }
}