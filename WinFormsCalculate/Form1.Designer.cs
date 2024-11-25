namespace WinFormsCalculate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCircleArea = new Button();
            btnTriangleArea = new Button();
            btnHexagonArea = new Button();
            txtRadius = new TextBox();
            txtWidth = new TextBox();
            txtHexagonWidth = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtHeight = new TextBox();
            groupBox3 = new GroupBox();
            lblResult = new Label();
            label6 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 22);
            label1.TabIndex = 0;
            label1.Text = "รัศมี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 1;
            label2.Text = "ความสูง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 114);
            label3.Name = "label3";
            label3.Size = new Size(86, 22);
            label3.TabIndex = 2;
            label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 43);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 3;
            label4.Text = "ความยาวฐาน";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(206, 57);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(171, 29);
            btnCircleArea.TabIndex = 4;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(206, 90);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(171, 29);
            btnTriangleArea.TabIndex = 5;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(206, 64);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(171, 29);
            btnHexagonArea.TabIndex = 6;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(18, 59);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 30);
            txtRadius.TabIndex = 7;
            txtRadius.Text = "0";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(18, 137);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 30);
            txtWidth.TabIndex = 9;
            txtWidth.Text = "0";
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(18, 66);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(125, 30);
            txtHexagonWidth.TabIndex = 10;
            txtHexagonWidth.Text = "0";
            txtHexagonWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Font = new Font("DM Sans", 10.1999989F, FontStyle.Bold);
            groupBox1.Location = new Point(54, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Cornsilk;
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Font = new Font("DM Sans", 10.1999989F, FontStyle.Bold);
            groupBox2.Location = new Point(54, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 184);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(18, 56);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 30);
            txtHeight.TabIndex = 10;
            txtHeight.Text = "0";
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Aquamarine;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Font = new Font("DM Sans", 10.1999989F, FontStyle.Bold);
            groupBox3.Location = new Point(54, 366);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 125);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // lblResult
            // 
            lblResult.AllowDrop = true;
            lblResult.BackColor = Color.FloralWhite;
            lblResult.Font = new Font("DM Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(575, 69);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(269, 157);
            lblResult.TabIndex = 11;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("DM Sans", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(575, 32);
            label6.Name = "label6";
            label6.Size = new Size(165, 26);
            label6.TabIndex = 11;
            label6.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // button4
            // 
            button4.BackColor = Color.Fuchsia;
            button4.Font = new Font("DM Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(673, 450);
            button4.Name = "button4";
            button4.Size = new Size(171, 41);
            button4.TabIndex = 11;
            button4.Text = "ออกจากนรก";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 503);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCircleArea;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private TextBox txtRadius;
        private TextBox txtWidth;
        private TextBox txtHexagonWidth;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResult;
        private Label label6;
        private Button button4;
        private TextBox txtHeight;
    }
}
