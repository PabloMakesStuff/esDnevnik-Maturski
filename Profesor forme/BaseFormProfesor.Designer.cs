namespace Maturski.Profesor_forme
{
    partial class BaseFormProfesor
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
            panel1 = new Panel();
            IzlogujSeBTN = new Button();
            labelDobarDan = new Label();
            pictureBox1 = new PictureBox();
            panelParentTable = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(IzlogujSeBTN);
            panel1.Controls.Add(labelDobarDan);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 209);
            panel1.TabIndex = 0;
            // 
            // IzlogujSeBTN
            // 
            IzlogujSeBTN.Location = new Point(1226, 22);
            IzlogujSeBTN.Name = "IzlogujSeBTN";
            IzlogujSeBTN.Size = new Size(154, 68);
            IzlogujSeBTN.TabIndex = 3;
            IzlogujSeBTN.Text = "Izloguj se";
            IzlogujSeBTN.UseVisualStyleBackColor = true;
            IzlogujSeBTN.Click += IzlogujSeBTN_Click;
            // 
            // labelDobarDan
            // 
            labelDobarDan.AutoSize = true;
            labelDobarDan.Font = new Font("Segoe UI", 26F);
            labelDobarDan.Location = new Point(230, 74);
            labelDobarDan.Name = "labelDobarDan";
            labelDobarDan.Size = new Size(142, 60);
            labelDobarDan.TabIndex = 2;
            labelDobarDan.Text = "label1";
            labelDobarDan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.logo_esdnevnik;
            pictureBox1.InitialImage = Properties.Resources.loading_image;
            pictureBox1.Location = new Point(27, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelParentTable
            // 
            panelParentTable.AutoSize = true;
            panelParentTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelParentTable.BackColor = SystemColors.ActiveCaption;
            panelParentTable.Dock = DockStyle.Fill;
            panelParentTable.Location = new Point(0, 209);
            panelParentTable.Name = "panelParentTable";
            panelParentTable.Size = new Size(1422, 768);
            panelParentTable.TabIndex = 1;
            // 
            // BaseFormProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panelParentTable);
            Controls.Add(panel1);
            Name = "BaseFormProfesor";
            Text = "BaseFormProfesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button IzlogujSeBTN;
        protected Label labelDobarDan;
        protected Panel panelParentTable;
    }
}