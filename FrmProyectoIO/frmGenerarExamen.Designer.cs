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
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGenerar = new Button();
            txtDAlta = new TextBox();
            label5 = new Label();
            label9 = new Label();
            txtDBaja = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.23671937F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.76328F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 204F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 8);
            tableLayoutPanel1.Controls.Add(txtDAlta, 2, 6);
            tableLayoutPanel1.Controls.Add(label5, 6, 4);
            tableLayoutPanel1.Controls.Add(label9, 6, 6);
            tableLayoutPanel1.Controls.Add(txtDBaja, 7, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.Size = new Size(1199, 436);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(28, 46, 74);
            label8.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(3, 75);
            label8.Name = "label8";
            label8.Size = new Size(1, 23);
            label8.TabIndex = 10;
            label8.Text = "Dificultad Media:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label1, 10);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cooper Black", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1193, 75);
            label1.TabIndex = 0;
            label1.Text = "Generar Examen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label2, 9);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(1190, 29);
            label2.TabIndex = 1;
            label2.Text = "¿Cuantos problemas deseas que contenga el examen?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label3, 3);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(572, 62);
            label3.TabIndex = 2;
            label3.Text = "Dificultad Alta:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(28, 46, 74);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(6, 208);
            label6.Name = "label6";
            label6.Size = new Size(148, 52);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1782475F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.8217545F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Controls.Add(btnGenerar, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(364, 268);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel2.Size = new Size(417, 166);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(28, 46, 74);
            btnGenerar.Dock = DockStyle.Fill;
            btnGenerar.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = SystemColors.ControlLightLight;
            btnGenerar.Location = new Point(45, 17);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(330, 132);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtDAlta
            // 
            tableLayoutPanel1.SetColumnSpan(txtDAlta, 2);
            txtDAlta.Dock = DockStyle.Fill;
            txtDAlta.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDAlta.Location = new Point(160, 210);
            txtDAlta.Margin = new Padding(3, 2, 3, 2);
            txtDAlta.Multiline = true;
            txtDAlta.Name = "txtDAlta";
            txtDAlta.Size = new Size(418, 48);
            txtDAlta.TabIndex = 6;
            txtDAlta.Text = "0";
            txtDAlta.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(label5, 3);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(598, 135);
            label5.Name = "label5";
            label5.Size = new Size(589, 62);
            label5.TabIndex = 4;
            label5.Text = "Dificultad Baja:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(28, 46, 74);
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(598, 208);
            label9.Name = "label9";
            label9.Size = new Size(183, 52);
            label9.TabIndex = 11;
            label9.Text = "Cantidad:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDBaja
            // 
            tableLayoutPanel1.SetColumnSpan(txtDBaja, 2);
            txtDBaja.Dock = DockStyle.Fill;
            txtDBaja.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDBaja.Location = new Point(787, 210);
            txtDBaja.Margin = new Padding(3, 2, 3, 2);
            txtDBaja.Multiline = true;
            txtDBaja.Name = "txtDBaja";
            txtDBaja.Size = new Size(400, 48);
            txtDBaja.TabIndex = 8;
            txtDBaja.Text = "0";
            txtDBaja.TextAlign = HorizontalAlignment.Center;
            // 
            // frmGenerarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1199, 436);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGenerarExamen";
            Text = "frmGenerarExamen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtDAlta;
        private TextBox txtDBaja;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnGenerar;
    }
}