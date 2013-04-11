using System.Drawing;
namespace WindowsFormsApplication1
{
    partial class ShapeResult
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

        public void setShapeInfo(Bitmap originalImage,Bitmap image,int[] shapeCount) {
            shapeImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            editedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            shapeImgBox.Image = originalImage;
            editedPicBox.Image = image;

            circleLbl.Text = shapeCount[0] + "";
            triangleLbl.Text = shapeCount[1] + "";
            squareLbl.Text = shapeCount[2] + "";
            rectangleLbl.Text = shapeCount[3] + "";
            polyUnknwLbl.Text = shapeCount[4] + "";
            trapizoidLbl.Text = shapeCount[5] + "";

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeImgBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circleLbl = new System.Windows.Forms.Label();
            this.triangleLbl = new System.Windows.Forms.Label();
            this.squareLbl = new System.Windows.Forms.Label();
            this.rectangleLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.polyUnknwLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editedPicBox = new System.Windows.Forms.PictureBox();
            this.trapizoidLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapeImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeImgBox
            // 
            this.shapeImgBox.Location = new System.Drawing.Point(21, 12);
            this.shapeImgBox.Name = "shapeImgBox";
            this.shapeImgBox.Size = new System.Drawing.Size(230, 226);
            this.shapeImgBox.TabIndex = 0;
            this.shapeImgBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Circles :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Triangles :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Square :";
            // 
            // circleLbl
            // 
            this.circleLbl.AutoSize = true;
            this.circleLbl.Location = new System.Drawing.Point(71, 250);
            this.circleLbl.Name = "circleLbl";
            this.circleLbl.Size = new System.Drawing.Size(35, 13);
            this.circleLbl.TabIndex = 4;
            this.circleLbl.Text = "label4";
            // 
            // triangleLbl
            // 
            this.triangleLbl.AutoSize = true;
            this.triangleLbl.Location = new System.Drawing.Point(80, 275);
            this.triangleLbl.Name = "triangleLbl";
            this.triangleLbl.Size = new System.Drawing.Size(35, 13);
            this.triangleLbl.TabIndex = 5;
            this.triangleLbl.Text = "label5";
            // 
            // squareLbl
            // 
            this.squareLbl.AutoSize = true;
            this.squareLbl.Location = new System.Drawing.Point(232, 250);
            this.squareLbl.Name = "squareLbl";
            this.squareLbl.Size = new System.Drawing.Size(35, 13);
            this.squareLbl.TabIndex = 6;
            this.squareLbl.Text = "label6";
            // 
            // rectangleLbl
            // 
            this.rectangleLbl.AutoSize = true;
            this.rectangleLbl.Location = new System.Drawing.Point(236, 275);
            this.rectangleLbl.Name = "rectangleLbl";
            this.rectangleLbl.Size = new System.Drawing.Size(35, 13);
            this.rectangleLbl.TabIndex = 8;
            this.rectangleLbl.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rectangle :";
            // 
            // polyUnknwLbl
            // 
            this.polyUnknwLbl.AutoSize = true;
            this.polyUnknwLbl.Location = new System.Drawing.Point(422, 250);
            this.polyUnknwLbl.Name = "polyUnknwLbl";
            this.polyUnknwLbl.Size = new System.Drawing.Size(35, 13);
            this.polyUnknwLbl.TabIndex = 10;
            this.polyUnknwLbl.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Poly Unknown :";
            // 
            // editedPicBox
            // 
            this.editedPicBox.Location = new System.Drawing.Point(272, 12);
            this.editedPicBox.Name = "editedPicBox";
            this.editedPicBox.Size = new System.Drawing.Size(230, 226);
            this.editedPicBox.TabIndex = 11;
            this.editedPicBox.TabStop = false;
            // 
            // trapizoidLbl
            // 
            this.trapizoidLbl.AutoSize = true;
            this.trapizoidLbl.Location = new System.Drawing.Point(422, 275);
            this.trapizoidLbl.Name = "trapizoidLbl";
            this.trapizoidLbl.Size = new System.Drawing.Size(35, 13);
            this.trapizoidLbl.TabIndex = 13;
            this.trapizoidLbl.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trapizoid :";
            // 
            // ShapeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 371);
            this.Controls.Add(this.trapizoidLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editedPicBox);
            this.Controls.Add(this.polyUnknwLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rectangleLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.squareLbl);
            this.Controls.Add(this.triangleLbl);
            this.Controls.Add(this.circleLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeImgBox);
            this.Name = "ShapeResult";
            this.Text = "ShapeResult";
            ((System.ComponentModel.ISupportInitialize)(this.shapeImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editedPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shapeImgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label circleLbl;
        private System.Windows.Forms.Label triangleLbl;
        private System.Windows.Forms.Label squareLbl;
        private System.Windows.Forms.Label rectangleLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label polyUnknwLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox editedPicBox;
        private System.Windows.Forms.Label trapizoidLbl;
        private System.Windows.Forms.Label label7;
    }
}