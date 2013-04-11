using System.Drawing;
namespace WindowsFormsApplication1
{
    partial class CSPDResult
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

        private double[] CSPDInfo;

        public void setCSPDInfo(Image img,int whRatio, double[] vProj,double[] hProj,double[] tShape,double[] bShape) {
            pictureBox1.Image = img;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            whRatioLbl.Text = whRatio + "";

            string vProjStr = "";
            foreach (double val in vProj) {
                vProjStr += val + " ";
            }
            vProjLbl.Text = vProjStr;

            string hProjStr = "";
            foreach (double val in hProj) {
                hProjStr += val + " ";
            }
            hProjLbl.Text = hProjStr;

            string tShapeStr = "";
            foreach (double val in tShape)
            {
                tShapeStr += val + " ";
            }
            tShapLbl.Text = tShapeStr;

            string bShapeStr = "";
            foreach (double val in bShape)
            {
                bShapeStr += val + " ";
            }
            bShapLbl.Text = bShapeStr;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.whRatioLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hProjLbl = new System.Windows.Forms.Label();
            this.vProjLbl = new System.Windows.Forms.Label();
            this.tShapLbl = new System.Windows.Forms.Label();
            this.bShapLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width/Height Ratio :";
            // 
            // whRatioLbl
            // 
            this.whRatioLbl.AutoSize = true;
            this.whRatioLbl.Location = new System.Drawing.Point(154, 22);
            this.whRatioLbl.Name = "whRatioLbl";
            this.whRatioLbl.Size = new System.Drawing.Size(0, 13);
            this.whRatioLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horizontal Projection :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vertical Projection :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Top Shape :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bottom Shape :";
            // 
            // hProjLbl
            // 
            this.hProjLbl.AutoSize = true;
            this.hProjLbl.Location = new System.Drawing.Point(165, 112);
            this.hProjLbl.Name = "hProjLbl";
            this.hProjLbl.Size = new System.Drawing.Size(110, 13);
            this.hProjLbl.TabIndex = 6;
            this.hProjLbl.Text = "Horizontal Projection :";
            // 
            // vProjLbl
            // 
            this.vProjLbl.AutoSize = true;
            this.vProjLbl.Location = new System.Drawing.Point(165, 69);
            this.vProjLbl.Name = "vProjLbl";
            this.vProjLbl.Size = new System.Drawing.Size(110, 13);
            this.vProjLbl.TabIndex = 7;
            this.vProjLbl.Text = "Horizontal Projection :";
            // 
            // tShapLbl
            // 
            this.tShapLbl.AutoSize = true;
            this.tShapLbl.Location = new System.Drawing.Point(165, 153);
            this.tShapLbl.Name = "tShapLbl";
            this.tShapLbl.Size = new System.Drawing.Size(110, 13);
            this.tShapLbl.TabIndex = 8;
            this.tShapLbl.Text = "Horizontal Projection :";
            // 
            // bShapLbl
            // 
            this.bShapLbl.AutoSize = true;
            this.bShapLbl.Location = new System.Drawing.Point(165, 199);
            this.bShapLbl.Name = "bShapLbl";
            this.bShapLbl.Size = new System.Drawing.Size(110, 13);
            this.bShapLbl.TabIndex = 9;
            this.bShapLbl.Text = "Horizontal Projection :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(323, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 170);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CSPDResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bShapLbl);
            this.Controls.Add(this.tShapLbl);
            this.Controls.Add(this.vProjLbl);
            this.Controls.Add(this.hProjLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whRatioLbl);
            this.Controls.Add(this.label1);
            this.Name = "CSPDResult";
            this.Text = "CSPDResult";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label whRatioLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hProjLbl;
        private System.Windows.Forms.Label vProjLbl;
        private System.Windows.Forms.Label tShapLbl;
        private System.Windows.Forms.Label bShapLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}