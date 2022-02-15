
namespace digital_clock_with_timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhour = new System.Windows.Forms.Label();
            this.lblminute = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhour.Location = new System.Drawing.Point(250, 101);
            this.lblhour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(31, 33);
            this.lblhour.TabIndex = 0;
            this.lblhour.Text = "0";
            // 
            // lblminute
            // 
            this.lblminute.AutoSize = true;
            this.lblminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminute.Location = new System.Drawing.Point(340, 101);
            this.lblminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblminute.Name = "lblminute";
            this.lblminute.Size = new System.Drawing.Size(31, 33);
            this.lblminute.TabIndex = 1;
            this.lblminute.Text = "0";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsecond.Location = new System.Drawing.Point(438, 101);
            this.lblsecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(31, 33);
            this.lblsecond.TabIndex = 2;
            this.lblsecond.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblminute);
            this.Controls.Add(this.lblhour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label lblminute;
        private System.Windows.Forms.Label lblsecond;
    }
}

