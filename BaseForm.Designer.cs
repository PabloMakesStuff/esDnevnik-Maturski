namespace Maturski
{
    partial class BaseForm
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
            panelTop = new Panel();
            IzostanciBTN = new Button();
            OceneBTN = new Button();
            PocetakBTN = new Button();
            pictureBox1 = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = SystemColors.ControlDark;
            panelTop.Controls.Add(IzostanciBTN);
            panelTop.Controls.Add(OceneBTN);
            panelTop.Controls.Add(PocetakBTN);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1424, 209);
            panelTop.TabIndex = 0;
            // 
            // IzostanciBTN
            // 
            IzostanciBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IzostanciBTN.Location = new Point(1122, 76);
            IzostanciBTN.Name = "IzostanciBTN";
            IzostanciBTN.Size = new Size(130, 57);
            IzostanciBTN.TabIndex = 3;
            IzostanciBTN.Text = "Izostanci";
            IzostanciBTN.UseVisualStyleBackColor = true;
            // 
            // OceneBTN
            // 
            OceneBTN.Anchor = AnchorStyles.None;
            OceneBTN.Location = new Point(647, 76);
            OceneBTN.Name = "OceneBTN";
            OceneBTN.Size = new Size(130, 57);
            OceneBTN.TabIndex = 2;
            OceneBTN.Text = "Ocene";
            OceneBTN.UseVisualStyleBackColor = true;
            // 
            // PocetakBTN
            // 
            PocetakBTN.Location = new Point(255, 76);
            PocetakBTN.Name = "PocetakBTN";
            PocetakBTN.Size = new Size(130, 57);
            PocetakBTN.TabIndex = 1;
            PocetakBTN.Text = "Pocetak";
            PocetakBTN.UseVisualStyleBackColor = true;
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panelTop);
            Name = "BaseForm";
            Text = "esDnevnik(Ucenik)";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBox1;
        protected Button IzostanciBTN;
        protected Button OceneBTN;
        protected Button PocetakBTN;
    }
}