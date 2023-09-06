namespace Digital_Clock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(123, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(286, 110);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "22:22";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Black;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.White;
            this.lblSeconds.Location = new System.Drawing.Point(430, 105);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(62, 44);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(25, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(198, 57);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "June 12";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Black;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(492, 253);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(190, 57);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Sunday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(721, 369);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}

