namespace Maturski.Profesor_forme
{
    partial class ProfesorUcenikProfil
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
            BackBTN = new Button();
            IzostanciBTN = new Button();
            OceneBTN = new Button();
            labelImeUcenik = new Label();
            tableLayout = new TableLayoutPanel();
            UpisiOcenuBTN = new Button();
            IzostanakBTN = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(BackBTN);
            panel1.Controls.Add(IzostanciBTN);
            panel1.Controls.Add(OceneBTN);
            panel1.Controls.Add(labelImeUcenik);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 160);
            panel1.TabIndex = 0;
            // 
            // BackBTN
            // 
            BackBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackBTN.Location = new Point(916, 12);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(94, 42);
            BackBTN.TabIndex = 3;
            BackBTN.Text = "Nazad";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // IzostanciBTN
            // 
            IzostanciBTN.Location = new Point(635, 90);
            IzostanciBTN.Name = "IzostanciBTN";
            IzostanciBTN.Size = new Size(170, 53);
            IzostanciBTN.TabIndex = 2;
            IzostanciBTN.Text = "Izostanci";
            IzostanciBTN.UseVisualStyleBackColor = true;
            IzostanciBTN.Click += IzostanciBTN_Click;
            // 
            // OceneBTN
            // 
            OceneBTN.Location = new Point(218, 90);
            OceneBTN.Name = "OceneBTN";
            OceneBTN.Size = new Size(170, 53);
            OceneBTN.TabIndex = 1;
            OceneBTN.Text = "Ocene";
            OceneBTN.UseVisualStyleBackColor = true;
            OceneBTN.Click += OceneBTN_Click;
            // 
            // labelImeUcenik
            // 
            labelImeUcenik.AutoSize = true;
            labelImeUcenik.Font = new Font("Segoe UI", 20F);
            labelImeUcenik.Location = new Point(12, 22);
            labelImeUcenik.Name = "labelImeUcenik";
            labelImeUcenik.Size = new Size(109, 46);
            labelImeUcenik.TabIndex = 0;
            labelImeUcenik.Text = "label1";
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 4;
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.Dock = DockStyle.Bottom;
            tableLayout.Location = new Point(0, 231);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.Size = new Size(1022, 442);
            tableLayout.TabIndex = 4;
            // 
            // UpisiOcenuBTN
            // 
            UpisiOcenuBTN.Location = new Point(218, 172);
            UpisiOcenuBTN.Name = "UpisiOcenuBTN";
            UpisiOcenuBTN.Size = new Size(170, 53);
            UpisiOcenuBTN.TabIndex = 5;
            UpisiOcenuBTN.Text = "Upisi Ocenu";
            UpisiOcenuBTN.UseVisualStyleBackColor = true;
            // 
            // IzostanakBTN
            // 
            IzostanakBTN.Location = new Point(635, 172);
            IzostanakBTN.Name = "IzostanakBTN";
            IzostanakBTN.Size = new Size(170, 53);
            IzostanakBTN.TabIndex = 7;
            IzostanakBTN.Text = "Upisi Izostanak";
            IzostanakBTN.UseVisualStyleBackColor = true;
            // 
            // ProfesorUcenikProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 673);
            Controls.Add(IzostanakBTN);
            Controls.Add(UpisiOcenuBTN);
            Controls.Add(tableLayout);
            Controls.Add(panel1);
            Name = "ProfesorUcenikProfil";
            Text = "UcenikIndividuo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button IzostanciBTN;
        private Button OceneBTN;
        private Label labelImeUcenik;
        private Button BackBTN;
        private TableLayoutPanel tableLayout;
        private Button UpisiOcenuBTN;
        private Button IzostanakBTN;
    }
}