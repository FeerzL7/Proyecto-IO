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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnEliminar = new Button();
            btnBorrarEjercicio = new Button();
            btnAgregarEjercicio = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            txtEnunciado = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnGenerarExamen = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            cmbNivelDificultad = new ComboBox();
            label1 = new Label();
            rdbEPQ = new RadioButton();
            rdbEOQ = new RadioButton();
            dgvEjercicios = new DataGridView();
            Ejericios = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewLinkColumn();
            Modificar = new DataGridViewLinkColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnImprimirEjercicios = new Button();
            btnAñadirImpresion = new Button();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(50, 50);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(0, 0);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEjercicio
            // 
            btnBorrarEjercicio.BackgroundImage = (Image)resources.GetObject("btnBorrarEjercicio.BackgroundImage");
            btnBorrarEjercicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrarEjercicio.Dock = DockStyle.Fill;
            btnBorrarEjercicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarEjercicio.Location = new Point(138, 1);
            btnBorrarEjercicio.Margin = new Padding(1);
            btnBorrarEjercicio.Name = "btnBorrarEjercicio";
            btnBorrarEjercicio.Size = new Size(135, 94);
            btnBorrarEjercicio.TabIndex = 9;
            btnBorrarEjercicio.UseVisualStyleBackColor = true;
            btnBorrarEjercicio.Click += btnBorrarEjercicio_Click;
            // 
            // btnAgregarEjercicio
            // 
            btnAgregarEjercicio.BackgroundImage = (Image)resources.GetObject("btnAgregarEjercicio.BackgroundImage");
            btnAgregarEjercicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarEjercicio.Dock = DockStyle.Fill;
            btnAgregarEjercicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEjercicio.Location = new Point(1, 1);
            btnAgregarEjercicio.Margin = new Padding(1);
            btnAgregarEjercicio.Name = "btnAgregarEjercicio";
            btnAgregarEjercicio.Size = new Size(135, 94);
            btnAgregarEjercicio.TabIndex = 10;
            btnAgregarEjercicio.UseVisualStyleBackColor = true;
            btnAgregarEjercicio.Click += btnAgregarEjercicio_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 4);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.02492F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.97508F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 4);
            tableLayoutPanel4.Controls.Add(label2, 0, 2);
            tableLayoutPanel4.Controls.Add(txtTitulo, 1, 2);
            tableLayoutPanel4.Controls.Add(txtEnunciado, 0, 6);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 8);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(576, 37);
            tableLayoutPanel4.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 6);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 76.92308F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(318, 289);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel4.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(314, 36);
            label4.TabIndex = 15;
            label4.Text = "Consultar Ejercicio:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel4.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1, 85);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(316, 29);
            label3.TabIndex = 8;
            label3.Text = "Enunciado:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(28, 46, 74);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1, 47);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 7;
            label2.Text = "Titulo:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            txtTitulo.Dock = DockStyle.Fill;
            txtTitulo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(166, 48);
            txtTitulo.Margin = new Padding(1);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(151, 30);
            txtTitulo.TabIndex = 13;
            // 
            // txtEnunciado
            // 
            tableLayoutPanel4.SetColumnSpan(txtEnunciado, 2);
            txtEnunciado.Dock = DockStyle.Fill;
            txtEnunciado.Location = new Point(1, 122);
            txtEnunciado.Margin = new Padding(1);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.ReadOnly = true;
            txtEnunciado.Size = new Size(316, 79);
            txtEnunciado.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel4.SetColumnSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.940063F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.05994F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel5.Controls.Add(btnGenerarExamen, 1, 1);
            tableLayoutPanel5.Controls.Add(btnLimpiar, 3, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(2, 211);
            tableLayoutPanel5.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel4.SetRowSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.636364F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 86.36364F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel5.Size = new Size(314, 77);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.BackColor = Color.FromArgb(28, 46, 74);
            btnGenerarExamen.Dock = DockStyle.Fill;
            btnGenerarExamen.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnGenerarExamen.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarExamen.Location = new Point(13, 10);
            btnGenerarExamen.Margin = new Padding(2, 1, 2, 1);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(146, 57);
            btnGenerarExamen.TabIndex = 0;
            btnGenerarExamen.Text = "Generar examen";
            btnGenerarExamen.UseVisualStyleBackColor = false;
            btnGenerarExamen.Click += btnGenerarExamen_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(28, 46, 74);
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(171, 10);
            btnLimpiar.Margin = new Padding(2, 1, 2, 1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 57);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(77, 1);
            btnRegresar.Margin = new Padding(1);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(162, 94);
            btnRegresar.TabIndex = 8;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cmbNivelDificultad
            // 
            tableLayoutPanel1.SetColumnSpan(cmbNivelDificultad, 3);
            cmbNivelDificultad.Dock = DockStyle.Fill;
            cmbNivelDificultad.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNivelDificultad.FormattingEnabled = true;
            cmbNivelDificultad.Location = new Point(260, 4);
            cmbNivelDificultad.Margin = new Padding(1);
            cmbNivelDificultad.Name = "cmbNivelDificultad";
            cmbNivelDificultad.Size = new Size(307, 33);
            cmbNivelDificultad.TabIndex = 3;
            cmbNivelDificultad.SelectedIndexChanged += cmbNivelDificultad_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(28, 46, 74);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 3);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 2;
            label1.Text = "Nivel de Dificultad:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdbEPQ
            // 
            rdbEPQ.AutoSize = true;
            rdbEPQ.BackColor = Color.FromArgb(28, 46, 74);
            tableLayoutPanel1.SetColumnSpan(rdbEPQ, 2);
            rdbEPQ.Dock = DockStyle.Fill;
            rdbEPQ.Font = new Font("Microsoft Sans Serif", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbEPQ.ForeColor = SystemColors.ButtonHighlight;
            rdbEPQ.Location = new Point(260, 37);
            rdbEPQ.Margin = new Padding(1);
            rdbEPQ.Name = "rdbEPQ";
            rdbEPQ.Size = new Size(304, 35);
            rdbEPQ.TabIndex = 5;
            rdbEPQ.TabStop = true;
            rdbEPQ.Text = "EPQ";
            rdbEPQ.TextAlign = ContentAlignment.MiddleCenter;
            rdbEPQ.UseVisualStyleBackColor = false;
            rdbEPQ.CheckedChanged += rdbEPQ_CheckedChanged;
            // 
            // rdbEOQ
            // 
            rdbEOQ.AutoSize = true;
            rdbEOQ.BackColor = Color.FromArgb(28, 46, 74);
            rdbEOQ.Dock = DockStyle.Fill;
            rdbEOQ.Font = new Font("Microsoft Sans Serif", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbEOQ.ForeColor = SystemColors.ButtonHighlight;
            rdbEOQ.Location = new Point(6, 37);
            rdbEOQ.Margin = new Padding(1);
            rdbEOQ.Name = "rdbEOQ";
            rdbEOQ.Size = new Size(248, 35);
            rdbEOQ.TabIndex = 4;
            rdbEOQ.TabStop = true;
            rdbEOQ.Text = "EOQ";
            rdbEOQ.TextAlign = ContentAlignment.MiddleCenter;
            rdbEOQ.UseVisualStyleBackColor = false;
            rdbEOQ.CheckedChanged += rdbEOQ_CheckedChanged;
            // 
            // dgvEjercicios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvEjercicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjercicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjercicios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEjercicios.BackgroundColor = Color.FromArgb(28, 46, 74);
            dgvEjercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjercicios.Columns.AddRange(new DataGridViewColumn[] { Ejericios, Ver, Modificar });
            tableLayoutPanel1.SetColumnSpan(dgvEjercicios, 4);
            dgvEjercicios.Dock = DockStyle.Fill;
            dgvEjercicios.Location = new Point(6, 76);
            dgvEjercicios.Margin = new Padding(1);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEjercicios.RowHeadersVisible = false;
            dgvEjercicios.RowHeadersWidth = 82;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEjercicios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tableLayoutPanel1.SetRowSpan(dgvEjercicios, 5);
            dgvEjercicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjercicios.Size = new Size(558, 258);
            dgvEjercicios.TabIndex = 1;
            dgvEjercicios.CellContentClick += dgvEjercicios_CellContentClick;
            dgvEjercicios.SelectionChanged += dgvEjercicios_SelectionChanged;
            // 
            // Ejericios
            // 
            Ejericios.DataPropertyName = "Titulo";
            Ejericios.HeaderText = "Ejercicios";
            Ejericios.Name = "Ejericios";
            // 
            // Ver
            // 
            Ver.DataPropertyName = "Ver";
            Ver.HeaderText = "Ver";
            Ver.Name = "Ver";
            Ver.Text = "Ver";
            Ver.UseColumnTextForLinkValue = true;
            // 
            // Modificar
            // 
            Modificar.DataPropertyName = "Modificar";
            Modificar.HeaderText = "Modificar";
            Modificar.Name = "Modificar";
            Modificar.Text = "Modificar";
            Modificar.UseColumnTextForLinkValue = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.19560885F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.80439F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(dgvEjercicios, 1, 5);
            tableLayoutPanel1.Controls.Add(rdbEOQ, 1, 3);
            tableLayoutPanel1.Controls.Add(rdbEPQ, 3, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbNivelDificultad, 3, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 7, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 9, 10);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.47369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tableLayoutPanel1.Size = new Size(896, 441);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7796612F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.22034F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(585, 338);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(297, 96);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnImprimirEjercicios, 3, 0);
            tableLayoutPanel3.Controls.Add(btnAñadirImpresion, 2, 0);
            tableLayoutPanel3.Controls.Add(btnAgregarEjercicio, 0, 0);
            tableLayoutPanel3.Controls.Add(btnBorrarEjercicio, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(8, 338);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(548, 96);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // btnImprimirEjercicios
            // 
            btnImprimirEjercicios.BackColor = Color.FromArgb(28, 46, 74);
            btnImprimirEjercicios.BackgroundImageLayout = ImageLayout.Stretch;
            btnImprimirEjercicios.Dock = DockStyle.Fill;
            btnImprimirEjercicios.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnImprimirEjercicios.ForeColor = SystemColors.Control;
            btnImprimirEjercicios.Location = new Point(412, 1);
            btnImprimirEjercicios.Margin = new Padding(1);
            btnImprimirEjercicios.Name = "btnImprimirEjercicios";
            btnImprimirEjercicios.Size = new Size(135, 94);
            btnImprimirEjercicios.TabIndex = 12;
            btnImprimirEjercicios.Text = "Imprimir ejercicios";
            btnImprimirEjercicios.UseVisualStyleBackColor = false;
            btnImprimirEjercicios.Click += btnImprimirEjercicios_Click;
            // 
            // btnAñadirImpresion
            // 
            btnAñadirImpresion.BackColor = Color.FromArgb(28, 46, 74);
            btnAñadirImpresion.BackgroundImageLayout = ImageLayout.Stretch;
            btnAñadirImpresion.Dock = DockStyle.Fill;
            btnAñadirImpresion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnAñadirImpresion.ForeColor = SystemColors.Control;
            btnAñadirImpresion.Location = new Point(275, 1);
            btnAñadirImpresion.Margin = new Padding(1);
            btnAñadirImpresion.Name = "btnAñadirImpresion";
            btnAñadirImpresion.Size = new Size(135, 94);
            btnAñadirImpresion.TabIndex = 11;
            btnAñadirImpresion.Text = "Añadir a impresión";
            btnAñadirImpresion.UseVisualStyleBackColor = false;
            btnAñadirImpresion.Click += btnAñadirImpresion_Click;
            // 
            // frmPrincipal_EOQ_EPQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(896, 441);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal_EOQ_EPQ";
            Text = "frmPrincipal_EOQ_EPQ";
            FormClosing += frmPrincipal_EOQ_EPQ_FormClosing;
            Load += frmPrincipal_EOQ_EPQ_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnImprimir;
        private Button btnAgg;
        private DataGridViewTextBoxColumn designEjercicios;
        private DataGridViewLinkColumn designVER;
        private Button btnBorrarEjercicio;
        private Button btnAgregarEjercicio;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvEjercicios;
        private RadioButton rdbEOQ;
        private RadioButton rdbEPQ;
        private Label label1;
        private ComboBox cmbNivelDificultad;
        private Button btnRegresar;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtEnunciado;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnGenerarExamen;
        private Button btnLimpiar;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnImprimirEjercicios;
        private Button btnAñadirImpresion;
        private DataGridViewTextBoxColumn Ejericios;
        private DataGridViewLinkColumn Ver;
        private DataGridViewLinkColumn Modificar;
    }
}