namespace FrmProyectoIO
{
    partial class frmPrincipalEOQ
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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Ejercicios = new DataGridViewTextBoxColumn();
            VER = new DataGridViewTextBoxColumn();
            label1 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(998, 490);
            button2.Name = "button2";
            button2.Size = new Size(341, 84);
            button2.TabIndex = 12;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(717, 490);
            button1.Name = "button1";
            button1.Size = new Size(267, 84);
            button1.TabIndex = 11;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(28, 46, 74);
            label3.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(717, 405);
            label3.Name = "label3";
            label3.Size = new Size(267, 61);
            label3.TabIndex = 8;
            label3.Text = "Enunciado:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(28, 46, 74);
            label2.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(717, 303);
            label2.Name = "label2";
            label2.Size = new Size(267, 82);
            label2.TabIndex = 7;
            label2.Text = "Titulo:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(28, 46, 74);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ejercicios, VER });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Location = new Point(3, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(632, 328);
            dataGridView1.TabIndex = 1;
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
            // label1
            // 
            label1.BackColor = Color.FromArgb(28, 46, 74);
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 110);
            label1.TabIndex = 2;
            label1.Text = "Clasificacion:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(402, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 44);
            comboBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(28, 46, 74);
            radioButton1.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(3, 124);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(156, 37);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Modelo 1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(28, 46, 74);
            radioButton2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(402, 124);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(156, 37);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Modelo 2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 663);
            button3.Name = "button3";
            button3.Size = new Size(350, 96);
            button3.TabIndex = 7;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(998, 663);
            button4.Name = "button4";
            button4.Size = new Size(341, 96);
            button4.TabIndex = 8;
            button4.Text = "Regresar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(402, 663);
            button5.Name = "button5";
            button5.Size = new Size(300, 96);
            button5.TabIndex = 9;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.50873F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.49127173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 306F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 273F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 347F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(radioButton1, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(radioButton2, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 6, 8);
            tableLayoutPanel1.Controls.Add(button5, 2, 8);
            tableLayoutPanel1.Controls.Add(button3, 0, 8);
            tableLayoutPanel1.Controls.Add(label2, 4, 3);
            tableLayoutPanel1.Controls.Add(label3, 4, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 6, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 6, 5);
            tableLayoutPanel1.Controls.Add(button1, 4, 6);
            tableLayoutPanel1.Controls.Add(button2, 6, 6);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.23077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.76923F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1485, 843);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(998, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 39);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(998, 408);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 39);
            textBox2.TabIndex = 14;
            // 
            // frmPrincipalEOQ
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1485, 843);
            Controls.Add(tableLayoutPanel1);
            Name = "frmPrincipalEOQ";
            Text = "frmPrincipalEOQ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ejercicios;
        private DataGridViewTextBoxColumn VER;
        private Label label1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}