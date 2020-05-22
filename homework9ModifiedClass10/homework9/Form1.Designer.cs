namespace homework9
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
            this.StartUrl = new System.Windows.Forms.Label();
            this.StartClimb = new System.Windows.Forms.Button();
            this.StartUrlTextBox = new System.Windows.Forms.TextBox();
            this.ClimbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartUrl
            // 
            this.StartUrl.AutoSize = true;
            this.StartUrl.Location = new System.Drawing.Point(56, 40);
            this.StartUrl.Name = "StartUrl";
            this.StartUrl.Size = new System.Drawing.Size(89, 18);
            this.StartUrl.TabIndex = 0;
            this.StartUrl.Text = "初始URL：";
            // 
            // StartClimb
            // 
            this.StartClimb.Location = new System.Drawing.Point(611, 29);
            this.StartClimb.Name = "StartClimb";
            this.StartClimb.Size = new System.Drawing.Size(122, 35);
            this.StartClimb.TabIndex = 1;
            this.StartClimb.Text = "开始爬取";
            this.StartClimb.UseVisualStyleBackColor = true;
            this.StartClimb.Click += new System.EventHandler(this.StartClimb_Click);
            // 
            // StartUrlTextBox
            // 
            this.StartUrlTextBox.Location = new System.Drawing.Point(163, 34);
            this.StartUrlTextBox.Name = "StartUrlTextBox";
            this.StartUrlTextBox.Size = new System.Drawing.Size(415, 28);
            this.StartUrlTextBox.TabIndex = 2;
            // 
            // ClimbResult
            // 
            this.ClimbResult.Location = new System.Drawing.Point(80, 103);
            this.ClimbResult.Multiline = true;
            this.ClimbResult.Name = "ClimbResult";
            this.ClimbResult.Size = new System.Drawing.Size(628, 313);
            this.ClimbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClimbResult);
            this.Controls.Add(this.StartUrlTextBox);
            this.Controls.Add(this.StartClimb);
            this.Controls.Add(this.StartUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartUrl;
        private System.Windows.Forms.Button StartClimb;
        private System.Windows.Forms.TextBox StartUrlTextBox;
        private System.Windows.Forms.TextBox ClimbResult;
    }
}

