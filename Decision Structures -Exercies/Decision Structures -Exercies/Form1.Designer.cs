
namespace Decision_Structures__Exercies
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtexam1 = new System.Windows.Forms.TextBox();
            this.txtexam2 = new System.Windows.Forms.TextBox();
            this.txtproject = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RESULTS = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project:";
            // 
            // txtexam1
            // 
            this.txtexam1.Location = new System.Drawing.Point(136, 97);
            this.txtexam1.Name = "txtexam1";
            this.txtexam1.Size = new System.Drawing.Size(100, 27);
            this.txtexam1.TabIndex = 3;
            // 
            // txtexam2
            // 
            this.txtexam2.Location = new System.Drawing.Point(136, 154);
            this.txtexam2.Name = "txtexam2";
            this.txtexam2.Size = new System.Drawing.Size(100, 27);
            this.txtexam2.TabIndex = 4;
            // 
            // txtproject
            // 
            this.txtproject.Location = new System.Drawing.Point(136, 203);
            this.txtproject.Name = "txtproject";
            this.txtproject.Size = new System.Drawing.Size(100, 27);
            this.txtproject.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblresult);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtexam1);
            this.groupBox1.Controls.Add(this.txtproject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtexam2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(53, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RESULTS
            // 
            this.RESULTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RESULTS.FormattingEnabled = true;
            this.RESULTS.IntegralHeight = false;
            this.RESULTS.ItemHeight = 19;
            this.RESULTS.Location = new System.Drawing.Point(768, 34);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.Size = new System.Drawing.Size(356, 342);
            this.RESULTS.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(148, 242);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 19);
            this.lblresult.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.RESULTS);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtexam1;
        private System.Windows.Forms.TextBox txtexam2;
        private System.Windows.Forms.TextBox txtproject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RESULTS;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

