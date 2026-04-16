namespace Maturski
{
    partial class UcenikForm
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
            panelMain = new FlowLayoutPanel();
            panelParent = new Panel();
            panelParent.SuspendLayout();
            SuspendLayout();
            // 
            // IzostanciBTN
            // 
            IzostanciBTN.Font = new Font("Segoe UI", 12F);
            IzostanciBTN.Click += IzostanciBTN_Click;
            // 
            // OceneBTN
            // 
            OceneBTN.Font = new Font("Segoe UI", 12F);
            OceneBTN.Click += OceneBTN_Click;
            // 
            // PocetakBTN
            // 
            PocetakBTN.Font = new Font("Segoe UI", 12F);
            PocetakBTN.Click += PocetakBTN_Click;
            // 
            // logoutBTN
            // 
            logoutBTN.Click += logoutBTN_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = SystemColors.ActiveCaption;
            panelMain.Dock = DockStyle.Fill;
            panelMain.FlowDirection = FlowDirection.TopDown;
            panelMain.Location = new Point(0, 0);
            panelMain.MaximumSize = new Size(10000, 1000);
            panelMain.MinimumSize = new Size(500, 500);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1422, 768);
            panelMain.TabIndex = 2;
            panelMain.WrapContents = false;
            // 
            // panelParent
            // 
            panelParent.Controls.Add(panelMain);
            panelParent.Dock = DockStyle.Fill;
            panelParent.Location = new Point(0, 209);
            panelParent.Name = "panelParent";
            panelParent.Size = new Size(1422, 768);
            panelParent.TabIndex = 3;
            // 
            // UcenikForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panelParent);
            Name = "UcenikForm";
            Text = "UcenikForm";
            Controls.SetChildIndex(panelParent, 0);
            panelParent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private FlowLayoutPanel panelMain;
        private Panel panelParent;
    }
}