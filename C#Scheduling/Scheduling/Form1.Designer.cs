namespace Scheduling
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBarTotal = new System.Windows.Forms.ProgressBar();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Location = new System.Drawing.Point(12, 12);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(234, 225);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBarTotal
            // 
            this.pBarTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pBarTotal.Location = new System.Drawing.Point(438, 28);
            this.pBarTotal.Name = "pBarTotal";
            this.pBarTotal.Size = new System.Drawing.Size(241, 37);
            this.pBarTotal.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(330, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(102, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Threads Processed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pBarTotal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pBarTotal;
        private System.Windows.Forms.Label lbl;
    }
}

