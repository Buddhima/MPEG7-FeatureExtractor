namespace WindowsFormsApplication1
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
            this.inputFileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dcdBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.cldBtn = new System.Windows.Forms.Button();
            this.cspdBtn = new System.Windows.Forms.Button();
            this.shapeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFileTxt
            // 
            this.inputFileTxt.Location = new System.Drawing.Point(37, 24);
            this.inputFileTxt.Name = "inputFileTxt";
            this.inputFileTxt.Size = new System.Drawing.Size(408, 20);
            this.inputFileTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dcdBtn
            // 
            this.dcdBtn.Location = new System.Drawing.Point(37, 90);
            this.dcdBtn.Name = "dcdBtn";
            this.dcdBtn.Size = new System.Drawing.Size(75, 23);
            this.dcdBtn.TabIndex = 10;
            this.dcdBtn.Text = "DCD";
            this.dcdBtn.UseVisualStyleBackColor = true;
            this.dcdBtn.Click += new System.EventHandler(this.dcdBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(451, 22);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 11;
            this.loadBtn.Text = "Load Image";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // cldBtn
            // 
            this.cldBtn.Location = new System.Drawing.Point(132, 90);
            this.cldBtn.Name = "cldBtn";
            this.cldBtn.Size = new System.Drawing.Size(75, 23);
            this.cldBtn.TabIndex = 12;
            this.cldBtn.Text = "CLD";
            this.cldBtn.UseVisualStyleBackColor = true;
            this.cldBtn.Click += new System.EventHandler(this.cldBtn_Click);
            // 
            // cspdBtn
            // 
            this.cspdBtn.Location = new System.Drawing.Point(229, 91);
            this.cspdBtn.Name = "cspdBtn";
            this.cspdBtn.Size = new System.Drawing.Size(75, 23);
            this.cspdBtn.TabIndex = 13;
            this.cspdBtn.Text = "CSPD";
            this.cspdBtn.UseVisualStyleBackColor = true;
            this.cspdBtn.Click += new System.EventHandler(this.cspdBtn_Click);
            // 
            // shapeBtn
            // 
            this.shapeBtn.Location = new System.Drawing.Point(329, 90);
            this.shapeBtn.Name = "shapeBtn";
            this.shapeBtn.Size = new System.Drawing.Size(75, 23);
            this.shapeBtn.TabIndex = 14;
            this.shapeBtn.Text = "Shapes";
            this.shapeBtn.UseVisualStyleBackColor = true;
            this.shapeBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 335);
            this.Controls.Add(this.shapeBtn);
            this.Controls.Add(this.cspdBtn);
            this.Controls.Add(this.cldBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dcdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFileTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dcdBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button cldBtn;
        private System.Windows.Forms.Button cspdBtn;
        private System.Windows.Forms.Button shapeBtn;
    }
}

