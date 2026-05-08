namespace Maturski.Profesor_forme
{
    partial class ProfesorForm
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
            tablePanelChild = new TableLayoutPanel();
            panelParentTable.SuspendLayout();
            SuspendLayout();
            // 
            // labelDobarDan
            // 
            labelDobarDan.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDobarDan.Location = new Point(235, 74);
            labelDobarDan.Size = new Size(151, 60);
            // 
            // panelParentTable
            // 
            panelParentTable.Controls.Add(tablePanelChild);
            // 
            // IzlogujSeBTN
            // 
            IzlogujSeBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IzlogujSeBTN.Font = new Font("Segoe UI", 12F);
            // 
            // tablePanelChild
            // 
            tablePanelChild.AutoScroll = true;
            tablePanelChild.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tablePanelChild.BackColor = Color.FromArgb(144, 145, 139);
            tablePanelChild.ColumnCount = 3;
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablePanelChild.Dock = DockStyle.Fill;
            tablePanelChild.Location = new Point(0, 0);
            tablePanelChild.Margin = new Padding(0);
            tablePanelChild.Name = "tablePanelChild";
            tablePanelChild.Padding = new Padding(80, 40, 80, 0);
            tablePanelChild.RightToLeft = RightToLeft.No;
            tablePanelChild.RowCount = 1;
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.Size = new Size(1422, 768);
            tablePanelChild.TabIndex = 0;
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            Load += ProfesorForm_Load;
            panelParentTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tablePanelChild;
    }
}