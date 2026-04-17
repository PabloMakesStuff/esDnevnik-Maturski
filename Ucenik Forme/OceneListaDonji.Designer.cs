namespace Maturski.Ucenik_Forme
{
    partial class OceneListaDonji
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
            labelImePred = new Label();
            labelOcenaPrvo = new Label();
            labelOcenaDrugo = new Label();
            SuspendLayout();
            // 
            // labelImePred
            // 
            labelImePred.AutoSize = true;
            labelImePred.Font = new Font("Segoe UI", 22F);
            labelImePred.Location = new Point(3, 15);
            labelImePred.Name = "labelImePred";
            labelImePred.Size = new Size(120, 50);
            labelImePred.TabIndex = 0;
            labelImePred.Text = "label1";
            // 
            // labelOcenaPrvo
            // 
            labelOcenaPrvo.AutoSize = true;
            labelOcenaPrvo.Font = new Font("Segoe UI", 22F);
            labelOcenaPrvo.Location = new Point(371, 15);
            labelOcenaPrvo.Name = "labelOcenaPrvo";
            labelOcenaPrvo.Size = new Size(42, 50);
            labelOcenaPrvo.TabIndex = 1;
            labelOcenaPrvo.Text = "1";
            labelOcenaPrvo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOcenaDrugo
            // 
            labelOcenaDrugo.AutoSize = true;
            labelOcenaDrugo.Font = new Font("Segoe UI", 22F);
            labelOcenaDrugo.Location = new Point(730, 15);
            labelOcenaDrugo.Name = "labelOcenaDrugo";
            labelOcenaDrugo.Size = new Size(42, 50);
            labelOcenaDrugo.TabIndex = 2;
            labelOcenaDrugo.Text = "2";
            labelOcenaDrugo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OceneListaDonji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelOcenaDrugo);
            Controls.Add(labelOcenaPrvo);
            Controls.Add(labelImePred);
            Name = "OceneListaDonji";
            Size = new Size(1026, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelImePred;
        private Label labelOcenaPrvo;
        private Label labelOcenaDrugo;
    }
}
