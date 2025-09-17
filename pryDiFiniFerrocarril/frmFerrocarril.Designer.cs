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
            txtDias = new TextBox();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistancia.Location = new Point(32, 51);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(91, 25);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(129, 53);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(189, 23);
            txtDistancia.TabIndex = 1;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(32, 124);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(154, 25);
            lblDias.TabIndex = 2;
            lblDias.Text = "Cantidad de dias";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(192, 124);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(98, 23);
            txtDias.TabIndex = 3;
            // 
            // FrmFerrocaril
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 356);
            Controls.Add(txtDias);
            Controls.Add(lblDias);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Name = "FrmFerrocaril";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular boletos ferrocarril";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private TextBox txtDistancia;
        private Label lblDias;
        private TextBox txtDias;
    }
}
