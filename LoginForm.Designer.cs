namespace Maturski
{
    partial class LoginForm
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
            LoginPanel = new Panel();
            RegistarBTN = new Button();
            label1 = new Label();
            LoginBTN = new Button();
            Sifra = new TextBox();
            Email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.AutoSize = true;
            LoginPanel.BackColor = Color.CadetBlue;
            LoginPanel.BorderStyle = BorderStyle.Fixed3D;
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(RegistarBTN);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(LoginBTN);
            LoginPanel.Controls.Add(Sifra);
            LoginPanel.Controls.Add(Email);
            LoginPanel.Location = new Point(444, 140);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(534, 696);
            LoginPanel.TabIndex = 0;
            // 
            // RegistarBTN
            // 
            RegistarBTN.Location = new Point(220, 605);
            RegistarBTN.Name = "RegistarBTN";
            RegistarBTN.Size = new Size(94, 29);
            RegistarBTN.TabIndex = 4;
            RegistarBTN.Text = "button1";
            RegistarBTN.UseVisualStyleBackColor = true;
            RegistarBTN.Click += RegistarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 525);
            label1.Name = "label1";
            label1.Size = new Size(259, 20);
            label1.TabIndex = 3;
            label1.Text = "Nemate nalog? Registrujte se odmah!";
            // 
            // LoginBTN
            // 
            LoginBTN.Location = new Point(220, 420);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(94, 29);
            LoginBTN.TabIndex = 2;
            LoginBTN.Text = "button1";
            LoginBTN.UseVisualStyleBackColor = true;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // Sifra
            // 
            Sifra.Location = new Point(92, 279);
            Sifra.Name = "Sifra";
            Sifra.Size = new Size(125, 27);
            Sifra.TabIndex = 1;
            // 
            // Email
            // 
            Email.Location = new Point(92, 133);
            Email.Name = "Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 110);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 256);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Sifra";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(LoginPanel);
            Name = "LoginForm";
            Text = "esDnevnik";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel LoginPanel;
        private TextBox Sifra;
        private TextBox Email;
        private Button LoginBTN;
        private Button RegistarBTN;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
