namespace Maturski.Profesor_forme
{
    partial class UcenikOceneCard
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
            labelOcena = new Label();
            labelOpis = new Label();
            labelPredmet = new Label();
            SuspendLayout();
            // 
            // labelOcena
            // 
            labelOcena.AutoSize = true;
            labelOcena.Font = new Font("Segoe UI", 50F);
            labelOcena.Location = new Point(10, 24);
            labelOcena.Margin = new Padding(0);
            labelOcena.Name = "labelOcena";
            labelOcena.Size = new Size(92, 112);
            labelOcena.TabIndex = 0;
            labelOcena.Text = "5";
            labelOcena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 11F);
            labelOpis.Location = new Point(105, 55);
            labelOpis.MaximumSize = new Size(250, 300);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(221, 75);
            labelOpis.TabIndex = 1;
            labelOpis.Text = "Tekst ocene ide ovde, ne znam kako da napravim warp";
            // 
            // labelPredmet
            // 
            labelPredmet.AutoSize = true;
            labelPredmet.Font = new Font("Segoe UI", 15F);
            labelPredmet.Location = new Point(105, 9);
            labelPredmet.Name = "labelPredmet";
            labelPredmet.Size = new Size(75, 35);
            labelPredmet.TabIndex = 2;
            labelPredmet.Text = "Fizika";
            // 
            // UcenikOceneCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelPredmet);
            Controls.Add(labelOpis);
            Controls.Add(labelOcena);
            Name = "UcenikOceneCard";
            Size = new Size(379, 160);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOcena;
        private Label labelOpis;
        private Label labelPredmet;
    }
}
