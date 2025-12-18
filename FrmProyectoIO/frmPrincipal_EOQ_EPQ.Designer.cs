namespace FrmProyectoIO
{
    partial class frmPrincipal_EOQ_EPQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal_EOQ_EPQ));
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvEjercicios = new DataGridView();
            Ejercicios = new DataGridViewTextBoxColumn();
            VER = new DataGridViewTextBoxColumn();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregar = new Button();
            cmbNivelDificultad = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEliminar = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnRegresar = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            txtEnunciado = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 13;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.19560885F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.80439F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 387F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 480F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(dgvEjercicios, 1, 5);
            tableLayoutPanel1.Controls.Add(radioButton1, 1, 3);
            tableLayoutPanel1.Controls.Add(radioButton2, 3, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 11);
            tableLayoutPanel1.Controls.Add(cmbNivelDificultad, 3, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 11);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 9, 11);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 6, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0655737F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.9344254F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 218F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.Size = new Size(1199, 562);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.BackgroundColor = Color.FromArgb(28, 46, 74);
            dgvEjercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjercicios.Columns.AddRange(new DataGridViewColumn[] { Ejercicios, VER });
            tableLayoutPanel1.SetColumnSpan(dgvEjercicios, 4);
            dgvEjercicios.Dock = DockStyle.Fill;
            dgvEjercicios.Location = new Point(6, 19);
            dgvEjercicios.Margin = new Padding(2);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.RowHeadersVisible = false;
            dgvEjercicios.RowHeadersWidth = 82;
            tableLayoutPanel1.SetRowSpan(dgvEjercicios, 5);
            dgvEjercicios.Size = new Size(617, 371);
            dgvEjercicios.TabIndex = 1;
            // 
            // Ejercicios
            // 
            Ejercicios.HeaderText = "Ejercicios";
            Ejercicios.MinimumWidth = 10;
            Ejercicios.Name = "Ejercicios";
            Ejercicios.Width = 200;
            // 
            // VER
            // 
            VER.HeaderText = "VER";
            VER.MinimumWidth = 10;
            VER.Name = "VER";
            VER.Width = 200;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(28, 46, 74);
            radioButton1.Dock = DockStyle.Fill;
            radioButton1.Font = new Font("Cooper Black", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(6, -41);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(211, 52);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "EOQ";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(radioButton2, 2);
            radioButton2.Dock = DockStyle.Fill;
            radioButton2.Font = new Font("Cooper Black", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(230, -41);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(393, 52);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "EPQ";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(28, 46, 74);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cooper Black", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, -5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 1);
            label1.TabIndex = 2;
            label1.Text = "Nivel de Dificultad:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1545181F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.84548F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel2.Controls.Add(btnAgregar, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(7, 398);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.16666651F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 95.8333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel2.Size = new Size(209, 157);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(33, 8);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 140);
            btnAgregar.TabIndex = 7;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbNivelDificultad
            // 
            tableLayoutPanel1.SetColumnSpan(cmbNivelDificultad, 3);
            cmbNivelDificultad.Dock = DockStyle.Fill;
            cmbNivelDificultad.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNivelDificultad.FormattingEnabled = true;
            cmbNivelDificultad.Location = new Point(230, -3);
            cmbNivelDificultad.Margin = new Padding(2);
            cmbNivelDificultad.Name = "cmbNivelDificultad";
            cmbNivelDificultad.Size = new Size(397, 31);
            cmbNivelDificultad.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.988472F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.01153F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel3.Controls.Add(btnEliminar, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(231, 398);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.968944F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 95.03106F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel3.Size = new Size(381, 157);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(98, 9);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(202, 137);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.78341F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.21659F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel6.Controls.Add(btnRegresar, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(671, 398);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 4.347826F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 95.6521759F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel6.Size = new Size(474, 157);
            tableLayoutPanel6.TabIndex = 19;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(153, 8);
            btnRegresar.Margin = new Padding(2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(216, 140);
            btnRegresar.TabIndex = 8;
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 6);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 4);
            tableLayoutPanel4.Controls.Add(label2, 0, 2);
            tableLayoutPanel4.Controls.Add(txtTitulo, 1, 2);
            tableLayoutPanel4.Controls.Add(txtEnunciado, 0, 6);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 8);
            tableLayoutPanel4.Location = new Point(632, -41);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 6);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80.4347839F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.565218F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 189F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new Size(538, 424);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel4.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Cooper Black", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(534, 41);
            label4.TabIndex = 15;
            label4.Text = "Consultas:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel4.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Cooper Black", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(2, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(534, 33);
            label3.TabIndex = 8;
            label3.Text = "Enunciado:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(28, 46, 74);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Cooper Black", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(2, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(265, 30);
            label2.TabIndex = 7;
            label2.Text = "Titulo:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(271, 52);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(265, 26);
            txtTitulo.TabIndex = 13;
            // 
            // txtEnunciado
            // 
            tableLayoutPanel4.SetColumnSpan(txtEnunciado, 2);
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Location = new Point(2, 128);
            txtEnunciado.Margin = new Padding(2);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(534, 185);
            txtEnunciado.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel4.SetColumnSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.940063F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.05994F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 234F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel5.Controls.Add(btnConsultar, 1, 1);
            tableLayoutPanel5.Controls.Add(btnLimpiar, 3, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 324);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.636364F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 86.36364F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel5.Size = new Size(532, 98);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(28, 46, 74);
            btnConsultar.Dock = DockStyle.Fill;
            btnConsultar.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(21, 13);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(235, 67);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(28, 46, 74);
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(281, 13);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(228, 67);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal_EOQ_EPQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1199, 562);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal_EOQ_EPQ";
            Text = "frmPrincipal_EOQ_EPQ";
            FormClosing += frmPrincipal_EOQ_EPQ_FormClosing;
            Load += frmPrincipal_EOQ_EPQ_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvEjercicios;
        private DataGridViewTextBoxColumn Ejercicios;
        private DataGridViewTextBoxColumn VER;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregar;
        private ComboBox cmbNivelDificultad;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEliminar;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtEnunciado;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnConsultar;
        private Button btnLimpiar;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnRegresar;
    }
}