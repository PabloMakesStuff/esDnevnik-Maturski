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
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboPredmeti = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            RegistarBTN = new Button();
            textboxUcenik = new TextBox();
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
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(textBox1);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(comboBox1);
            LoginPanel.Controls.Add(comboPredmeti);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(RegistarBTN);
            LoginPanel.Controls.Add(textboxUcenik);
            LoginPanel.Location = new Point(251, 80);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(520, 557);
            LoginPanel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 356);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 11;
            label4.Text = "Opis Ocene";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 379);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 254);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 9;
            label1.Text = "Ocena";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(85, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 8;
            // 
            // comboPredmeti
            // 
            comboPredmeti.FormattingEnabled = true;
            comboPredmeti.Items.AddRange(new object[] { "Matematika", "Fizika", "Srpski", "Engleski", "Nemacki", "Francuski", "Latinski", "Biologija", "Filozofija", "Sociologija", "Istorija", "Geografija", "Programiranje", "Veb programiranje", "Objektno Orijentisano Programiranje", "Primena Racunara", "Baze Podataka", "Programske Paradigme", "Veronauka" });
            comboPredmeti.Location = new Point(85, 74);
            comboPredmeti.Name = "comboPredmeti";
            comboPredmeti.Size = new Size(268, 28);
            comboPredmeti.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 153);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Ime Ucenika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 51);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Ime Predmeta";
            // 
            // RegistarBTN
            // 
            RegistarBTN.Location = new Point(211, 510);
            RegistarBTN.Name = "RegistarBTN";
            RegistarBTN.Size = new Size(94, 29);
            RegistarBTN.TabIndex = 4;
            RegistarBTN.Text = "button1";
            RegistarBTN.UseVisualStyleBackColor = true;
            // 
            // textboxUcenik
            // 
            textboxUcenik.Location = new Point(85, 176);
            textboxUcenik.Name = "textboxUcenik";
            textboxUcenik.Size = new Size(268, 27);
            textboxUcenik.TabIndex = 1;
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
        private ComboBox comboPredmeti;
        private Label label3;
        private Label label2;
        private Button RegistarBTN;
        private TextBox textboxUcenik;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button BackBTN;
    }
}