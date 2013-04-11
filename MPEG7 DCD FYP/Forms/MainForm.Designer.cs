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
            this.inDirSelectBtn = new System.Windows.Forms.Button();
            this.cldBtn = new System.Windows.Forms.Button();
            this.Reduce16PositionsCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outDirSelectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outDirTxt = new System.Windows.Forms.TextBox();
            this.hsl_15_rb = new System.Windows.Forms.RadioButton();
            this.rgb_27_rb = new System.Windows.Forms.RadioButton();
            this.ColourSpace_group = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_y_rb = new System.Windows.Forms.RadioButton();
            this.rgb_64_rb = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.hsl_48_rb = new System.Windows.Forms.RadioButton();
            this.hsl_27_rb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_x_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ColourSpace_group.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Folder :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dcdBtn
            // 
            this.dcdBtn.Location = new System.Drawing.Point(392, 59);
            this.dcdBtn.Name = "dcdBtn";
            this.dcdBtn.Size = new System.Drawing.Size(89, 23);
            this.dcdBtn.TabIndex = 10;
            this.dcdBtn.Text = "Calculate DCD";
            this.dcdBtn.UseVisualStyleBackColor = true;
            this.dcdBtn.Click += new System.EventHandler(this.dcdBtn_Click);
            // 
            // inDirSelectBtn
            // 
            this.inDirSelectBtn.Location = new System.Drawing.Point(451, 22);
            this.inDirSelectBtn.Name = "inDirSelectBtn";
            this.inDirSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.inDirSelectBtn.TabIndex = 11;
            this.inDirSelectBtn.Text = "Browse";
            this.inDirSelectBtn.UseVisualStyleBackColor = true;
            this.inDirSelectBtn.Click += new System.EventHandler(this.inDirSelectBtn_Click);
            // 
            // cldBtn
            // 
            this.cldBtn.Location = new System.Drawing.Point(392, 55);
            this.cldBtn.Name = "cldBtn";
            this.cldBtn.Size = new System.Drawing.Size(89, 23);
            this.cldBtn.TabIndex = 12;
            this.cldBtn.Text = "Calculate CLD";
            this.cldBtn.UseVisualStyleBackColor = true;
            this.cldBtn.Click += new System.EventHandler(this.cldBtn_Click);
            // 
            // Reduce16PositionsCheck
            // 
            this.Reduce16PositionsCheck.AutoSize = true;
            this.Reduce16PositionsCheck.Checked = true;
            this.Reduce16PositionsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Reduce16PositionsCheck.Location = new System.Drawing.Point(10, 60);
            this.Reduce16PositionsCheck.Name = "Reduce16PositionsCheck";
            this.Reduce16PositionsCheck.Size = new System.Drawing.Size(123, 17);
            this.Reduce16PositionsCheck.TabIndex = 15;
            this.Reduce16PositionsCheck.Text = "Reduce to 16 Colors";
            this.Reduce16PositionsCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dcdBtn);
            this.groupBox1.Location = new System.Drawing.Point(37, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 87);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dominant Color Descriptor";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dominant Color Descriptor (DCD) returns the 8 most dominant colors in the image w" +
                "ith their respective precentages.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Color Layout Descriptor (CLD) divides the image in to either 64 or 16 cells and r" +
                "eturns the Average Color of each cell.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reduce16PositionsCheck);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cldBtn);
            this.groupBox2.Location = new System.Drawing.Point(37, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 83);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Layout Descriptor";
            // 
            // outDirSelectBtn
            // 
            this.outDirSelectBtn.Location = new System.Drawing.Point(451, 65);
            this.outDirSelectBtn.Name = "outDirSelectBtn";
            this.outDirSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.outDirSelectBtn.TabIndex = 20;
            this.outDirSelectBtn.Text = "Browse";
            this.outDirSelectBtn.UseVisualStyleBackColor = true;
            this.outDirSelectBtn.Click += new System.EventHandler(this.outDirSelectBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Output Folder :";
            // 
            // outDirTxt
            // 
            this.outDirTxt.Location = new System.Drawing.Point(37, 67);
            this.outDirTxt.Name = "outDirTxt";
            this.outDirTxt.Size = new System.Drawing.Size(408, 20);
            this.outDirTxt.TabIndex = 18;
            // 
            // hsl_15_rb
            // 
            this.hsl_15_rb.AutoSize = true;
            this.hsl_15_rb.Location = new System.Drawing.Point(51, 40);
            this.hsl_15_rb.Name = "hsl_15_rb";
            this.hsl_15_rb.Size = new System.Drawing.Size(60, 17);
            this.hsl_15_rb.TabIndex = 12;
            this.hsl_15_rb.Text = "15 Bins";
            this.hsl_15_rb.UseVisualStyleBackColor = true;
            // 
            // rgb_27_rb
            // 
            this.rgb_27_rb.AutoSize = true;
            this.rgb_27_rb.Location = new System.Drawing.Point(175, 40);
            this.rgb_27_rb.Name = "rgb_27_rb";
            this.rgb_27_rb.Size = new System.Drawing.Size(60, 17);
            this.rgb_27_rb.TabIndex = 13;
            this.rgb_27_rb.Text = "27 Bins";
            this.rgb_27_rb.UseVisualStyleBackColor = true;
            // 
            // ColourSpace_group
            // 
            this.ColourSpace_group.Controls.Add(this.label7);
            this.ColourSpace_group.Controls.Add(this.lab_y_rb);
            this.ColourSpace_group.Controls.Add(this.rgb_64_rb);
            this.ColourSpace_group.Controls.Add(this.label6);
            this.ColourSpace_group.Controls.Add(this.hsl_48_rb);
            this.ColourSpace_group.Controls.Add(this.hsl_27_rb);
            this.ColourSpace_group.Controls.Add(this.label5);
            this.ColourSpace_group.Controls.Add(this.lab_x_rb);
            this.ColourSpace_group.Controls.Add(this.rgb_27_rb);
            this.ColourSpace_group.Controls.Add(this.hsl_15_rb);
            this.ColourSpace_group.Location = new System.Drawing.Point(37, 108);
            this.ColourSpace_group.Name = "ColourSpace_group";
            this.ColourSpace_group.Size = new System.Drawing.Size(487, 104);
            this.ColourSpace_group.TabIndex = 14;
            this.ColourSpace_group.TabStop = false;
            this.ColourSpace_group.Text = "Colour Quantization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lab";
            // 
            // lab_y_rb
            // 
            this.lab_y_rb.AutoSize = true;
            this.lab_y_rb.Location = new System.Drawing.Point(307, 61);
            this.lab_y_rb.Name = "lab_y_rb";
            this.lab_y_rb.Size = new System.Drawing.Size(55, 17);
            this.lab_y_rb.TabIndex = 20;
            this.lab_y_rb.Text = "Y Bins";
            this.lab_y_rb.UseVisualStyleBackColor = true;
            // 
            // rgb_64_rb
            // 
            this.rgb_64_rb.AutoSize = true;
            this.rgb_64_rb.Location = new System.Drawing.Point(175, 61);
            this.rgb_64_rb.Name = "rgb_64_rb";
            this.rgb_64_rb.Size = new System.Drawing.Size(60, 17);
            this.rgb_64_rb.TabIndex = 19;
            this.rgb_64_rb.Text = "64 Bins";
            this.rgb_64_rb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "RGB";
            // 
            // hsl_48_rb
            // 
            this.hsl_48_rb.AutoSize = true;
            this.hsl_48_rb.Location = new System.Drawing.Point(51, 81);
            this.hsl_48_rb.Name = "hsl_48_rb";
            this.hsl_48_rb.Size = new System.Drawing.Size(60, 17);
            this.hsl_48_rb.TabIndex = 17;
            this.hsl_48_rb.Text = "48 Bins";
            this.hsl_48_rb.UseVisualStyleBackColor = true;
            // 
            // hsl_27_rb
            // 
            this.hsl_27_rb.AutoSize = true;
            this.hsl_27_rb.Checked = true;
            this.hsl_27_rb.Location = new System.Drawing.Point(51, 61);
            this.hsl_27_rb.Name = "hsl_27_rb";
            this.hsl_27_rb.Size = new System.Drawing.Size(60, 17);
            this.hsl_27_rb.TabIndex = 16;
            this.hsl_27_rb.TabStop = true;
            this.hsl_27_rb.Text = "27 Bins";
            this.hsl_27_rb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "HSL";
            // 
            // lab_x_rb
            // 
            this.lab_x_rb.AutoSize = true;
            this.lab_x_rb.Location = new System.Drawing.Point(307, 40);
            this.lab_x_rb.Name = "lab_x_rb";
            this.lab_x_rb.Size = new System.Drawing.Size(55, 17);
            this.lab_x_rb.TabIndex = 14;
            this.lab_x_rb.Text = "X Bins";
            this.lab_x_rb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 426);
            this.Controls.Add(this.ColourSpace_group);
            this.Controls.Add(this.outDirSelectBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outDirTxt);
            this.Controls.Add(this.inDirSelectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFileTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Color Feature Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ColourSpace_group.ResumeLayout(false);
            this.ColourSpace_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dcdBtn;
        private System.Windows.Forms.Button inDirSelectBtn;
        private System.Windows.Forms.Button cldBtn;
        private System.Windows.Forms.CheckBox Reduce16PositionsCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button outDirSelectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outDirTxt;
        private System.Windows.Forms.RadioButton hsl_15_rb;
        private System.Windows.Forms.RadioButton rgb_27_rb;
        private System.Windows.Forms.GroupBox ColourSpace_group;
        private System.Windows.Forms.RadioButton lab_x_rb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton lab_y_rb;
        private System.Windows.Forms.RadioButton rgb_64_rb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton hsl_48_rb;
        private System.Windows.Forms.RadioButton hsl_27_rb;
        private System.Windows.Forms.Label label5;
    }
}

