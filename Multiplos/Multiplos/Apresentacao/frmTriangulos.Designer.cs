namespace Multiplos.Apresentacao
{
    partial class frmTriangulos
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
            txbLado3 = new TextBox();
            txbLado2 = new TextBox();
            txtLado1 = new TextBox();
            lblLado1 = new Label();
            lblLado2 = new Label();
            lblLado3 = new Label();
            SuspendLayout();
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(36, 210);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 5;
            lblResposta.Text = "Resposta";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(36, 163);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(193, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            // 
            // txbLado3
            // 
            txbLado3.Location = new Point(97, 114);
            txbLado3.Name = "txbLado3";
            txbLado3.Size = new Size(132, 23);
            txbLado3.TabIndex = 3;
            // 
            // txbLado2
            // 
            txbLado2.Location = new Point(97, 73);
            txbLado2.Name = "txbLado2";
            txbLado2.Size = new Size(132, 23);
            txbLado2.TabIndex = 6;
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(97, 32);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(132, 23);
            txtLado1.TabIndex = 7;
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(36, 40);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(42, 15);
            lblLado1.TabIndex = 8;
            lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Location = new Point(36, 81);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(42, 15);
            lblLado2.TabIndex = 9;
            lblLado2.Text = "Lado 2";
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Location = new Point(36, 122);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(42, 15);
            lblLado3.TabIndex = 10;
            lblLado3.Text = "Lado 3";
            // 
            // frmTriangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 266);
            Controls.Add(lblLado3);
            Controls.Add(lblLado2);
            Controls.Add(lblLado1);
            Controls.Add(txtLado1);
            Controls.Add(txbLado2);
            Controls.Add(lblResposta);
            Controls.Add(btnVerificar);
            Controls.Add(txbLado3);
            Name = "frmTriangulos";
            Text = "Triangulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResposta;
        private Button btnVerificar;
        private TextBox txbLado3;
        private TextBox txbLado2;
        private TextBox txtLado1;
        private Label lblLado1;
        private Label lblLado2;
        private Label lblLado3;
    }
}