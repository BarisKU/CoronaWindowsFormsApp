
namespace CoronaApp
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tespitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belirtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tespitToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tespitToolStripMenuItem
            // 
            this.tespitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belirtiToolStripMenuItem,
            this.yüzdeToolStripMenuItem});
            this.tespitToolStripMenuItem.Name = "tespitToolStripMenuItem";
            this.tespitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tespitToolStripMenuItem.Text = "Tespit";
            // 
            // belirtiToolStripMenuItem
            // 
            this.belirtiToolStripMenuItem.Name = "belirtiToolStripMenuItem";
            this.belirtiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.belirtiToolStripMenuItem.Text = "Belirti";
            this.belirtiToolStripMenuItem.Click += new System.EventHandler(this.belirtiToolStripMenuItem_Click);
            // 
            // yüzdeToolStripMenuItem
            // 
            this.yüzdeToolStripMenuItem.Name = "yüzdeToolStripMenuItem";
            this.yüzdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yüzdeToolStripMenuItem.Text = "Yüzde";
            this.yüzdeToolStripMenuItem.Click += new System.EventHandler(this.yüzdeToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "CoronaApp";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tespitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belirtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzdeToolStripMenuItem;
    }
}

