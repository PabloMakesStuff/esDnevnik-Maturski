namespace Maturski.Ucenik_Forme
{
    partial class IzostanciListaDonji
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
            labelPredmet = new Label();
            labelNeregulisani = new Label();
            labelNeopravdani = new Label();
            labelOpravdani = new Label();
            SuspendLayout();
            // 
            // labelPredmet
            // 
            labelPredmet.AutoSize = true;
            labelPredmet.Font = new Font("Segoe UI", 22F);
            labelPredmet.Location = new Point(6, 15);
            labelPredmet.Name = "labelPredmet";
            labelPredmet.Size = new Size(170, 50);
            labelPredmet.TabIndex = 7;
            labelPredmet.Text = "Predmeti";
            labelPredmet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNeregulisani
            // 
            labelNeregulisani.AutoSize = true;
            labelNeregulisani.Font = new Font("Segoe UI", 22F);
            labelNeregulisani.Location = new Point(880, 15);
            labelNeregulisani.Name = "labelNeregulisani";
            labelNeregulisani.Size = new Size(248, 50);
            labelNeregulisani.TabIndex = 6;
            labelNeregulisani.Text = "Neregulisanih";
            labelNeregulisani.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNeopravdani
            // 
            labelNeopravdani.AutoSize = true;
            labelNeopravdani.Font = new Font("Segoe UI", 22F);
            labelNeopravdani.Location = new Point(570, 15);
            labelNeopravdani.Name = "labelNeopravdani";
            labelNeopravdani.Size = new Size(234, 50);
            labelNeopravdani.TabIndex = 5;
            labelNeopravdani.Text = "Neopravdani";
            labelNeopravdani.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOpravdani
            // 
            labelOpravdani.AutoSize = true;
            labelOpravdani.Font = new Font("Segoe UI", 22F);
            labelOpravdani.Location = new Point(302, 15);
            labelOpravdani.Name = "labelOpravdani";
            labelOpravdani.Size = new Size(193, 50);
            labelOpravdani.TabIndex = 4;
            labelOpravdani.Text = "Opravdani";
            labelOpravdani.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IzostanciListaDonji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPredmet);
            Controls.Add(labelNeregulisani);
            Controls.Add(labelNeopravdani);
            Controls.Add(labelOpravdani);
            Name = "IzostanciListaDonji";
            Size = new Size(1034, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPredmet;
        private Label labelNeregulisani;
        private Label labelNeopravdani;
        private Label labelOpravdani;
    }
}
