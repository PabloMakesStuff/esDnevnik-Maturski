namespace Maturski
{
    partial class OceneCard
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
            labelOcene = new Label();
            labelOpis = new Label();
            labelPredmet = new Label();
            labelDatum = new Label();
            SuspendLayout();
            // 
            // labelOcene
            // 
            labelOcene.AutoSize = true;
            labelOcene.BackColor = SystemColors.ButtonHighlight;
            labelOcene.Font = new Font("Segoe UI", 100F);
            labelOcene.Location = new Point(25, -21);
            labelOcene.Margin = new Padding(0);
            labelOcene.Name = "labelOcene";
            labelOcene.Size = new Size(183, 221);
            labelOcene.TabIndex = 0;
            labelOcene.Text = "1";
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 10F);
            labelOpis.Location = new Point(236, 80);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(80, 23);
            labelOpis.TabIndex = 1;
            labelOpis.Text = "labelOpis";
            // 
            // labelPredmet
            // 
            labelPredmet.AutoSize = true;
            labelPredmet.Font = new Font("Segoe UI", 20F);
            labelPredmet.Location = new Point(236, 16);
            labelPredmet.Name = "labelPredmet";
            labelPredmet.Size = new Size(109, 46);
            labelPredmet.TabIndex = 2;
            labelPredmet.Text = "label1";
            // 
            // labelDatum
            // 
            labelDatum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDatum.AutoSize = true;
            labelDatum.Font = new Font("Segoe UI", 15F);
            labelDatum.Location = new Point(536, 165);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(81, 35);
            labelDatum.TabIndex = 3;
            labelDatum.Text = "label1";
            // 
            // OceneCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(labelDatum);
            Controls.Add(labelPredmet);
            Controls.Add(labelOpis);
            Controls.Add(labelOcene);
            Name = "OceneCard";
            Size = new Size(620, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOcene;
        private Label labelOpis;
        private Label labelPredmet;
        private Label labelDatum;
    }
}
