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
            menuStrip1 = new MenuStrip();
            buscadorToolStripMenuItem = new ToolStripMenuItem();
            tsmiDificultad = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            tsmiModelo = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripComboBox();
            tsmiConsultas = new ToolStripMenuItem();
            títuloDelEjercicioToolStripMenuItem = new ToolStripMenuItem();
            tstxtTitulo = new ToolStripTextBox();
            palabraToolStripMenuItem = new ToolStripMenuItem();
            tstxtEnunciado = new ToolStripTextBox();
            dgvEjercicios = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewLinkColumn();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(menuStrip1, 1, 2);
            tableLayoutPanel1.Controls.Add(dgvEjercicios, 1, 3);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.42602491F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.625669F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.982175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.04401F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6188612F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2905521F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.112299F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.89535332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(701, 639);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 46, 74);
            label1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(label1, 7);
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(697, 64);
            label1.TabIndex = 0;
            label1.Text = "Líneas de Espera";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.SetColumnSpan(menuStrip1, 5);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscadorToolStripMenuItem });
            menuStrip1.Location = new Point(14, 72);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(672, 54);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscadorToolStripMenuItem
            // 
            buscadorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiDificultad, tsmiModelo, tsmiConsultas });
            buscadorToolStripMenuItem.ForeColor = Color.FromArgb(24, 46, 74);
            buscadorToolStripMenuItem.Image = (Image)resources.GetObject("buscadorToolStripMenuItem.Image");
            buscadorToolStripMenuItem.Name = "buscadorToolStripMenuItem";
            buscadorToolStripMenuItem.Size = new Size(155, 50);
            buscadorToolStripMenuItem.Text = "Buscador";
            // 
            // tsmiDificultad
            // 
            tsmiDificultad.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            tsmiDificultad.Image = (Image)resources.GetObject("tsmiDificultad.Image");
            tsmiDificultad.Name = "tsmiDificultad";
            tsmiDificultad.Size = new Size(344, 30);
            tsmiDificultad.Text = "Nivel de dificultad";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // tsmiModelo
            // 
            tsmiModelo.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox2 });
            tsmiModelo.Image = (Image)resources.GetObject("tsmiModelo.Image");
            tsmiModelo.Name = "tsmiModelo";
            tsmiModelo.Size = new Size(344, 30);
            tsmiModelo.Text = "Modelo ";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            // 
            // tsmiConsultas
            // 
            tsmiConsultas.DropDownItems.AddRange(new ToolStripItem[] { títuloDelEjercicioToolStripMenuItem, palabraToolStripMenuItem });
            tsmiConsultas.Image = (Image)resources.GetObject("tsmiConsultas.Image");
            tsmiConsultas.Name = "tsmiConsultas";
            tsmiConsultas.Size = new Size(344, 30);
            tsmiConsultas.Text = "Consultas especificas";
            // 
            // títuloDelEjercicioToolStripMenuItem
            // 
            títuloDelEjercicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tstxtTitulo });
            títuloDelEjercicioToolStripMenuItem.Image = (Image)resources.GetObject("títuloDelEjercicioToolStripMenuItem.Image");
            títuloDelEjercicioToolStripMenuItem.Name = "títuloDelEjercicioToolStripMenuItem";
            títuloDelEjercicioToolStripMenuItem.Size = new Size(427, 30);
            títuloDelEjercicioToolStripMenuItem.Text = "Título del ejercicio:";
            // 
            // tstxtTitulo
            // 
            tstxtTitulo.Name = "tstxtTitulo";
            tstxtTitulo.Size = new Size(100, 27);
            // 
            // palabraToolStripMenuItem
            // 
            palabraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tstxtEnunciado });
            palabraToolStripMenuItem.Image = (Image)resources.GetObject("palabraToolStripMenuItem.Image");
            palabraToolStripMenuItem.Name = "palabraToolStripMenuItem";
            palabraToolStripMenuItem.Size = new Size(427, 30);
            palabraToolStripMenuItem.Text = "Palabra clave del enunciado:";
            // 
            // tstxtEnunciado
            // 
            tstxtEnunciado.Name = "tstxtEnunciado";
            tstxtEnunciado.Size = new Size(100, 27);
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.BackgroundColor = Color.WhiteSmoke;
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
            dgvEjercicios.Location = new Point(17, 129);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.RowHeadersVisible = false;
            dgvEjercicios.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dgvEjercicios, 4);
            dgvEjercicios.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEjercicios.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEjercicios.RowTemplate.DefaultCellStyle.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvEjercicios.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(24, 46, 74);
            dgvEjercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvEjercicios.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 46, 74);
            dgvEjercicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjercicios.Size = new Size(666, 353);
            dgvEjercicios.TabIndex = 7;
            // 
            // Titulo
            // 
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 5);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 488);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(666, 134);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEliminar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnRegresar, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(660, 105);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(24, 46, 74);
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(214, 99);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(24, 46, 74);
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Location = new Point(223, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(214, 99);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(24, 46, 74);
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Location = new Point(443, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(214, 99);
            btnRegresar.TabIndex = 2;
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // FrmEjerciciosLDE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 639);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "FrmEjerciciosLDE";
            Text = "FrmEjerciciosLDE";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dgvEjercicios;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewLinkColumn Detalles;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscadorToolStripMenuItem;
        private ToolStripMenuItem tsmiDificultad;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem tsmiModelo;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripMenuItem tsmiConsultas;
        private ToolStripMenuItem títuloDelEjercicioToolStripMenuItem;
        private ToolStripTextBox tstxtTitulo;
        private ToolStripMenuItem palabraToolStripMenuItem;
        private ToolStripTextBox tstxtEnunciado;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnRegresar;
    }
}