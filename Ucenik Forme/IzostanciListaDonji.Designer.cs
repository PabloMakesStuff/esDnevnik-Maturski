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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(780, 15);
            label3.Name = "label3";
            label3.Size = new Size(248, 50);
            label3.TabIndex = 6;
            label3.Text = "Neregulisanih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(482, 15);
            label2.Name = "label2";
            label2.Size = new Size(234, 50);
            label2.TabIndex = 5;
            label2.Text = "Neopravdani";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(226, 15);
            label1.Name = "label1";
            label1.Size = new Size(193, 50);
            label1.TabIndex = 4;
            label1.Text = "Opravdani";
            // 
            // IzostanciListaDonji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPredmet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IzostanciListaDonji";
            Size = new Size(1034, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPredmet;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
