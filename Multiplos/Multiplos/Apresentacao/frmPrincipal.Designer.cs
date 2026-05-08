namespace Multiplos
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsCalculos = new MenuStrip();
            tsmCalculos = new ToolStripMenuItem();
            tsmPrimo = new ToolStripMenuItem();
            tsmTriangulos = new ToolStripMenuItem();
            tsmFatorial = new ToolStripMenuItem();
            mnsCalculos.SuspendLayout();
            SuspendLayout();
            // 
            // mnsCalculos
            // 
            mnsCalculos.Items.AddRange(new ToolStripItem[] { tsmCalculos });
            mnsCalculos.Location = new Point(0, 0);
            mnsCalculos.Name = "mnsCalculos";
            mnsCalculos.Size = new Size(274, 24);
            mnsCalculos.TabIndex = 0;
            mnsCalculos.TabStop = true;
            mnsCalculos.Text = "mnsCalculos";
            // 
            // tsmCalculos
            // 
            tsmCalculos.DropDownItems.AddRange(new ToolStripItem[] { tsmPrimo, tsmTriangulos, tsmFatorial });
            tsmCalculos.Name = "tsmCalculos";
            tsmCalculos.Size = new Size(64, 20);
            tsmCalculos.Text = "Calculos";
            // 
            // tsmPrimo
            // 
            tsmPrimo.Name = "tsmPrimo";
            tsmPrimo.Size = new Size(180, 22);
            tsmPrimo.Text = "Primo";
            // 
            // tsmTriangulos
            // 
            tsmTriangulos.Name = "tsmTriangulos";
            tsmTriangulos.Size = new Size(180, 22);
            tsmTriangulos.Text = "Triangulos";
            // 
            // tsmFatorial
            // 
            tsmFatorial.Name = "tsmFatorial";
            tsmFatorial.Size = new Size(180, 22);
            tsmFatorial.Text = "Fatorial";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 174);
            Controls.Add(mnsCalculos);
            MainMenuStrip = mnsCalculos;
            Name = "frmPrincipal";
            Text = "Múltiplos";
            mnsCalculos.ResumeLayout(false);
            mnsCalculos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsCalculos;
        private ToolStripMenuItem tsmCalculos;
        private ToolStripMenuItem tsmPrimo;
        private ToolStripMenuItem tsmTriangulos;
        private ToolStripMenuItem tsmFatorial;
    }
}
