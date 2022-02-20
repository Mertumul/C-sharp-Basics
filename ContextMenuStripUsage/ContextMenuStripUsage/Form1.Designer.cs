
namespace ContextMenuStripUsage
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.blackModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proportiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickAccesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackModeToolStripMenuItem,
            this.whiteModeToolStripMenuItem,
            this.proportiesToolStripMenuItem,
            this.quickAccesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // blackModeToolStripMenuItem
            // 
            this.blackModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.blackModeToolStripMenuItem.Name = "blackModeToolStripMenuItem";
            this.blackModeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.blackModeToolStripMenuItem.Text = "Black Mode";
            this.blackModeToolStripMenuItem.Click += new System.EventHandler(this.blackModeToolStripMenuItem_Click);
            // 
            // whiteModeToolStripMenuItem
            // 
            this.whiteModeToolStripMenuItem.Name = "whiteModeToolStripMenuItem";
            this.whiteModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteModeToolStripMenuItem.Text = "White Mode";
            this.whiteModeToolStripMenuItem.Click += new System.EventHandler(this.whiteModeToolStripMenuItem_Click);
            // 
            // proportiesToolStripMenuItem
            // 
            this.proportiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.proportiesToolStripMenuItem.Name = "proportiesToolStripMenuItem";
            this.proportiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proportiesToolStripMenuItem.Text = "Settings";
            this.proportiesToolStripMenuItem.Click += new System.EventHandler(this.proportiesToolStripMenuItem_Click);
            // 
            // quickAccesToolStripMenuItem
            // 
            this.quickAccesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculaterToolStripMenuItem,
            this.paintToolStripMenuItem});
            this.quickAccesToolStripMenuItem.Name = "quickAccesToolStripMenuItem";
            this.quickAccesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quickAccesToolStripMenuItem.Text = "Quick Access";
            // 
            // calculaterToolStripMenuItem
            // 
            this.calculaterToolStripMenuItem.Name = "calculaterToolStripMenuItem";
            this.calculaterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculaterToolStripMenuItem.Text = "Calculater";
            this.calculaterToolStripMenuItem.Click += new System.EventHandler(this.calculaterToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blackModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proportiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickAccesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
    }
}

