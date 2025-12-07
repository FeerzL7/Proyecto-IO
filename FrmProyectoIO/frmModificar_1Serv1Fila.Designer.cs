namespace FrmProyectoIO
{
    partial class frmModificar_1Serv1Fila
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblP = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button1 = new Button();
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
            tableLayoutPanel1.Size = new Size(1005, 746);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTitulo
            // 
            tableLayoutPanel1.SetColumnSpan(txtTitulo, 2);
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Segoe UI", 15F);
            txtTitulo.Location = new Point(193, 23);
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
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(160, 50);
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
            cmbDificultad.Location = new Point(193, 81);
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
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(160, 70);
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
            label3.Location = new Point(27, 156);
            label3.Name = "label3";
            label3.Size = new Size(160, 33);
            label3.TabIndex = 4;
            label3.Text = "Valores: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel2.Location = new Point(27, 200);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(479, 122);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // txtValorN
            // 
            txtValorN.Dock = DockStyle.Fill;
            txtValorN.Location = new Point(371, 64);
            txtValorN.Multiline = true;
            txtValorN.Name = "txtValorN";
            txtValorN.ReadOnly = true;
            txtValorN.Size = new Size(105, 55);
            txtValorN.TabIndex = 13;
            // 
            // txtValorM
            // 
            txtValorM.Dock = DockStyle.Fill;
            txtValorM.Location = new Point(246, 64);
            txtValorM.Multiline = true;
            txtValorM.Name = "txtValorM";
            txtValorM.ReadOnly = true;
            txtValorM.Size = new Size(119, 55);
            txtValorM.TabIndex = 12;
            // 
            // txtValorMEW
            // 
            txtValorMEW.Dock = DockStyle.Fill;
            txtValorMEW.Location = new Point(122, 64);
            txtValorMEW.Multiline = true;
            txtValorMEW.Name = "txtValorMEW";
            txtValorMEW.ReadOnly = true;
            txtValorMEW.Size = new Size(118, 55);
            txtValorMEW.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label7.Location = new Point(371, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 61);
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
            label6.Location = new Point(246, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 61);
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
            label5.Location = new Point(122, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 61);
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
            label4.Size = new Size(113, 61);
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
            txtValorLAMBDA.Size = new Size(113, 55);
            txtValorLAMBDA.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSteelBlue;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(27, 334);
            label8.Name = "label8";
            label8.Size = new Size(160, 42);
            label8.TabIndex = 6;
            label8.Text = "Enunciado: ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEnunciado
            // 
            tableLayoutPanel1.SetColumnSpan(txtEnunciado, 3);
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Font = new Font("Segoe UI", 15F);
            txtEnunciado.Location = new Point(27, 387);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(479, 239);
            txtEnunciado.TabIndex = 7;
            // 
            // btnModificar
            // 
            tableLayoutPanel1.SetColumnSpan(btnModificar, 3);
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnModificar.Location = new Point(27, 649);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(479, 58);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegresar.Location = new Point(528, 649);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(443, 58);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6997738F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.3002243F));
            tableLayoutPanel3.Controls.Add(lblP, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 12);
            tableLayoutPanel3.Controls.Add(label10, 0, 2);
            tableLayoutPanel3.Controls.Add(label11, 0, 4);
            tableLayoutPanel3.Controls.Add(label12, 0, 6);
            tableLayoutPanel3.Controls.Add(label13, 0, 8);
            tableLayoutPanel3.Controls.Add(label14, 0, 10);
            tableLayoutPanel3.Controls.Add(label15, 1, 2);
            tableLayoutPanel3.Controls.Add(label16, 1, 4);
            tableLayoutPanel3.Controls.Add(label17, 1, 6);
            tableLayoutPanel3.Controls.Add(label18, 1, 8);
            tableLayoutPanel3.Controls.Add(label19, 1, 10);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(528, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 13;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel3, 11);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.36144F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.638555F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel3.Size = new Size(443, 603);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 506);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(437, 94);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSteelBlue;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 76);
            label9.TabIndex = 2;
            label9.Text = "P:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSteelBlue;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label10.Location = new Point(3, 84);
            label10.Name = "label10";
            label10.Size = new Size(130, 72);
            label10.TabIndex = 3;
            label10.Text = "P(n):";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSteelBlue;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label11.Location = new Point(3, 164);
            label11.Name = "label11";
            label11.Size = new Size(130, 76);
            label11.TabIndex = 4;
            label11.Text = "Ls:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSteelBlue;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label12.Location = new Point(3, 248);
            label12.Name = "label12";
            label12.Size = new Size(130, 78);
            label12.TabIndex = 5;
            label12.Text = "Lq:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightSteelBlue;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label13.Location = new Point(3, 334);
            label13.Name = "label13";
            label13.Size = new Size(130, 77);
            label13.TabIndex = 6;
            label13.Text = "Ws:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightSteelBlue;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label14.Location = new Point(3, 419);
            label14.Name = "label14";
            label14.Size = new Size(130, 76);
            label14.TabIndex = 7;
            label14.Text = "Wq:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.BackColor = Color.WhiteSmoke;
            lblP.Dock = DockStyle.Fill;
            lblP.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblP.Location = new Point(139, 0);
            lblP.Name = "lblP";
            lblP.Size = new Size(301, 76);
            lblP.TabIndex = 8;
            lblP.Text = "0";
            lblP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.WhiteSmoke;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label15.Location = new Point(139, 84);
            label15.Name = "label15";
            label15.Size = new Size(301, 72);
            label15.TabIndex = 9;
            label15.Text = "0";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.WhiteSmoke;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label16.Location = new Point(139, 164);
            label16.Name = "label16";
            label16.Size = new Size(301, 76);
            label16.TabIndex = 10;
            label16.Text = "0";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.WhiteSmoke;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label17.Location = new Point(139, 248);
            label17.Name = "label17";
            label17.Size = new Size(301, 78);
            label17.TabIndex = 11;
            label17.Text = "0";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.WhiteSmoke;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label18.Location = new Point(139, 334);
            label18.Name = "label18";
            label18.Size = new Size(301, 77);
            label18.TabIndex = 12;
            label18.Text = "0";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.WhiteSmoke;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label19.Location = new Point(139, 419);
            label19.Name = "label19";
            label19.Size = new Size(301, 76);
            label19.TabIndex = 13;
            label19.Text = "0";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            tableLayoutPanel4.SetColumnSpan(button1, 3);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(431, 88);
            button1.TabIndex = 9;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmModificar_1Serv1Fila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 46, 74);
            ClientSize = new Size(1005, 746);
            Controls.Add(tableLayoutPanel1);
            Name = "frmModificar_1Serv1Fila";
            Text = "frmModificar_1Serv1Fila";
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
        private TextBox txtValorN;
        private TextBox txtValorM;
        private TextBox txtValorMEW;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtValorLAMBDA;
        private Label label8;
        private TextBox txtEnunciado;
        private Button btnModificar;
        private Button btnRegresar;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblP;
        private Button button1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}