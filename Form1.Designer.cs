namespace Image_Comparison
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
            this.btnImageOne = new System.Windows.Forms.Button();
            this.pbImageOne = new System.Windows.Forms.PictureBox();
            this.pbImageTwo = new System.Windows.Forms.PictureBox();
            this.btnImageTwo = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.lblPictureOne = new System.Windows.Forms.Label();
            this.lblPictureTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTwo)).BeginInit();
            this.gbStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImageOne
            // 
            this.btnImageOne.Location = new System.Drawing.Point(13, 13);
            this.btnImageOne.Name = "btnImageOne";
            this.btnImageOne.Size = new System.Drawing.Size(145, 145);
            this.btnImageOne.TabIndex = 0;
            this.btnImageOne.Text = "Upload Image One";
            this.btnImageOne.UseVisualStyleBackColor = true;
            this.btnImageOne.Click += new System.EventHandler(this.BtnImageOne_Click);
            // 
            // pbImageOne
            // 
            this.pbImageOne.Location = new System.Drawing.Point(164, 13);
            this.pbImageOne.Name = "pbImageOne";
            this.pbImageOne.Size = new System.Drawing.Size(145, 145);
            this.pbImageOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImageOne.TabIndex = 2;
            this.pbImageOne.TabStop = false;
            // 
            // pbImageTwo
            // 
            this.pbImageTwo.Location = new System.Drawing.Point(164, 164);
            this.pbImageTwo.Name = "pbImageTwo";
            this.pbImageTwo.Size = new System.Drawing.Size(145, 145);
            this.pbImageTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImageTwo.TabIndex = 3;
            this.pbImageTwo.TabStop = false;
            // 
            // btnImageTwo
            // 
            this.btnImageTwo.Location = new System.Drawing.Point(13, 164);
            this.btnImageTwo.Name = "btnImageTwo";
            this.btnImageTwo.Size = new System.Drawing.Size(145, 145);
            this.btnImageTwo.TabIndex = 4;
            this.btnImageTwo.Text = "Upload Image Two";
            this.btnImageTwo.UseVisualStyleBackColor = true;
            this.btnImageTwo.Click += new System.EventHandler(this.BtnImageTwo_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(13, 346);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(296, 23);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Ready For Upload...";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 402);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(297, 23);
            this.pbProgress.TabIndex = 7;
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lblPictureTwo);
            this.gbStatistics.Controls.Add(this.lblPictureOne);
            this.gbStatistics.Location = new System.Drawing.Point(12, 446);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(297, 127);
            this.gbStatistics.TabIndex = 8;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Statisitcs";
            // 
            // lblPictureOne
            // 
            this.lblPictureOne.AutoSize = true;
            this.lblPictureOne.Location = new System.Drawing.Point(7, 20);
            this.lblPictureOne.Name = "lblPictureOne";
            this.lblPictureOne.Size = new System.Drawing.Size(35, 13);
            this.lblPictureOne.TabIndex = 0;
            this.lblPictureOne.Text = "label1";
            // 
            // lblPictureTwo
            // 
            this.lblPictureTwo.AutoSize = true;
            this.lblPictureTwo.Location = new System.Drawing.Point(6, 76);
            this.lblPictureTwo.Name = "lblPictureTwo";
            this.lblPictureTwo.Size = new System.Drawing.Size(35, 13);
            this.lblPictureTwo.TabIndex = 1;
            this.lblPictureTwo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 585);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnImageTwo);
            this.Controls.Add(this.pbImageTwo);
            this.Controls.Add(this.pbImageOne);
            this.Controls.Add(this.btnImageOne);
            this.Name = "Form1";
            this.Text = "Compare Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTwo)).EndInit();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImageOne;
        private System.Windows.Forms.PictureBox pbImageOne;
        private System.Windows.Forms.PictureBox pbImageTwo;
        private System.Windows.Forms.Button btnImageTwo;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.Label lblPictureTwo;
        private System.Windows.Forms.Label lblPictureOne;
    }
}

