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
            // panelParentTable
            // 
            panelParentTable.Controls.Add(tablePanelChild);
            // 
            // tablePanelChild
            // 
            tablePanelChild.AutoSize = true;
            tablePanelChild.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tablePanelChild.BackColor = SystemColors.ActiveCaption;
            tablePanelChild.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tablePanelChild.ColumnCount = 1;
            tablePanelChild.ColumnStyles.Add(new ColumnStyle());
            tablePanelChild.ColumnStyles.Add(new ColumnStyle());
            tablePanelChild.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePanelChild.Dock = DockStyle.Fill;
            tablePanelChild.Location = new Point(0, 0);
            tablePanelChild.Margin = new Padding(0);
            tablePanelChild.Name = "tablePanelChild";
            tablePanelChild.Padding = new Padding(80, 40, 80, 0);
            tablePanelChild.RightToLeft = RightToLeft.No;
            tablePanelChild.RowCount = 1;
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.RowStyles.Add(new RowStyle());
            tablePanelChild.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            panelParentTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tablePanelChild;
    }
}