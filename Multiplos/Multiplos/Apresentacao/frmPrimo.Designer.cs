namespace Multiplos.Apresentacao
{
    partial class frmPrimo
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
            lblResposta = new Label();
            btnVerificar = new Button();
            txbNumero = new TextBox();
            SuspendLayout();
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(47, 135);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 5;
            lblResposta.Text = "Resposta";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(47, 87);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(132, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            // 
            // txbNumero
            // 
            txbNumero.Location = new Point(47, 41);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(132, 23);
            txbNumero.TabIndex = 3;
            // 
            // frmPrimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 183);
            Controls.Add(lblResposta);
            Controls.Add(btnVerificar);
            Controls.Add(txbNumero);
            Name = "frmPrimo";
            Text = "Primo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResposta;
        private Button btnVerificar;
        private TextBox txbNumero;
    }
}