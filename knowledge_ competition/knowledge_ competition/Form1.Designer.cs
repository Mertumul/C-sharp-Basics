
namespace knowledge__competition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btna = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblquestionno = new System.Windows.Forms.Label();
            this.lbl_number_of_correct = new System.Windows.Forms.Label();
            this.lbl_bumber_of_incorrect = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(17, 351);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(232, 51);
            this.btna.TabIndex = 0;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 330);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(255, 351);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(232, 51);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(17, 408);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(232, 51);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(255, 408);
            this.btnd.Name = "btnd";
            this.btnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnd.Size = new System.Drawing.Size(232, 51);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Correct:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Incorrect: ";
            // 
            // lblquestionno
            // 
            this.lblquestionno.AutoSize = true;
            this.lblquestionno.Location = new System.Drawing.Point(700, 56);
            this.lblquestionno.Name = "lblquestionno";
            this.lblquestionno.Size = new System.Drawing.Size(17, 19);
            this.lblquestionno.TabIndex = 8;
            this.lblquestionno.Text = "0";
            // 
            // lbl_number_of_correct
            // 
            this.lbl_number_of_correct.AutoSize = true;
            this.lbl_number_of_correct.Location = new System.Drawing.Point(700, 123);
            this.lbl_number_of_correct.Name = "lbl_number_of_correct";
            this.lbl_number_of_correct.Size = new System.Drawing.Size(17, 19);
            this.lbl_number_of_correct.TabIndex = 9;
            this.lbl_number_of_correct.Text = "0";
            // 
            // lbl_bumber_of_incorrect
            // 
            this.lbl_bumber_of_incorrect.AutoSize = true;
            this.lbl_bumber_of_incorrect.Location = new System.Drawing.Point(700, 195);
            this.lbl_bumber_of_incorrect.Name = "lbl_bumber_of_incorrect";
            this.lbl_bumber_of_incorrect.Size = new System.Drawing.Size(17, 19);
            this.lbl_bumber_of_incorrect.TabIndex = 10;
            this.lbl_bumber_of_incorrect.Text = "0";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(538, 243);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(252, 34);
            this.btnnext.TabIndex = 11;
            this.btnnext.Text = "Start";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(691, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(855, 521);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lbl_bumber_of_incorrect);
            this.Controls.Add(this.lbl_number_of_correct);
            this.Controls.Add(this.lblquestionno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btna);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblquestionno;
        private System.Windows.Forms.Label lbl_number_of_correct;
        private System.Windows.Forms.Label lbl_bumber_of_incorrect;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

