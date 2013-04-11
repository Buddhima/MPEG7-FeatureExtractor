using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
namespace WindowsFormsApplication1
{
    partial class CLDResult
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

        private Image cldImage;
        private List<int[]> rgbValues;

        public void setCLDInfo(Image cldImage, List<int[]> rgbs) {
            this.cldImage = cldImage;
            this.rgbValues = rgbs;
            displayResults();
        }

        private void displayResults() {
            cldPicture.SizeMode = PictureBoxSizeMode.Zoom;
            cldPicture.Image = cldImage;
            colorsTxtBox.Clear();
            int i = 1;
            foreach (int[] rgb in rgbValues){
                String rgbString = i+": "+rgb[0]+","+rgb[1]+","+rgb[2]+"\n";
                colorsTxtBox.AppendText(rgbString);
                i++;
            }
            
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cldPicture = new System.Windows.Forms.PictureBox();
            this.colorsTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cldPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cldPicture
            // 
            this.cldPicture.Location = new System.Drawing.Point(42, 25);
            this.cldPicture.Name = "cldPicture";
            this.cldPicture.Size = new System.Drawing.Size(254, 228);
            this.cldPicture.TabIndex = 0;
            this.cldPicture.TabStop = false;
            // 
            // colorsTxtBox
            // 
            this.colorsTxtBox.Location = new System.Drawing.Point(317, 25);
            this.colorsTxtBox.Multiline = true;
            this.colorsTxtBox.Name = "colorsTxtBox";
            this.colorsTxtBox.Size = new System.Drawing.Size(100, 228);
            this.colorsTxtBox.TabIndex = 1;
            // 
            // CLDResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 332);
            this.Controls.Add(this.colorsTxtBox);
            this.Controls.Add(this.cldPicture);
            this.Name = "CLDResult";
            this.Text = "CLDResult";
            ((System.ComponentModel.ISupportInitialize)(this.cldPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cldPicture;
        private TextBox colorsTxtBox;
    }
}