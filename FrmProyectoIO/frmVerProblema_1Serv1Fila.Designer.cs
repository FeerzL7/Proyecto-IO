namespace FrmProyectoIO
{
    partial class frmVerProblema_1Serv1Fila
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
            txtValorN = new TextBox();
            txtValorM = new TextBox();
            txtValorMEW = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtValorLAMBDA = new TextBox();
            label8 = new Label();
            txtEnunciado = new TextBox();
            btnModificar = new Button();
            btnRegresar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblP = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblPn = new Label();
            lblLs = new Label();
            lblLq = new Label();
            lblWs = new Label();
            lblWq = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(996, 738);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtTitulo
            // 
            tableLayoutPanel1.SetColumnSpan(txtTitulo, 2);
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Segoe UI", 15F);
            txtTitulo.Location = new Point(184, 21);
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
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 44);
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
            cmbDificultad.Location = new Point(184, 73);
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
            label2.Location = new Point(26, 70);
            label2.Name = "label2";
            label2.Size = new Size(152, 70);
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
            label3.Location = new Point(26, 148);
            label3.Name = "label3";
            label3.Size = new Size(152, 33);
            label3.TabIndex = 4;
            label3.Text = "Valores: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9587021F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2536869F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7138634F));
            tableLayoutPanel2.Controls.Add(txtValorN, 3, 1);
            tableLayoutPanel2.Controls.Add(txtValorM, 2, 1);
            tableLayoutPanel2.Controls.Add(txtValorMEW, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 3, 0);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(txtValorLAMBDA, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(26, 192);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(471, 122);
            tableLayoutPanel2.TabIndex = 5;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // txtValorN
            // 
            txtValorN.Dock = DockStyle.Fill;
            txtValorN.Location = new Point(365, 64);
            txtValorN.Multiline = true;
            txtValorN.Name = "txtValorN";
            txtValorN.ReadOnly = true;
            txtValorN.Size = new Size(103, 55);
            txtValorN.TabIndex = 13;
            // 
            // txtValorM
            // 
            txtValorM.Dock = DockStyle.Fill;
            txtValorM.Location = new Point(242, 64);
            txtValorM.Multiline = true;
            txtValorM.Name = "txtValorM";
            txtValorM.ReadOnly = true;
            txtValorM.Size = new Size(117, 55);
            txtValorM.TabIndex = 12;
            // 
            // txtValorMEW
            // 
            txtValorMEW.Dock = DockStyle.Fill;
            txtValorMEW.Location = new Point(120, 64);
            txtValorMEW.Multiline = true;
            txtValorMEW.Name = "txtValorMEW";
            txtValorMEW.ReadOnly = true;
            txtValorMEW.Size = new Size(116, 55);
            txtValorMEW.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label7.Location = new Point(365, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 61);
            label7.TabIndex = 9;
            label7.Text = "N";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label6.Location = new Point(242, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 61);
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
            label5.Location = new Point(120, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 61);
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
            label4.Size = new Size(111, 61);
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
            txtValorLAMBDA.Size = new Size(111, 55);
            txtValorLAMBDA.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSteelBlue;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(26, 326);
            label8.Name = "label8";
            label8.Size = new Size(152, 42);
            label8.TabIndex = 6;
            label8.Text = "Enunciado: ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEnunciado
            // 
            tableLayoutPanel1.SetColumnSpan(txtEnunciado, 3);
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Font = new Font("Segoe UI", 15F);
            txtEnunciado.Location = new Point(26, 379);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(471, 239);
            txtEnunciado.TabIndex = 7;
            // 
            // btnModificar
            // 
            tableLayoutPanel1.SetColumnSpan(btnModificar, 3);
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnModificar.Location = new Point(26, 641);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(471, 58);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegresar.Location = new Point(519, 641);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(443, 58);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1804F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8195953F));
            tableLayoutPanel3.Controls.Add(lblP, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 2);
            tableLayoutPanel3.Controls.Add(label11, 0, 4);
            tableLayoutPanel3.Controls.Add(label12, 0, 6);
            tableLayoutPanel3.Controls.Add(label13, 0, 8);
            tableLayoutPanel3.Controls.Add(label14, 0, 10);
            tableLayoutPanel3.Controls.Add(lblPn, 1, 2);
            tableLayoutPanel3.Controls.Add(lblLs, 1, 4);
            tableLayoutPanel3.Controls.Add(lblLq, 1, 6);
            tableLayoutPanel3.Controls.Add(lblWs, 1, 8);
            tableLayoutPanel3.Controls.Add(lblWq, 1, 10);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(519, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel3, 11);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6678123F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6678162F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6683731F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6665154F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6665154F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6629715F));
            tableLayoutPanel3.Size = new Size(443, 597);
            tableLayoutPanel3.TabIndex = 10;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.BackColor = Color.WhiteSmoke;
            lblP.Dock = DockStyle.Fill;
            lblP.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblP.Location = new Point(141, 0);
            lblP.Name = "lblP";
            lblP.Size = new Size(299, 92);
            lblP.TabIndex = 7;
            lblP.Text = "0";
            lblP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSteelBlue;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 92);
            label9.TabIndex = 1;
            label9.Text = "P:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSteelBlue;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label10.Location = new Point(3, 100);
            label10.Name = "label10";
            label10.Size = new Size(132, 92);
            label10.TabIndex = 2;
            label10.Text = "P(n):";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSteelBlue;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label11.Location = new Point(3, 200);
            label11.Name = "label11";
            label11.Size = new Size(132, 92);
            label11.TabIndex = 3;
            label11.Text = "Ls:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSteelBlue;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label12.Location = new Point(3, 300);
            label12.Name = "label12";
            label12.Size = new Size(132, 92);
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
            label13.Location = new Point(3, 400);
            label13.Name = "label13";
            label13.Size = new Size(132, 92);
            label13.TabIndex = 5;
            label13.Text = "Ws:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightSteelBlue;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label14.Location = new Point(3, 500);
            label14.Name = "label14";
            label14.Size = new Size(132, 97);
            label14.TabIndex = 6;
            label14.Text = "Wq:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPn
            // 
            lblPn.AutoSize = true;
            lblPn.BackColor = Color.WhiteSmoke;
            lblPn.Dock = DockStyle.Fill;
            lblPn.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPn.Location = new Point(141, 100);
            lblPn.Name = "lblPn";
            lblPn.Size = new Size(299, 92);
            lblPn.TabIndex = 8;
            lblPn.Text = "0";
            lblPn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLs
            // 
            lblLs.AutoSize = true;
            lblLs.BackColor = Color.WhiteSmoke;
            lblLs.Dock = DockStyle.Fill;
            lblLs.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLs.Location = new Point(141, 200);
            lblLs.Name = "lblLs";
            lblLs.Size = new Size(299, 92);
            lblLs.TabIndex = 9;
            lblLs.Text = "0";
            lblLs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLq
            // 
            lblLq.AutoSize = true;
            lblLq.BackColor = Color.WhiteSmoke;
            lblLq.Dock = DockStyle.Fill;
            lblLq.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLq.Location = new Point(141, 300);
            lblLq.Name = "lblLq";
            lblLq.Size = new Size(299, 92);
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
            lblWs.Location = new Point(141, 400);
            lblWs.Name = "lblWs";
            lblWs.Size = new Size(299, 92);
            lblWs.TabIndex = 11;
            lblWs.Text = "0";
            lblWs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWq
            // 
            lblWq.AutoSize = true;
            lblWq.BackColor = Color.WhiteSmoke;
            lblWq.Dock = DockStyle.Fill;
            lblWq.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblWq.Location = new Point(141, 500);
            lblWq.Name = "lblWq";
            lblWq.Size = new Size(299, 97);
            lblWq.TabIndex = 12;
            lblWq.Text = "0";
            lblWq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmVerProblema_1Serv1Fila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 46, 74);
            ClientSize = new Size(996, 738);
            Controls.Add(tableLayoutPanel1);
            Name = "frmVerProblema_1Serv1Fila";
            Text = "frmVerProblema_1Serv1Fila";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private ComboBox cmbDificultad;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtEnunciado;
        private TextBox txtValorN;
        private TextBox txtValorM;
        private TextBox txtValorMEW;
        private TextBox txtValorLAMBDA;
        private Button btnModificar;
        private Button btnRegresar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblP;
        private Label lblPn;
        private Label lblLs;
        private Label lblLq;
        private Label lblWs;
        private Label lblWq;
    }
}