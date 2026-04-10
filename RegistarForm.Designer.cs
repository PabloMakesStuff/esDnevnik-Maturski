namespace Maturski
{
    partial class RegistarForm
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
            LabelOdeljenje = new Label();
            Label = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ImeText = new TextBox();
            PrezimeText = new TextBox();
            ComboBox1 = new ComboBox();
            RegistarBTN = new Button();
            Sifra = new TextBox();
            Email = new TextBox();
            textBox1 = new TextBox();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.AutoSize = true;
            LoginPanel.BackColor = Color.CadetBlue;
            LoginPanel.BorderStyle = BorderStyle.Fixed3D;
            LoginPanel.Controls.Add(textBox1);
            LoginPanel.Controls.Add(LabelOdeljenje);
            LoginPanel.Controls.Add(Label);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(ImeText);
            LoginPanel.Controls.Add(PrezimeText);
            LoginPanel.Controls.Add(ComboBox1);
            LoginPanel.Controls.Add(RegistarBTN);
            LoginPanel.Controls.Add(Sifra);
            LoginPanel.Controls.Add(Email);
            LoginPanel.Location = new Point(444, 140);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(534, 696);
            LoginPanel.TabIndex = 1;
            // 
            // LabelOdeljenje
            // 
            LabelOdeljenje.AutoSize = true;
            LabelOdeljenje.Location = new Point(92, 451);
            LabelOdeljenje.Name = "LabelOdeljenje";
            LabelOdeljenje.Size = new Size(73, 20);
            LabelOdeljenje.TabIndex = 14;
            LabelOdeljenje.Text = "Odeljenje";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(92, 367);
            Label.Name = "Label";
            Label.Size = new Size(49, 20);
            Label.TabIndex = 12;
            Label.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 282);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 11;
            label4.Text = "Sifra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 198);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 132);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 9;
            label2.Text = "Prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 56);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 8;
            label1.Text = "Ime";
            // 
            // ImeText
            // 
            ImeText.Location = new Point(92, 79);
            ImeText.Name = "ImeText";
            ImeText.Size = new Size(125, 27);
            ImeText.TabIndex = 7;
            // 
            // PrezimeText
            // 
            PrezimeText.Location = new Point(92, 155);
            PrezimeText.Name = "PrezimeText";
            PrezimeText.Size = new Size(125, 27);
            PrezimeText.TabIndex = 6;
            // 
            // ComboBox1
            // 
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "Profesor", "Ucenik" });
            ComboBox1.Location = new Point(92, 390);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(151, 28);
            ComboBox1.TabIndex = 5;
            // 
            // RegistarBTN
            // 
            RegistarBTN.Location = new Point(221, 547);
            RegistarBTN.Name = "RegistarBTN";
            RegistarBTN.Size = new Size(94, 29);
            RegistarBTN.TabIndex = 2;
            RegistarBTN.Text = "button1";
            RegistarBTN.UseVisualStyleBackColor = true;
            RegistarBTN.Click += RegistarBTN_Click;
            // 
            // Sifra
            // 
            Sifra.Location = new Point(92, 305);
            Sifra.Name = "Sifra";
            Sifra.Size = new Size(125, 27);
            Sifra.TabIndex = 1;
            // 
            // Email
            // 
            Email.Location = new Point(92, 221);
            Email.Name = "Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 474);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // RegistarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(LoginPanel);
            Name = "RegistarForm";
            Text = "RegistarForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LoginPanel;
        private ComboBox ComboBox1;
        private Button RegistarBTN;
        private TextBox Sifra;
        private TextBox Email;
        private TextBox ImeText;
        private TextBox PrezimeText;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Label;
        private Label LabelOdeljenje;
        private TextBox textBox1;
    }
}