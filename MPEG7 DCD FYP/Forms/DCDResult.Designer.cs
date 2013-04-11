using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
namespace WindowsFormsApplication1
{
    partial class DCDResult
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

        private List<int[]> dcdInfo;
        public void setDCDInfo(String fileName,List<int[]> dcd) {
            this.dcdInfo = dcd;
            Image img = Image.FromFile(fileName);
            inputContainer.SizeMode = PictureBoxSizeMode.Zoom;
            inputContainer.Image = img;

            setPanelColorsAndImages(dcd);
        }

        private void setPanelColorsAndImages(List<int[]> dcd)
        {
            Panel[] clrPanelArr = new Panel[] { clrPnl6, clrPnl5, clrPnl4, clrPnl3, clrPnl2, clrPnl1 };
            Label[] txtBoxes = new Label[] { pcntLbl6, pcntLbl5, pcntLbl4, pcntLbl3, pcntLbl2, pcntLbl1 };

            for (int i = 0; i < 6; i++)
            {
                clrPanelArr[i].BackColor = Color.FromKnownColor(KnownColor.Gray);
                txtBoxes[i].Text = "";
            }

            int idx = 5;
            for (int j = dcd.Count - 1; j >= 0; j--)
            {
                if (idx < 0)
                {
                    break;
                }
                clrPanelArr[idx].BackColor = Color.FromArgb(dcd[j][0], dcd[j][1], dcd[j][2]);
                txtBoxes[idx].Text = dcd[j][3] + "%";
                idx--;
            }



        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcntLbl1 = new System.Windows.Forms.Label();
            this.clrPnl1 = new System.Windows.Forms.Panel();
            this.pcntLbl2 = new System.Windows.Forms.Label();
            this.clrPnl2 = new System.Windows.Forms.Panel();
            this.pcntLbl4 = new System.Windows.Forms.Label();
            this.clrPnl4 = new System.Windows.Forms.Panel();
            this.pcntLbl3 = new System.Windows.Forms.Label();
            this.clrPnl3 = new System.Windows.Forms.Panel();
            this.pcntLbl6 = new System.Windows.Forms.Label();
            this.clrPnl6 = new System.Windows.Forms.Panel();
            this.pcntLbl5 = new System.Windows.Forms.Label();
            this.clrPnl5 = new System.Windows.Forms.Panel();
            this.inputContainer = new System.Windows.Forms.PictureBox();
            this.clrPnl1.SuspendLayout();
            
            this.clrPnl2.SuspendLayout();
            
            this.clrPnl4.SuspendLayout();
            
            this.clrPnl3.SuspendLayout();
            
            this.clrPnl6.SuspendLayout();
            
            this.clrPnl5.SuspendLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.inputContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcntLbl1
            // 
            this.pcntLbl1.AutoSize = true;
            this.pcntLbl1.Location = new System.Drawing.Point(353, 22);
            this.pcntLbl1.Name = "pcntLbl1";
            this.pcntLbl1.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl1.TabIndex = 6;
            this.pcntLbl1.Text = "label2";
            // 
            // clrPnl1
            // 
            this.clrPnl1.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl1.Location = new System.Drawing.Point(273, 22);
            this.clrPnl1.Name = "clrPnl1";
            this.clrPnl1.Size = new System.Drawing.Size(60, 24);
            this.clrPnl1.TabIndex = 5;
            // 
            // pcntLbl2
            // 
            this.pcntLbl2.AutoSize = true;
            this.pcntLbl2.Location = new System.Drawing.Point(353, 61);
            this.pcntLbl2.Name = "pcntLbl2";
            this.pcntLbl2.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl2.TabIndex = 8;
            this.pcntLbl2.Text = "label2";
            // 
            // clrPnl2
            // 
            this.clrPnl2.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl2.Location = new System.Drawing.Point(273, 61);
            this.clrPnl2.Name = "clrPnl2";
            this.clrPnl2.Size = new System.Drawing.Size(60, 24);
            this.clrPnl2.TabIndex = 7;
            // 
            // pcntLbl4
            // 
            this.pcntLbl4.AutoSize = true;
            this.pcntLbl4.Location = new System.Drawing.Point(353, 138);
            this.pcntLbl4.Name = "pcntLbl4";
            this.pcntLbl4.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl4.TabIndex = 12;
            this.pcntLbl4.Text = "label2";
            // 
            // clrPnl4
            // 
            this.clrPnl4.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl4.Location = new System.Drawing.Point(273, 138);
            this.clrPnl4.Name = "clrPnl4";
            this.clrPnl4.Size = new System.Drawing.Size(60, 24);
            this.clrPnl4.TabIndex = 11;
            // 
            // pcntLbl3
            // 
            this.pcntLbl3.AutoSize = true;
            this.pcntLbl3.Location = new System.Drawing.Point(353, 99);
            this.pcntLbl3.Name = "pcntLbl3";
            this.pcntLbl3.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl3.TabIndex = 10;
            this.pcntLbl3.Text = "label2";
            // 
            // clrPnl3
            // 
            this.clrPnl3.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl3.Location = new System.Drawing.Point(273, 99);
            this.clrPnl3.Name = "clrPnl3";
            this.clrPnl3.Size = new System.Drawing.Size(60, 24);
            this.clrPnl3.TabIndex = 9;
            // 
            // pcntLbl6
            // 
            this.pcntLbl6.AutoSize = true;
            this.pcntLbl6.Location = new System.Drawing.Point(352, 214);
            this.pcntLbl6.Name = "pcntLbl6";
            this.pcntLbl6.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl6.TabIndex = 16;
            this.pcntLbl6.Text = "label2";
            // 
            // clrPnl6
            // 
            this.clrPnl6.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl6.Location = new System.Drawing.Point(272, 214);
            this.clrPnl6.Name = "clrPnl6";
            this.clrPnl6.Size = new System.Drawing.Size(60, 24);
            this.clrPnl6.TabIndex = 15;
            // 
            // pcntLbl5
            // 
            this.pcntLbl5.AutoSize = true;
            this.pcntLbl5.Location = new System.Drawing.Point(353, 175);
            this.pcntLbl5.Name = "pcntLbl5";
            this.pcntLbl5.Size = new System.Drawing.Size(35, 13);
            this.pcntLbl5.TabIndex = 14;
            this.pcntLbl5.Text = "label2";
            // 
            // clrPnl5
            // 
            this.clrPnl5.BackColor = System.Drawing.SystemColors.Control;
            this.clrPnl5.Location = new System.Drawing.Point(273, 175);
            this.clrPnl5.Name = "clrPnl5";
            this.clrPnl5.Size = new System.Drawing.Size(60, 24);
            this.clrPnl5.TabIndex = 13;
            // 
            // inputContainer
            // 
            this.inputContainer.Location = new System.Drawing.Point(28, 22);
            this.inputContainer.Name = "inputContainer";
            this.inputContainer.Size = new System.Drawing.Size(171, 150);
            this.inputContainer.TabIndex = 17;
            this.inputContainer.TabStop = false;
            // 
            // DCDResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.inputContainer);
            this.Controls.Add(this.pcntLbl6);
            this.Controls.Add(this.clrPnl6);
            this.Controls.Add(this.pcntLbl5);
            this.Controls.Add(this.clrPnl5);
            this.Controls.Add(this.pcntLbl4);
            this.Controls.Add(this.clrPnl4);
            this.Controls.Add(this.pcntLbl3);
            this.Controls.Add(this.clrPnl3);
            this.Controls.Add(this.pcntLbl2);
            this.Controls.Add(this.clrPnl2);
            this.Controls.Add(this.pcntLbl1);
            this.Controls.Add(this.clrPnl1);
            this.Name = "DCDResult";
            this.Text = "DCDResult";
            this.clrPnl1.ResumeLayout(false);
            this.clrPnl1.PerformLayout();
            this.clrPnl2.ResumeLayout(false);
            this.clrPnl2.PerformLayout();
            this.clrPnl4.ResumeLayout(false);
            this.clrPnl4.PerformLayout();
            this.clrPnl3.ResumeLayout(false);
            this.clrPnl3.PerformLayout();
            this.clrPnl6.ResumeLayout(false);
            this.clrPnl6.PerformLayout();
            this.clrPnl5.ResumeLayout(false);
            this.clrPnl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcntLbl1;
        private System.Windows.Forms.Panel clrPnl1;
        private System.Windows.Forms.Label pcntLbl2;
        private System.Windows.Forms.Panel clrPnl2;
        private System.Windows.Forms.Label pcntLbl4;
        private System.Windows.Forms.Panel clrPnl4;
        private System.Windows.Forms.Label pcntLbl3;
        private System.Windows.Forms.Panel clrPnl3;
        private System.Windows.Forms.Label pcntLbl6;
        private System.Windows.Forms.Panel clrPnl6;
        private System.Windows.Forms.Label pcntLbl5;
        private System.Windows.Forms.Panel clrPnl5;
        private System.Windows.Forms.PictureBox inputContainer;
    }
}