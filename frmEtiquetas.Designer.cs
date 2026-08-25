namespace cryVegaInterfazGrafica
{
    partial class frmEtiquetas
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
            lblAltaDeMedicamento = new Label();
            lblCodigo = new Label();
            lblMedicamento = new Label();
            lblLaboratorio = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            txtMedicamento = new TextBox();
            txtLaboratorio = new TextBox();
            txtCategoria = new TextBox();
            btnIngresar = new Button();
            listBox1 = new ListBox();
            nudCodigo = new NumericUpDown();
            nduPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nduPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblAltaDeMedicamento
            // 
            lblAltaDeMedicamento.AutoSize = true;
            lblAltaDeMedicamento.Location = new Point(96, 35);
            lblAltaDeMedicamento.Name = "lblAltaDeMedicamento";
            lblAltaDeMedicamento.Size = new Size(122, 15);
            lblAltaDeMedicamento.TabIndex = 0;
            lblAltaDeMedicamento.Text = "Alta De Medicamento";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(29, 87);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(29, 131);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 2;
            lblMedicamento.Text = "Medicamento";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(29, 175);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 3;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(29, 219);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría";
            lblCategoria.Click += label5_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(29, 263);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(168, 128);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 7;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(168, 172);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(168, 216);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 9;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(168, 308);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(95, 27);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(29, 351);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(239, 94);
            listBox1.TabIndex = 12;
            // 
            // nudCodigo
            // 
            nudCodigo.Location = new Point(168, 85);
            nudCodigo.Name = "nudCodigo";
            nudCodigo.Size = new Size(95, 23);
            nudCodigo.TabIndex = 13;
            nudCodigo.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // nduPrecio
            // 
            nduPrecio.Location = new Point(168, 261);
            nduPrecio.Name = "nduPrecio";
            nduPrecio.Size = new Size(100, 23);
            nduPrecio.TabIndex = 14;
            // 
            // frmEtiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 457);
            Controls.Add(nduPrecio);
            Controls.Add(nudCodigo);
            Controls.Add(listBox1);
            Controls.Add(btnIngresar);
            Controls.Add(txtCategoria);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtMedicamento);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaDeMedicamento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEtiquetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacia";
            Load += frmEtiquetas_Load;
            ((System.ComponentModel.ISupportInitialize)nudCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nduPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaDeMedicamento;
        private Label lblCodigo;
        private Label lblMedicamento;
        private Label lblLaboratorio;
        private Label lblCategoria;
        private Label lblPrecio;
        private TextBox txtMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private Button btnIngresar;
        private ListBox listBox1;
        private NumericUpDown nudCodigo;
        private NumericUpDown nduPrecio;
    }
}