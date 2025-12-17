namespace FrmProyectoIO
{
    partial class frmEOQModificar_1FilaMultServ
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTitulo = new TextBox();
            label1 = new Label();
            cmbDificultad = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtValorM = new TextBox();
            txtValorMEW = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtValorLAMBDA = new TextBox();
            label8 = new Label();
            txtEnunciado = new TextBox();
            btnModificar = new Button();
            btnRegresar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblP0 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblLs = new Label();
            lblLq = new Label();
            lblWs = new Label();
            lblWQ = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCalcular = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7071819F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.2928162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 223F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 449F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(txtTitulo, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbDificultad, 2, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 7);
            tableLayoutPanel1.Controls.Add(label8, 1, 9);
            tableLayoutPanel1.Controls.Add(txtEnunciado, 1, 11);
            tableLayoutPanel1.Controls.Add(btnModificar, 1, 13);
            tableLayoutPanel1.Controls.Add(btnRegresar, 5, 13);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.2682934F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.7317047F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(989, 749);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtTitulo
            // 
            tableLayoutPanel1.SetColumnSpan(txtTitulo, 2);
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Segoe UI", 15F);
            txtTitulo.Location = new Point(175, 24);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(313, 41);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(145, 52);
            label1.TabIndex = 0;
            label1.Text = "Titulo: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbDificultad
            // 
            tableLayoutPanel1.SetColumnSpan(cmbDificultad, 2);
            cmbDificultad.Dock = DockStyle.Fill;
            cmbDificultad.Enabled = false;
            cmbDificultad.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Location = new Point(175, 84);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(313, 53);
            cmbDificultad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(145, 69);
            label2.TabIndex = 2;
            label2.Text = "Nivel de Dificultad";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(24, 158);
            label3.Name = "label3";
            label3.Size = new Size(145, 33);
            label3.TabIndex = 4;
            label3.Text = "Valores: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9587021F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2536869F));
            tableLayoutPanel2.Controls.Add(txtValorM, 2, 1);
            tableLayoutPanel2.Controls.Add(txtValorMEW, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(txtValorLAMBDA, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(24, 202);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(464, 122);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // txtValorM
            // 
            txtValorM.Dock = DockStyle.Fill;
            txtValorM.Location = new Point(308, 64);
            txtValorM.Multiline = true;
            txtValorM.Name = "txtValorM";
            txtValorM.ReadOnly = true;
            txtValorM.Size = new Size(153, 55);
            txtValorM.TabIndex = 12;
            // 
            // txtValorMEW
            // 
            txtValorMEW.Dock = DockStyle.Fill;
            txtValorMEW.Location = new Point(153, 64);
            txtValorMEW.Multiline = true;
            txtValorMEW.Name = "txtValorMEW";
            txtValorMEW.ReadOnly = true;
            txtValorMEW.Size = new Size(149, 55);
            txtValorMEW.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label6.Location = new Point(308, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 61);
            label6.TabIndex = 8;
            label6.Text = "M";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSteelBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label5.Location = new Point(153, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 61);
            label5.TabIndex = 7;
            label5.Text = "μ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 61);
            label4.TabIndex = 6;
            label4.Text = "λ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorLAMBDA
            // 
            txtValorLAMBDA.Dock = DockStyle.Fill;
            txtValorLAMBDA.Location = new Point(3, 64);
            txtValorLAMBDA.Multiline = true;
            txtValorLAMBDA.Name = "txtValorLAMBDA";
            txtValorLAMBDA.ReadOnly = true;
            txtValorLAMBDA.Size = new Size(144, 55);
            txtValorLAMBDA.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSteelBlue;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(24, 336);
            label8.Name = "label8";
            label8.Size = new Size(145, 43);
            label8.TabIndex = 6;
            label8.Text = "Enunciado: ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEnunciado
            // 
            tableLayoutPanel1.SetColumnSpan(txtEnunciado, 3);
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Font = new Font("Segoe UI", 15F);
            txtEnunciado.Location = new Point(24, 390);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(464, 239);
            txtEnunciado.TabIndex = 7;
            // 
            // btnModificar
            // 
            tableLayoutPanel1.SetColumnSpan(btnModificar, 3);
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnModificar.Location = new Point(24, 652);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(464, 58);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegresar.Location = new Point(510, 652);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(443, 58);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9593678F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.0406342F));
            tableLayoutPanel3.Controls.Add(lblP0, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 2);
            tableLayoutPanel3.Controls.Add(label11, 0, 4);
            tableLayoutPanel3.Controls.Add(label12, 0, 6);
            tableLayoutPanel3.Controls.Add(label13, 0, 8);
            tableLayoutPanel3.Controls.Add(lblLs, 1, 2);
            tableLayoutPanel3.Controls.Add(lblLq, 1, 6);
            tableLayoutPanel3.Controls.Add(lblWs, 1, 4);
            tableLayoutPanel3.Controls.Add(lblWQ, 1, 8);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 10);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(510, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 12;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel3, 11);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6678123F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6678162F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6683731F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6665154F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6665154F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.Size = new Size(443, 605);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // lblP0
            // 
            lblP0.AutoSize = true;
            lblP0.BackColor = Color.WhiteSmoke;
            lblP0.Dock = DockStyle.Fill;
            lblP0.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblP0.Location = new Point(118, 0);
            lblP0.Name = "lblP0";
            lblP0.Size = new Size(322, 94);
            lblP0.TabIndex = 7;
            lblP0.Text = "0";
            lblP0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSteelBlue;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 94);
            label9.TabIndex = 1;
            label9.Text = "P0:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSteelBlue;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label10.Location = new Point(3, 105);
            label10.Name = "label10";
            label10.Size = new Size(109, 94);
            label10.TabIndex = 2;
            label10.Text = "Ls:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSteelBlue;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label11.Location = new Point(3, 208);
            label11.Name = "label11";
            label11.Size = new Size(109, 94);
            label11.TabIndex = 3;
            label11.Text = "Ws:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSteelBlue;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label12.Location = new Point(3, 310);
            label12.Name = "label12";
            label12.Size = new Size(109, 94);
            label12.TabIndex = 4;
            label12.Text = "Lq:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightSteelBlue;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label13.Location = new Point(3, 412);
            label13.Name = "label13";
            label13.Size = new Size(109, 94);
            label13.TabIndex = 5;
            label13.Text = "Wq:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLs
            // 
            lblLs.AutoSize = true;
            lblLs.BackColor = Color.WhiteSmoke;
            lblLs.Dock = DockStyle.Fill;
            lblLs.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLs.Location = new Point(118, 105);
            lblLs.Name = "lblLs";
            lblLs.Size = new Size(322, 94);
            lblLs.TabIndex = 8;
            lblLs.Text = "0";
            lblLs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLq
            // 
            lblLq.AutoSize = true;
            lblLq.BackColor = Color.WhiteSmoke;
            lblLq.Dock = DockStyle.Fill;
            lblLq.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLq.Location = new Point(118, 310);
            lblLq.Name = "lblLq";
            lblLq.Size = new Size(322, 94);
            lblLq.TabIndex = 10;
            lblLq.Text = "0";
            lblLq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWs
            // 
            lblWs.AutoSize = true;
            lblWs.BackColor = Color.WhiteSmoke;
            lblWs.Dock = DockStyle.Fill;
            lblWs.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblWs.Location = new Point(118, 208);
            lblWs.Name = "lblWs";
            lblWs.Size = new Size(322, 94);
            lblWs.TabIndex = 11;
            lblWs.Text = "0";
            lblWs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWQ
            // 
            lblWQ.AutoSize = true;
            lblWQ.BackColor = Color.WhiteSmoke;
            lblWQ.Dock = DockStyle.Fill;
            lblWQ.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblWQ.Location = new Point(118, 412);
            lblWQ.Name = "lblWQ";
            lblWQ.Size = new Size(322, 94);
            lblWQ.TabIndex = 12;
            lblWQ.Text = "0";
            lblWQ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnCalcular, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 520);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(437, 82);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.Dock = DockStyle.Fill;
            btnCalcular.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCalcular.Location = new Point(3, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(431, 76);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "MODIFICAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // frmEOQModificar_1FilaMultServ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 46, 74);
            ClientSize = new Size(989, 749);
            Controls.Add(tableLayoutPanel1);
            Name = "frmEOQModificar_1FilaMultServ";
            Text = "frmEOQModificar_1FilaMultServ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTitulo;
        private Label label1;
        private ComboBox cmbDificultad;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtValorM;
        private TextBox txtValorMEW;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtValorLAMBDA;
        private Label label8;
        private TextBox txtEnunciado;
        private Button btnModificar;
        private Button btnRegresar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblP0;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblLs;
        private Label lblLq;
        private Label lblWs;
        private Label lblWQ;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCalcular;
    }
}
