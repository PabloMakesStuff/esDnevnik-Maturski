namespace Maturski.Profesor_forme
{
    partial class UpisiNeopravdaniForm
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
            LoginPanel = new Panel();
            boxImeUcenika = new ComboBox();
            boxStatus = new ComboBox();
            label1 = new Label();
            boxPredmet = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            UpisiIzostanakBTN = new Button();
            BackBTN = new Button();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.AutoSize = true;
            LoginPanel.BackColor = Color.FromArgb(76, 157, 160);
            LoginPanel.BorderStyle = BorderStyle.Fixed3D;
            LoginPanel.Controls.Add(boxImeUcenika);
            LoginPanel.Controls.Add(boxStatus);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(boxPredmet);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(UpisiIzostanakBTN);
            LoginPanel.Location = new Point(272, 106);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(479, 461);
            LoginPanel.TabIndex = 2;
            // 
            // boxImeUcenika
            // 
            boxImeUcenika.FormattingEnabled = true;
            boxImeUcenika.Location = new Point(80, 181);
            boxImeUcenika.Name = "boxImeUcenika";
            boxImeUcenika.Size = new Size(268, 28);
            boxImeUcenika.TabIndex = 13;
            boxImeUcenika.SelectionChangeCommitted += boxImeUcenika_SelectionChangeCommitted;
            // 
            // boxStatus
            // 
            boxStatus.FormattingEnabled = true;
            boxStatus.Items.AddRange(new object[] { "opravdani", "neregulisani", "neopravdani" });
            boxStatus.Location = new Point(80, 282);
            boxStatus.Name = "boxStatus";
            boxStatus.Size = new Size(268, 28);
            boxStatus.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 259);
            label1.Name = "label1";
            label1.Size = new Size(315, 20);
            label1.TabIndex = 9;
            label1.Text = "Status (Opravdani, Neopravdani, Neregulisani)";
            // 
            // boxPredmet
            // 
            boxPredmet.FormattingEnabled = true;
            boxPredmet.Items.AddRange(new object[] { "Matematika", "Fizika", "Srpski", "Engleski", "Nemacki", "Francuski", "Latinski", "Biologija", "Filozofija", "Sociologija", "Istorija", "Geografija", "Programiranje", "Veb programiranje", "Objektno Orijentisano Programiranje", "Primena Racunara", "Baze Podataka", "Programske Paradigme", "Veronauka" });
            boxPredmet.Location = new Point(80, 79);
            boxPredmet.Name = "boxPredmet";
            boxPredmet.Size = new Size(268, 28);
            boxPredmet.TabIndex = 7;
            boxPredmet.SelectedIndexChanged += boxPredmet_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 158);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Ime Ucenika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Ime Predmeta";
            // 
            // UpisiIzostanakBTN
            // 
            UpisiIzostanakBTN.Location = new Point(174, 392);
            UpisiIzostanakBTN.Name = "UpisiIzostanakBTN";
            UpisiIzostanakBTN.Size = new Size(129, 50);
            UpisiIzostanakBTN.TabIndex = 4;
            UpisiIzostanakBTN.Text = "Upisi Izostanak";
            UpisiIzostanakBTN.UseVisualStyleBackColor = true;
            UpisiIzostanakBTN.Click += UpisiIzostanakBTN_Click;
            // 
            // BackBTN
            // 
            BackBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackBTN.Location = new Point(916, 12);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(94, 55);
            BackBTN.TabIndex = 3;
            BackBTN.Text = "Nazad";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // UpisiNeopravdaniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 673);
            Controls.Add(BackBTN);
            Controls.Add(LoginPanel);
            Name = "UpisiNeopravdaniForm";
            Text = "UpisiNeopravdaniForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LoginPanel;
        private ComboBox boxImeUcenika;
        private ComboBox boxStatus;
        private Label label1;
        private ComboBox boxPredmet;
        private Label label3;
        private Label label2;
        private Button UpisiIzostanakBTN;
        private Button BackBTN;
    }
}