namespace FrmProyectoIO
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageBtnEOQ = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(guna2ImageButton1, 4, 2);
            tableLayoutPanel1.Controls.Add(guna2ImageBtnEOQ, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(885, 578);
            tableLayoutPanel1.TabIndex = 1;
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
            label1.Size = new Size(881, 64);
            label1.TabIndex = 0;
            label1.Text = "Investigacion De Operaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Dock = DockStyle.Fill;
            guna2ImageButton1.HoverState.ImageSize = new Size(250, 135);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(240, 125);
            guna2ImageButton1.Location = new Point(474, 237);
            guna2ImageButton1.Margin = new Padding(2);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(188, 167);
            guna2ImageButton1.TabIndex = 1;
            // 
            // guna2ImageBtnEOQ
            // 
            guna2ImageBtnEOQ.BackgroundImageLayout = ImageLayout.Stretch;
            guna2ImageBtnEOQ.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageBtnEOQ.Dock = DockStyle.Fill;
            guna2ImageBtnEOQ.HoverState.ImageSize = new Size(250, 135);
            guna2ImageBtnEOQ.Image = (Image)resources.GetObject("guna2ImageBtnEOQ.Image");
            guna2ImageBtnEOQ.ImageOffset = new Point(0, 0);
            guna2ImageBtnEOQ.ImageRotate = 0F;
            guna2ImageBtnEOQ.ImageSize = new Size(240, 125);
            guna2ImageBtnEOQ.Location = new Point(218, 237);
            guna2ImageBtnEOQ.Margin = new Padding(2);
            guna2ImageBtnEOQ.Name = "guna2ImageBtnEOQ";
            guna2ImageBtnEOQ.PressedState.ImageSize = new Size(64, 64);
            guna2ImageBtnEOQ.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ImageBtnEOQ.Size = new Size(188, 167);
            guna2ImageBtnEOQ.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 578);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FrmInicio";
            Text = "Inicio";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageBtnEOQ;
    }
}
