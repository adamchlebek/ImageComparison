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
            this.pbImageOne = new System.Windows.Forms.PictureBox();
            this.pbImageTwo = new System.Windows.Forms.PictureBox();
            this.btnUploadOne = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUploadTwo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCompare = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblCurrent = new MaterialSkin.Controls.MaterialLabel();
            this.lblPictureOne = new MaterialSkin.Controls.MaterialLabel();
            this.lblPictureTwo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageOne
            // 
            this.pbImageOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageOne.Location = new System.Drawing.Point(13, 119);
            this.pbImageOne.Name = "pbImageOne";
            this.pbImageOne.Size = new System.Drawing.Size(250, 250);
            this.pbImageOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageOne.TabIndex = 2;
            this.pbImageOne.TabStop = false;
            // 
            // pbImageTwo
            // 
            this.pbImageTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageTwo.Location = new System.Drawing.Point(410, 119);
            this.pbImageTwo.Name = "pbImageTwo";
            this.pbImageTwo.Size = new System.Drawing.Size(250, 250);
            this.pbImageTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageTwo.TabIndex = 3;
            this.pbImageTwo.TabStop = false;
            // 
            // btnUploadOne
            // 
            this.btnUploadOne.AutoSize = true;
            this.btnUploadOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadOne.Depth = 0;
            this.btnUploadOne.Icon = null;
            this.btnUploadOne.Location = new System.Drawing.Point(52, 74);
            this.btnUploadOne.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadOne.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadOne.Name = "btnUploadOne";
            this.btnUploadOne.Primary = false;
            this.btnUploadOne.Size = new System.Drawing.Size(159, 36);
            this.btnUploadOne.TabIndex = 9;
            this.btnUploadOne.Text = "Upload First Image";
            this.btnUploadOne.UseVisualStyleBackColor = true;
            this.btnUploadOne.Click += new System.EventHandler(this.BtnUploadOne_Click);
            // 
            // btnUploadTwo
            // 
            this.btnUploadTwo.AutoSize = true;
            this.btnUploadTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadTwo.Depth = 0;
            this.btnUploadTwo.Icon = null;
            this.btnUploadTwo.Location = new System.Drawing.Point(449, 74);
            this.btnUploadTwo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadTwo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadTwo.Name = "btnUploadTwo";
            this.btnUploadTwo.Primary = false;
            this.btnUploadTwo.Size = new System.Drawing.Size(176, 36);
            this.btnUploadTwo.TabIndex = 10;
            this.btnUploadTwo.Text = "Upload Second Image";
            this.btnUploadTwo.UseVisualStyleBackColor = true;
            this.btnUploadTwo.Click += new System.EventHandler(this.BtnUploadTwo_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.AutoSize = true;
            this.btnCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompare.Depth = 0;
            this.btnCompare.Icon = null;
            this.btnCompare.Location = new System.Drawing.Point(292, 333);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Primary = false;
            this.btnCompare.Size = new System.Drawing.Size(86, 36);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click_1);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Depth = 0;
            this.lblCurrent.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrent.Location = new System.Drawing.Point(12, 405);
            this.lblCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(138, 19);
            this.lblCurrent.TabIndex = 12;
            this.lblCurrent.Text = "Ready For Upload...";
            // 
            // lblPictureOne
            // 
            this.lblPictureOne.AutoSize = true;
            this.lblPictureOne.Depth = 0;
            this.lblPictureOne.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPictureOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPictureOne.Location = new System.Drawing.Point(30, 451);
            this.lblPictureOne.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPictureOne.Name = "lblPictureOne";
            this.lblPictureOne.Size = new System.Drawing.Size(0, 19);
            this.lblPictureOne.TabIndex = 14;
            // 
            // lblPictureTwo
            // 
            this.lblPictureTwo.AutoSize = true;
            this.lblPictureTwo.Depth = 0;
            this.lblPictureTwo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPictureTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPictureTwo.Location = new System.Drawing.Point(30, 518);
            this.lblPictureTwo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPictureTwo.Name = "lblPictureTwo";
            this.lblPictureTwo.Size = new System.Drawing.Size(0, 19);
            this.lblPictureTwo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 659);
            this.Controls.Add(this.lblPictureTwo);
            this.Controls.Add(this.lblPictureOne);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnUploadTwo);
            this.Controls.Add(this.btnUploadOne);
            this.Controls.Add(this.pbImageTwo);
            this.Controls.Add(this.pbImageOne);
            this.Name = "Form1";
            this.Text = "Image Compare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImageOne;
        private System.Windows.Forms.PictureBox pbImageTwo;
        private MaterialSkin.Controls.MaterialFlatButton btnUploadOne;
        private MaterialSkin.Controls.MaterialFlatButton btnUploadTwo;
        private MaterialSkin.Controls.MaterialFlatButton btnCompare;
        private MaterialSkin.Controls.MaterialLabel lblCurrent;
        private MaterialSkin.Controls.MaterialLabel lblPictureOne;
        private MaterialSkin.Controls.MaterialLabel lblPictureTwo;
    }
}

