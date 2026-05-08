namespace Maturski.Profesor_forme
{
    partial class UcenikProfilIndividuo
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
            labelImeUcenika = new Label();
            UcenikIndividuoBTN = new Button();
            SuspendLayout();
            // 
            // labelImeUcenika
            // 
            labelImeUcenika.AutoSize = true;
            labelImeUcenika.BackColor = Color.Transparent;
            labelImeUcenika.Font = new Font("Segoe UI", 30F);
            labelImeUcenika.ForeColor = SystemColors.ControlText;
            labelImeUcenika.ImageAlign = ContentAlignment.MiddleLeft;
            labelImeUcenika.Location = new Point(3, 65);
            labelImeUcenika.Name = "labelImeUcenika";
            labelImeUcenika.Size = new Size(160, 67);
            labelImeUcenika.TabIndex = 0;
            labelImeUcenika.Text = "label1";
            labelImeUcenika.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcenikIndividuoBTN
            // 
            UcenikIndividuoBTN.BackColor = Color.Transparent;
            UcenikIndividuoBTN.FlatStyle = FlatStyle.Popup;
            UcenikIndividuoBTN.ForeColor = Color.Transparent;
            UcenikIndividuoBTN.Location = new Point(3, 3);
            UcenikIndividuoBTN.Name = "UcenikIndividuoBTN";
            UcenikIndividuoBTN.Size = new Size(454, 190);
            UcenikIndividuoBTN.TabIndex = 1;
            UcenikIndividuoBTN.UseVisualStyleBackColor = false;
            UcenikIndividuoBTN.Click += UcenikIndividuoBTN_Click;
            // 
            // UcenikProfilIndividuo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelImeUcenika);
            Controls.Add(UcenikIndividuoBTN);
            Name = "UcenikProfilIndividuo";
            Size = new Size(460, 196);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelImeUcenika;
        private Button UcenikIndividuoBTN;
    }
}
