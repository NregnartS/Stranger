namespace homework8
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SystemName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchOrder = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.InOrder = new System.Windows.Forms.Button();
            this.OutOrder = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.ModifyOrder = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoodsSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SystemName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 155);
            this.panel1.TabIndex = 0;
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SystemName.Location = new System.Drawing.Point(15, 50);
            this.SystemName.Name = "SystemName";
            this.SystemName.Padding = new System.Windows.Forms.Padding(15);
            this.SystemName.Size = new System.Drawing.Size(216, 58);
            this.SystemName.TabIndex = 0;
            this.SystemName.Text = "订单管理系统";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.77448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.22552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Controls.Add(this.SearchOrder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.InOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OutOrder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CreateOrder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteOrder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModifyOrder, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(268, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 162);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SearchOrder
            // 
            this.SearchOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchOrder.Location = new System.Drawing.Point(633, 11);
            this.SearchOrder.Name = "SearchOrder";
            this.SearchOrder.Size = new System.Drawing.Size(113, 34);
            this.SearchOrder.TabIndex = 8;
            this.SearchOrder.Text = "查询订单";
            this.SearchOrder.UseVisualStyleBackColor = true;
            this.SearchOrder.Click += new System.EventHandler(this.SearchOrder_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Location = new System.Drawing.Point(633, 120);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 34);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "退出系统";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InOrder
            // 
            this.InOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InOrder.Location = new System.Drawing.Point(377, 120);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(113, 34);
            this.InOrder.TabIndex = 4;
            this.InOrder.Text = "导入订单";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // OutOrder
            // 
            this.OutOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutOrder.Location = new System.Drawing.Point(83, 120);
            this.OutOrder.Name = "OutOrder";
            this.OutOrder.Size = new System.Drawing.Size(113, 34);
            this.OutOrder.TabIndex = 3;
            this.OutOrder.Text = "导出订单";
            this.OutOrder.UseVisualStyleBackColor = true;
            this.OutOrder.Click += new System.EventHandler(this.OutOrder_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateOrder.Location = new System.Drawing.Point(83, 67);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(113, 34);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "创建订单";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteOrder.Location = new System.Drawing.Point(377, 67);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(113, 34);
            this.DeleteOrder.TabIndex = 1;
            this.DeleteOrder.Text = "删除订单";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // ModifyOrder
            // 
            this.ModifyOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyOrder.Location = new System.Drawing.Point(633, 67);
            this.ModifyOrder.Name = "ModifyOrder";
            this.ModifyOrder.Size = new System.Drawing.Size(113, 34);
            this.ModifyOrder.TabIndex = 2;
            this.ModifyOrder.Text = "修改订单";
            this.ModifyOrder.UseVisualStyleBackColor = true;
            this.ModifyOrder.Click += new System.EventHandler(this.ModifyOrder_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(360, 15);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(147, 26);
            this.SearchComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(105, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "通过";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 20, 10, 10);
            this.panel2.Size = new System.Drawing.Size(1049, 255);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderItemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.OrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderItemDataGridViewTextBoxColumn
            // 
            this.orderItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderItemDataGridViewTextBoxColumn.DataPropertyName = "OrderItem";
            this.orderItemDataGridViewTextBoxColumn.HeaderText = "OrderItem";
            this.orderItemDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderItemDataGridViewTextBoxColumn.Name = "orderItemDataGridViewTextBoxColumn";
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(homework5.Order);
            // 
            // CustomBindingSource
            // 
            this.CustomBindingSource.DataSource = typeof(homework5.Customer);
            // 
            // GoodsSource
            // 
            this.GoodsSource.DataSource = typeof(homework5.Goods);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button InOrder;
        private System.Windows.Forms.Button OutOrder;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button ModifyOrder;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Button SearchOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.BindingSource CustomBindingSource;
        private System.Windows.Forms.BindingSource GoodsSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

