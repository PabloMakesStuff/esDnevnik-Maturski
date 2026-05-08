namespace Maturski.Profesor_forme
{
    partial class OdeljenjeProfesorBTN
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
            labelOdeljenje = new Label();
            labelPredmet = new Label();
            helperBTN = new Button();
            SuspendLayout();
            // 
            // labelOdeljenje
            // 
            labelOdeljenje.AutoSize = true;
            labelOdeljenje.Font = new Font("Segoe UI", 45F);
            labelOdeljenje.Location = new Point(0, 48);
            labelOdeljenje.Margin = new Padding(0);
            labelOdeljenje.Name = "labelOdeljenje";
            labelOdeljenje.Size = new Size(149, 100);
            labelOdeljenje.TabIndex = 0;
            labelOdeljenje.Text = "IV5";
            labelOdeljenje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPredmet
            // 
            labelPredmet.AutoSize = true;
            labelPredmet.Font = new Font("Segoe UI", 20F);
            labelPredmet.Location = new Point(133, 76);
            labelPredmet.Margin = new Padding(0);
            labelPredmet.MaximumSize = new Size(300, 0);
            labelPredmet.Name = "labelPredmet";
            labelPredmet.Size = new Size(148, 46);
            labelPredmet.TabIndex = 1;
            labelPredmet.Text = "Predmet";
            labelPredmet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helperBTN
            // 
            helperBTN.BackColor = Color.Transparent;
            helperBTN.FlatAppearance.BorderColor = Color.Black;
            helperBTN.FlatAppearance.BorderSize = 0;
            helperBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            helperBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            helperBTN.FlatStyle = FlatStyle.Popup;
            helperBTN.Location = new Point(3, 3);
            helperBTN.Name = "helperBTN";
            helperBTN.Size = new Size(467, 190);
            helperBTN.TabIndex = 2;
            helperBTN.UseVisualStyleBackColor = false;
            helperBTN.Click += helperBTN_Click;
            // 
            // OdeljenjeProfesorBTN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelPredmet);
            Controls.Add(labelOdeljenje);
            Controls.Add(helperBTN);
            Name = "OdeljenjeProfesorBTN";
            Size = new Size(487, 196);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOdeljenje;
        private Label labelPredmet;
        private Button helperBTN;
    }
}
