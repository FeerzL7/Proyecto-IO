namespace FrmProyectoIO
{
    partial class FrmEjerciciosLDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjerciciosLDE));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            buscadorToolStripMenuItem = new ToolStripMenuItem();
            tsmiDificultad = new ToolStripMenuItem();
            tscmbDificultad = new ToolStripComboBox();
            tsmiModelo = new ToolStripMenuItem();
            tscmbModelo = new ToolStripComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtTitulo = new TextBox();
            txtEnunciado = new TextBox();
            btnConsultas = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            dgvEjercicios = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewLinkColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.6435337F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.6435337F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5636463F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7350445F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.4142456F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 7, 4);
            tableLayoutPanel1.Controls.Add(dgvEjercicios, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.42468774F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8897772F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.42208076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.963464F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0414543F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2743359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.09625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.88794947F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Size = new Size(1015, 599);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 46, 74);
            label1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(label1, 9);
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(1, 0);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(1013, 64);
            label1.TabIndex = 0;
            label1.Text = "Líneas de Espera";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 7);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.55133F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4486694F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 387F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 2, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 3, 0);
            tableLayoutPanel3.Controls.Add(btnConsultas, 4, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(18, 74);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(972, 77);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscadorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 1, 0, 1);
            tableLayoutPanel3.SetRowSpan(menuStrip1, 2);
            menuStrip1.Size = new Size(248, 77);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscadorToolStripMenuItem
            // 
            buscadorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiDificultad, tsmiModelo });
            buscadorToolStripMenuItem.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscadorToolStripMenuItem.ForeColor = Color.FromArgb(28, 46, 74);
            buscadorToolStripMenuItem.Image = (Image)resources.GetObject("buscadorToolStripMenuItem.Image");
            buscadorToolStripMenuItem.Name = "buscadorToolStripMenuItem";
            buscadorToolStripMenuItem.Size = new Size(153, 75);
            buscadorToolStripMenuItem.Text = "Filtros";
            // 
            // tsmiDificultad
            // 
            tsmiDificultad.DropDownItems.AddRange(new ToolStripItem[] { tscmbDificultad });
            tsmiDificultad.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsmiDificultad.Image = (Image)resources.GetObject("tsmiDificultad.Image");
            tsmiDificultad.Name = "tsmiDificultad";
            tsmiDificultad.Size = new Size(317, 30);
            tsmiDificultad.Text = "Nivel de dificultad";
            // 
            // tscmbDificultad
            // 
            tscmbDificultad.Name = "tscmbDificultad";
            tscmbDificultad.Size = new Size(121, 28);
            // 
            // tsmiModelo
            // 
            tsmiModelo.DropDownItems.AddRange(new ToolStripItem[] { tscmbModelo });
            tsmiModelo.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsmiModelo.Image = (Image)resources.GetObject("tsmiModelo.Image");
            tsmiModelo.Name = "tsmiModelo";
            tsmiModelo.Size = new Size(317, 30);
            tsmiModelo.Text = "Modelo ";
            // 
            // tscmbModelo
            // 
            tscmbModelo.Items.AddRange(new object[] { "UNA", "MUCHAS" });
            tscmbModelo.Name = "tscmbModelo";
            tscmbModelo.Size = new Size(121, 28);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(251, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(251, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(28, 46, 74);
            label2.Location = new Point(293, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 38);
            label2.TabIndex = 11;
            label2.Text = "Título del ejercicio:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 46, 78);
            label3.Location = new Point(293, 38);
            label3.Name = "label3";
            label3.Size = new Size(205, 39);
            label3.TabIndex = 12;
            label3.Text = "Palabra clave:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(txtTitulo, 0, 0);
            tableLayoutPanel4.Controls.Add(txtEnunciado, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(504, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel3.SetRowSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(381, 71);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.LightSteelBlue;
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Location = new Point(3, 3);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(375, 29);
            txtTitulo.TabIndex = 0;
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.LightSteelBlue;
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Location = new Point(3, 38);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(375, 30);
            txtEnunciado.TabIndex = 1;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(28, 46, 74);
            btnConsultas.BackgroundImage = (Image)resources.GetObject("btnConsultas.BackgroundImage");
            btnConsultas.BackgroundImageLayout = ImageLayout.Zoom;
            btnConsultas.Dock = DockStyle.Fill;
            btnConsultas.Location = new Point(891, 3);
            btnConsultas.Name = "btnConsultas";
            tableLayoutPanel3.SetRowSpan(btnConsultas, 2);
            btnConsultas.Size = new Size(78, 71);
            btnConsultas.TabIndex = 14;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(838, 164);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 5);
            groupBox1.Size = new Size(152, 419);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEliminar, 0, 1);
            tableLayoutPanel2.Controls.Add(btnRegresar, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(146, 390);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(28, 46, 74);
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 123);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(28, 46, 74);
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Location = new Point(3, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 123);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(28, 46, 74);
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Location = new Point(3, 261);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(140, 126);
            btnRegresar.TabIndex = 2;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.BackgroundColor = Color.FromArgb(28, 46, 74);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjercicios.Columns.AddRange(new DataGridViewColumn[] { Titulo, Detalles });
            tableLayoutPanel1.SetColumnSpan(dgvEjercicios, 5);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(24, 46, 74);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(24, 46, 74);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEjercicios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEjercicios.Dock = DockStyle.Fill;
            dgvEjercicios.Location = new Point(18, 164);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.RowHeadersVisible = false;
            dgvEjercicios.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dgvEjercicios, 5);
            dgvEjercicios.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEjercicios.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEjercicios.RowTemplate.DefaultCellStyle.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvEjercicios.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(24, 46, 74);
            dgvEjercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvEjercicios.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 46, 74);
            dgvEjercicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjercicios.Size = new Size(806, 419);
            dgvEjercicios.TabIndex = 9;
            // 
            // Titulo
            // 
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            // 
            // Detalles
            // 
            Detalles.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Detalles.HeaderText = "Ver más";
            Detalles.MinimumWidth = 6;
            Detalles.Name = "Detalles";
            Detalles.Width = 122;
            // 
            // FrmEjerciciosLDE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 599);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmEjerciciosLDE";
            Text = "FrmEjerciciosLDE";
            FormClosed += FrmEjerciciosLDE_FormClosed;
            Load += FrmEjerciciosLDE_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscadorToolStripMenuItem;
        private ToolStripMenuItem tsmiDificultad;
        private ToolStripComboBox tscmbDificultad;
        private ToolStripMenuItem tsmiModelo;
        private ToolStripComboBox tscmbModelo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtTitulo;
        private TextBox txtEnunciado;
        private Button btnConsultas;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnRegresar;
        private DataGridView dgvEjercicios;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewLinkColumn Detalles;
    }
}