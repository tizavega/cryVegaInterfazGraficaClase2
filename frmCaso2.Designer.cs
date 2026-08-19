namespace cryVegaInterfazGrafica
{
    partial class frmCaso2
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
            lblCritico = new Label();
            lblAlto = new Label();
            lblMedio = new Label();
            lblBajo = new Label();
            lblResultadoBajo = new Label();
            lblResultadoMedio = new Label();
            lblResultadoAlto = new Label();
            lblResultadoCritico = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(22, 24);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(42, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "Critico";
            lblCritico.Click += lblCritico_Click;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(22, 57);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(29, 15);
            lblAlto.TabIndex = 1;
            lblAlto.Text = "Alto";
            lblAlto.Click += lblAlto_Click;
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(22, 92);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(41, 15);
            lblMedio.TabIndex = 2;
            lblMedio.Text = "Medio";
            lblMedio.Click += lblMedio_Click;
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(22, 127);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(30, 15);
            lblBajo.TabIndex = 3;
            lblBajo.Text = "Bajo";
            lblBajo.Click += lblBajo_Click;
            // 
            // lblResultadoBajo
            // 
            lblResultadoBajo.AutoSize = true;
            lblResultadoBajo.Location = new Point(95, 127);
            lblResultadoBajo.Name = "lblResultadoBajo";
            lblResultadoBajo.Size = new Size(12, 15);
            lblResultadoBajo.TabIndex = 7;
            lblResultadoBajo.Text = "-";
            // 
            // lblResultadoMedio
            // 
            lblResultadoMedio.AutoSize = true;
            lblResultadoMedio.Location = new Point(95, 92);
            lblResultadoMedio.Name = "lblResultadoMedio";
            lblResultadoMedio.Size = new Size(12, 15);
            lblResultadoMedio.TabIndex = 6;
            lblResultadoMedio.Text = "-";
            // 
            // lblResultadoAlto
            // 
            lblResultadoAlto.AutoSize = true;
            lblResultadoAlto.Location = new Point(95, 57);
            lblResultadoAlto.Name = "lblResultadoAlto";
            lblResultadoAlto.Size = new Size(12, 15);
            lblResultadoAlto.TabIndex = 5;
            lblResultadoAlto.Text = "-";
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(95, 24);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 4;
            lblResultadoCritico.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(169, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 27);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(169, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 27);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(169, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 29);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(169, 113);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 29);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // frmCaso2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 198);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultadoBajo);
            Controls.Add(lblResultadoMedio);
            Controls.Add(lblResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            Name = "frmCaso2";
            Text = "SOC--INCIDENTES";
            Load += frmCaso2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label lblResultadoBajo;
        private Label lblResultadoMedio;
        private Label lblResultadoAlto;
        private Label lblResultadoCritico;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}