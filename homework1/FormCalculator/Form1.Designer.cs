namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CEbtnClick = new System.Windows.Forms.Button();
            this.abtnClick = new System.Windows.Forms.Button();
            this.bbtnClick = new System.Windows.Forms.Button();
            this.cbtnClick = new System.Windows.Forms.Button();
            this.dbtnClick = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "数字1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "数字2：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 3;
            // 
            // CEbtnClick
            // 
            this.CEbtnClick.Location = new System.Drawing.Point(471, 87);
            this.CEbtnClick.Name = "CEbtnClick";
            this.CEbtnClick.Size = new System.Drawing.Size(75, 61);
            this.CEbtnClick.TabIndex = 4;
            this.CEbtnClick.Text = "清除";
            this.CEbtnClick.UseVisualStyleBackColor = true;
            this.CEbtnClick.Click += new System.EventHandler(this.CEbtnClick_Click);
            // 
            // abtnClick
            // 
            this.abtnClick.Location = new System.Drawing.Point(87, 212);
            this.abtnClick.Name = "abtnClick";
            this.abtnClick.Size = new System.Drawing.Size(105, 29);
            this.abtnClick.TabIndex = 5;
            this.abtnClick.Text = "相加运算";
            this.abtnClick.UseVisualStyleBackColor = true;
            this.abtnClick.Click += new System.EventHandler(this.abtnClick_Click);
            // 
            // bbtnClick
            // 
            this.bbtnClick.Location = new System.Drawing.Point(238, 212);
            this.bbtnClick.Name = "bbtnClick";
            this.bbtnClick.Size = new System.Drawing.Size(105, 29);
            this.bbtnClick.TabIndex = 6;
            this.bbtnClick.Text = "相减运算";
            this.bbtnClick.UseVisualStyleBackColor = true;
            this.bbtnClick.Click += new System.EventHandler(this.bbtnClick_Click);
            // 
            // cbtnClick
            // 
            this.cbtnClick.Location = new System.Drawing.Point(386, 212);
            this.cbtnClick.Name = "cbtnClick";
            this.cbtnClick.Size = new System.Drawing.Size(105, 29);
            this.cbtnClick.TabIndex = 7;
            this.cbtnClick.Text = "乘法运算";
            this.cbtnClick.UseVisualStyleBackColor = true;
            this.cbtnClick.Click += new System.EventHandler(this.cbtnClick_Click);
            // 
            // dbtnClick
            // 
            this.dbtnClick.Location = new System.Drawing.Point(533, 212);
            this.dbtnClick.Name = "dbtnClick";
            this.dbtnClick.Size = new System.Drawing.Size(105, 29);
            this.dbtnClick.TabIndex = 8;
            this.dbtnClick.Text = "除法运算";
            this.dbtnClick.UseVisualStyleBackColor = true;
            this.dbtnClick.Click += new System.EventHandler(this.dbtnClick_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "运算结果：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(302, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 28);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbtnClick);
            this.Controls.Add(this.cbtnClick);
            this.Controls.Add(this.bbtnClick);
            this.Controls.Add(this.abtnClick);
            this.Controls.Add(this.CEbtnClick);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CEbtnClick;
        private System.Windows.Forms.Button abtnClick;
        private System.Windows.Forms.Button bbtnClick;
        private System.Windows.Forms.Button cbtnClick;
        private System.Windows.Forms.Button dbtnClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

