namespace Maturski.Profesor_forme
{
    partial class OdeljenjeProfil
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
            label1 = new Label();
            panelTop = new Panel();
            tablePanelChild = new TableLayoutPanel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1422, 125);
            panelTop.TabIndex = 0;
            // 
            // tablePanelChild
            // 
            tablePanelChild.ColumnCount = 1;
            tablePanelChild.ColumnStyles.Add(new ColumnStyle());
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePanelChild.Dock = DockStyle.Fill;
            tablePanelChild.Location = new Point(0, 125);
            tablePanelChild.Name = "tablePanelChild";
            tablePanelChild.RowCount = 4;
            tablePanelChild.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablePanelChild.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablePanelChild.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablePanelChild.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablePanelChild.Size = new Size(1422, 852);
            tablePanelChild.TabIndex = 1;
            // 
            // OdeljenjeProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(tablePanelChild);
            Controls.Add(panelTop);
            Name = "OdeljenjeProfil";
            Text = "UcenikProfil";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelTop;
        private TableLayoutPanel tablePanelChild;
    }
}