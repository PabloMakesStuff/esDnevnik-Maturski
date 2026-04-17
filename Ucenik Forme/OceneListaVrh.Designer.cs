namespace Maturski.Ucenik_Forme
{
    partial class OceneListaVrh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelOcenaDrugo = new Label();
            labelOcenaPrvo = new Label();
            labelImePred = new Label();
            SuspendLayout();
            // 
            // labelOcenaDrugo
            // 
            labelOcenaDrugo.AutoSize = true;
            labelOcenaDrugo.Font = new Font("Segoe UI", 22F);
            labelOcenaDrugo.Location = new Point(744, 11);
            labelOcenaDrugo.Name = "labelOcenaDrugo";
            labelOcenaDrugo.Size = new Size(42, 50);
            labelOcenaDrugo.TabIndex = 5;
            labelOcenaDrugo.Text = "II";
            // 
            // labelOcenaPrvo
            // 
            labelOcenaPrvo.AutoSize = true;
            labelOcenaPrvo.Font = new Font("Segoe UI", 22F);
            labelOcenaPrvo.Location = new Point(378, 11);
            labelOcenaPrvo.Name = "labelOcenaPrvo";
            labelOcenaPrvo.Size = new Size(32, 50);
            labelOcenaPrvo.TabIndex = 4;
            labelOcenaPrvo.Text = "I";
            // 
            // labelImePred
            // 
            labelImePred.AutoSize = true;
            labelImePred.Font = new Font("Segoe UI", 22F);
            labelImePred.Location = new Point(3, 11);
            labelImePred.Name = "labelImePred";
            labelImePred.Size = new Size(170, 50);
            labelImePred.TabIndex = 3;
            labelImePred.Text = "Predmeti";
            // 
            // OceneListaVrh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(labelOcenaDrugo);
            Controls.Add(labelOcenaPrvo);
            Controls.Add(labelImePred);
            Name = "OceneListaVrh";
            Size = new Size(1034, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOcenaDrugo;
        private Label labelOcenaPrvo;
        private Label labelImePred;
    }
}
