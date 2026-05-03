namespace Maturski.Profesor_forme
{
    partial class OdeljenjeProfilProf
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
            label1 = new Label();
            panelTop = new Panel();
            UpisiOcenuBTN = new Button();
            UpisiIzostanakBTN = new Button();
            BackBTN = new Button();
            tablePanelChild = new TableLayoutPanel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(UpisiOcenuBTN);
            panelTop.Controls.Add(UpisiIzostanakBTN);
            panelTop.Controls.Add(BackBTN);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1422, 125);
            panelTop.TabIndex = 0;
            // 
            // UpisiOcenuBTN
            // 
            UpisiOcenuBTN.Location = new Point(398, 12);
            UpisiOcenuBTN.Name = "UpisiOcenuBTN";
            UpisiOcenuBTN.Size = new Size(155, 107);
            UpisiOcenuBTN.TabIndex = 3;
            UpisiOcenuBTN.Text = "Upisi Ocenu";
            UpisiOcenuBTN.UseVisualStyleBackColor = true;
            UpisiOcenuBTN.Click += UpisiOcenuBTN_Click;
            // 
            // UpisiIzostanakBTN
            // 
            UpisiIzostanakBTN.Location = new Point(872, 12);
            UpisiIzostanakBTN.Name = "UpisiIzostanakBTN";
            UpisiIzostanakBTN.Size = new Size(155, 107);
            UpisiIzostanakBTN.TabIndex = 2;
            UpisiIzostanakBTN.Text = "Upisi izostanak";
            UpisiIzostanakBTN.UseVisualStyleBackColor = true;
            // 
            // BackBTN
            // 
            BackBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackBTN.Location = new Point(1270, 12);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(140, 63);
            BackBTN.TabIndex = 1;
            BackBTN.Text = "Nazad";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // tablePanelChild
            // 
            tablePanelChild.ColumnCount = 3;
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePanelChild.Dock = DockStyle.Fill;
            tablePanelChild.Location = new Point(0, 125);
            tablePanelChild.Name = "tablePanelChild";
            tablePanelChild.RowCount = 4;
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.Size = new Size(1422, 852);
            tablePanelChild.TabIndex = 1;
            // 
            // OdeljenjeProfilProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(tablePanelChild);
            Controls.Add(panelTop);
            Name = "OdeljenjeProfilProf";
            Text = "UcenikProfil";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelTop;
        private TableLayoutPanel tablePanelChild;
        private Button BackBTN;
        private Button UpisiOcenuBTN;
        private Button UpisiIzostanakBTN;
    }
}