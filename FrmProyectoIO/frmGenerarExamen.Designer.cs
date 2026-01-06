namespace FrmProyectoIO
{
    partial class frmGenerarExamen
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtAltaEPQ = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtAltaEOQ = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtMediaEPQ = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtMediaEOQ = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtFacilEPQ = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtFacilEOQ = new TextBox();
            btnSalir = new Button();
            btnGenerarExamen = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(28, 46, 74);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(9, 307);
            label3.Name = "label3";
            label3.Size = new Size(257, 48);
            label3.TabIndex = 2;
            label3.Text = "Dificultad Fácil:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(9, 235);
            label2.Name = "label2";
            label2.Size = new Size(798, 65);
            label2.TabIndex = 1;
            label2.Text = "¿Cuantos problemas deseas que contenga el examen?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 178);
            label1.TabIndex = 0;
            label1.Text = "Generar Examen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.23671937F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.76328F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 3, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 3, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(btnSalir, 3, 6);
            tableLayoutPanel1.Controls.Add(btnGenerarExamen, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(810, 548);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.14786F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.85214F));
            tableLayoutPanel4.Controls.Add(txtAltaEPQ, 1, 1);
            tableLayoutPanel4.Controls.Add(label11, 0, 0);
            tableLayoutPanel4.Controls.Add(label12, 0, 1);
            tableLayoutPanel4.Controls.Add(txtAltaEOQ, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(575, 358);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(232, 137);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // txtAltaEPQ
            // 
            txtAltaEPQ.Dock = DockStyle.Fill;
            txtAltaEPQ.Font = new Font("Segoe UI", 18F);
            txtAltaEPQ.Location = new Point(156, 71);
            txtAltaEPQ.Name = "txtAltaEPQ";
            txtAltaEPQ.Size = new Size(73, 39);
            txtAltaEPQ.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(28, 46, 74);
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(147, 68);
            label11.TabIndex = 14;
            label11.Text = "Cantidad EOQ:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(28, 46, 74);
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(3, 68);
            label12.Name = "label12";
            label12.Size = new Size(147, 69);
            label12.TabIndex = 15;
            label12.Text = "Cantidad EPQ:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAltaEOQ
            // 
            txtAltaEOQ.Dock = DockStyle.Fill;
            txtAltaEOQ.Font = new Font("Segoe UI", 18F);
            txtAltaEOQ.Location = new Point(156, 3);
            txtAltaEOQ.Name = "txtAltaEOQ";
            txtAltaEOQ.Size = new Size(73, 39);
            txtAltaEOQ.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.14786F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.85214F));
            tableLayoutPanel3.Controls.Add(txtMediaEPQ, 1, 1);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 1);
            tableLayoutPanel3.Controls.Add(txtMediaEOQ, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(272, 358);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(297, 137);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // txtMediaEPQ
            // 
            txtMediaEPQ.Dock = DockStyle.Fill;
            txtMediaEPQ.Font = new Font("Segoe UI", 18F);
            txtMediaEPQ.Location = new Point(199, 71);
            txtMediaEPQ.Name = "txtMediaEPQ";
            txtMediaEPQ.Size = new Size(95, 39);
            txtMediaEPQ.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(28, 46, 74);
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(190, 68);
            label9.TabIndex = 14;
            label9.Text = "Cantidad EOQ:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(28, 46, 74);
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(3, 68);
            label10.Name = "label10";
            label10.Size = new Size(190, 69);
            label10.TabIndex = 15;
            label10.Text = "Cantidad EPQ:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMediaEOQ
            // 
            txtMediaEOQ.Dock = DockStyle.Fill;
            txtMediaEOQ.Font = new Font("Segoe UI", 18F);
            txtMediaEOQ.Location = new Point(199, 3);
            txtMediaEOQ.Name = "txtMediaEOQ";
            txtMediaEOQ.Size = new Size(95, 39);
            txtMediaEOQ.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(28, 46, 74);
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(3, 178);
            label8.Name = "label8";
            label8.Size = new Size(1, 25);
            label8.TabIndex = 10;
            label8.Text = "Dificultad Media:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(28, 46, 74);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(272, 307);
            label4.Name = "label4";
            label4.Size = new Size(297, 48);
            label4.TabIndex = 11;
            label4.Text = "Dificultad Media:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(28, 46, 74);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(575, 307);
            label5.Name = "label5";
            label5.Size = new Size(232, 48);
            label5.TabIndex = 12;
            label5.Text = "Dificultad Alta:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.14786F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.85214F));
            tableLayoutPanel2.Controls.Add(txtFacilEPQ, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(txtFacilEOQ, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(9, 358);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(257, 137);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // txtFacilEPQ
            // 
            txtFacilEPQ.Dock = DockStyle.Fill;
            txtFacilEPQ.Font = new Font("Segoe UI", 18F);
            txtFacilEPQ.Location = new Point(173, 71);
            txtFacilEPQ.Name = "txtFacilEPQ";
            txtFacilEPQ.Size = new Size(81, 39);
            txtFacilEPQ.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(28, 46, 74);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 68);
            label6.TabIndex = 14;
            label6.Text = "Cantidad EOQ:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(28, 46, 74);
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(3, 68);
            label7.Name = "label7";
            label7.Size = new Size(164, 69);
            label7.TabIndex = 15;
            label7.Text = "Cantidad EPQ:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFacilEOQ
            // 
            txtFacilEOQ.Dock = DockStyle.Fill;
            txtFacilEOQ.Font = new Font("Segoe UI", 18F);
            txtFacilEOQ.Location = new Point(173, 3);
            txtFacilEOQ.Name = "txtFacilEOQ";
            txtFacilEOQ.Size = new Size(81, 39);
            txtFacilEOQ.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(28, 46, 74);
            btnSalir.Font = new Font("Microsoft Sans Serif", 15F);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(575, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(232, 44);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.BackColor = Color.FromArgb(28, 46, 74);
            btnGenerarExamen.Font = new Font("Microsoft Sans Serif", 15F);
            btnGenerarExamen.ForeColor = SystemColors.ButtonFace;
            btnGenerarExamen.Location = new Point(9, 501);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(232, 44);
            btnGenerarExamen.TabIndex = 20;
            btnGenerarExamen.Text = "Generar examen";
            btnGenerarExamen.UseVisualStyleBackColor = false;
            btnGenerarExamen.Click += btnGenerarExamen_Click;
            // 
            // frmGenerarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(810, 548);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGenerarExamen";
            Text = "Generar Examen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtAltaEPQ;
        private Label label11;
        private Label label12;
        private TextBox txtAltaEOQ;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtMediaEPQ;
        private Label label9;
        private Label label10;
        private TextBox txtMediaEOQ;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtFacilEPQ;
        private Label label6;
        private Label label7;
        private TextBox txtFacilEOQ;
        private Button btnSalir;
        private Button btnGenerarExamen;
        private Label label8;
    }
}