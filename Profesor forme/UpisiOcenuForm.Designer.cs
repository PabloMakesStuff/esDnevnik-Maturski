namespace Maturski.Profesor_forme
{
    partial class UpisiOcenuForm
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
            boxOcene = new ComboBox();
            label4 = new Label();
            textboxOpis = new TextBox();
            label1 = new Label();
            boxPredmet = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            UpisiOcenuBTN = new Button();
            BackBTN = new Button();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.AutoSize = true;
            LoginPanel.BackColor = Color.CadetBlue;
            LoginPanel.BorderStyle = BorderStyle.Fixed3D;
            LoginPanel.Controls.Add(boxImeUcenika);
            LoginPanel.Controls.Add(boxOcene);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(textboxOpis);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(boxPredmet);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(UpisiOcenuBTN);
            LoginPanel.Location = new Point(251, 80);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(520, 557);
            LoginPanel.TabIndex = 1;
            // 
            // boxImeUcenika
            // 
            boxImeUcenika.FormattingEnabled = true;
            boxImeUcenika.Location = new Point(124, 161);
            boxImeUcenika.Name = "boxImeUcenika";
            boxImeUcenika.Size = new Size(268, 28);
            boxImeUcenika.TabIndex = 13;
            // 
            // boxOcene
            // 
            boxOcene.FormattingEnabled = true;
            boxOcene.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            boxOcene.Location = new Point(124, 262);
            boxOcene.Name = "boxOcene";
            boxOcene.Size = new Size(268, 28);
            boxOcene.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 341);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 11;
            label4.Text = "Opis Ocene";
            // 
            // textboxOpis
            // 
            textboxOpis.Location = new Point(124, 364);
            textboxOpis.Multiline = true;
            textboxOpis.Name = "textboxOpis";
            textboxOpis.Size = new Size(268, 98);
            textboxOpis.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 239);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 9;
            label1.Text = "Ocena";
            // 
            // boxPredmet
            // 
            boxPredmet.FormattingEnabled = true;
            boxPredmet.Items.AddRange(new object[] { "Matematika", "Fizika", "Srpski", "Engleski", "Nemacki", "Francuski", "Latinski", "Biologija", "Filozofija", "Sociologija", "Istorija", "Geografija", "Programiranje", "Veb programiranje", "Objektno Orijentisano Programiranje", "Primena Racunara", "Baze Podataka", "Programske Paradigme", "Veronauka" });
            boxPredmet.Location = new Point(124, 59);
            boxPredmet.Name = "boxPredmet";
            boxPredmet.Size = new Size(268, 28);
            boxPredmet.TabIndex = 7;
            boxPredmet.SelectionChangeCommitted += boxPredmet_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 138);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Ime Ucenika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 36);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Ime Predmeta";
            // 
            // UpisiOcenuBTN
            // 
            UpisiOcenuBTN.Location = new Point(211, 510);
            UpisiOcenuBTN.Name = "UpisiOcenuBTN";
            UpisiOcenuBTN.Size = new Size(94, 29);
            UpisiOcenuBTN.TabIndex = 4;
            UpisiOcenuBTN.Text = "button1";
            UpisiOcenuBTN.UseVisualStyleBackColor = true;
            UpisiOcenuBTN.Click += UpisiOcenuBTN_Click;
            // 
            // BackBTN
            // 
            BackBTN.Location = new Point(916, 12);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(94, 55);
            BackBTN.TabIndex = 2;
            BackBTN.Text = "Nazad";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // UpisiOcenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 673);
            Controls.Add(BackBTN);
            Controls.Add(LoginPanel);
            Name = "UpisiOcenuForm";
            Text = "UpisiOcenuForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LoginPanel;
        private ComboBox boxPredmet;
        private Label label3;
        private Label label2;
        private Button UpisiOcenuBTN;
        private Label label4;
        private TextBox textboxOpis;
        private Label label1;
        private Button BackBTN;
        private ComboBox boxOcene;
        private ComboBox boxImeUcenika;
    }
}