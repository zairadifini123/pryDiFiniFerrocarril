namespace pryDiFiniFerrocarril
{
    partial class FrmFerrocaril
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
            lblDistancia = new Label();
            txtDistancia = new TextBox();
            lblDias = new Label();
            dudDias = new DomainUpDown();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistancia.Location = new Point(37, 68);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(113, 32);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(147, 71);
            txtDistancia.Margin = new Padding(3, 4, 3, 4);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(215, 27);
            txtDistancia.TabIndex = 1;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(37, 130);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(196, 32);
            lblDias.TabIndex = 2;
            lblDias.Text = "Cantidad de dias";
            // 
            // dudDias
            // 
            dudDias.Location = new Point(239, 135);
            dudDias.Name = "dudDias";
            dudDias.Size = new Size(123, 27);
            dudDias.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(37, 263);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(268, 188);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FrmFerrocaril
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 475);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(dudDias);
            Controls.Add(lblDias);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmFerrocaril";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular boletos ferrocarril";
            Load += FrmFerrocaril_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private TextBox txtDistancia;
        private Label lblDias;
        private DomainUpDown dudDias;
        private Label lblResultado;
        private Button btnCalcular;
    }
}
