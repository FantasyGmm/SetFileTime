namespace SetFileTime
{
    partial class MainForm
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
            this.folderPath = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.ListBox();
            this.hourSet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.minSet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.seTime = new System.Windows.Forms.Button();
            this.logbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSet)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(13, 13);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(176, 21);
            this.folderPath.TabIndex = 0;
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(195, 13);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(79, 23);
            this.selectPath.TabIndex = 1;
            this.selectPath.Text = "选择文件夹";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // fileBox
            // 
            this.fileBox.FormattingEnabled = true;
            this.fileBox.ItemHeight = 12;
            this.fileBox.Location = new System.Drawing.Point(13, 41);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(176, 88);
            this.fileBox.Sorted = true;
            this.fileBox.TabIndex = 2;
            // 
            // hourSet
            // 
            this.hourSet.Location = new System.Drawing.Point(195, 41);
            this.hourSet.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourSet.Name = "hourSet";
            this.hourSet.Size = new System.Drawing.Size(50, 21);
            this.hourSet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "时";
            // 
            // minSet
            // 
            this.minSet.Location = new System.Drawing.Point(196, 69);
            this.minSet.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minSet.Name = "minSet";
            this.minSet.Size = new System.Drawing.Size(49, 21);
            this.minSet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "分";
            // 
            // seTime
            // 
            this.seTime.Enabled = false;
            this.seTime.Location = new System.Drawing.Point(196, 97);
            this.seTime.Name = "seTime";
            this.seTime.Size = new System.Drawing.Size(78, 23);
            this.seTime.TabIndex = 7;
            this.seTime.Text = "修改";
            this.seTime.UseVisualStyleBackColor = true;
            this.seTime.Click += new System.EventHandler(this.SeTime_Click);
            // 
            // logbox
            // 
            this.logbox.AllowDrop = true;
            this.logbox.Location = new System.Drawing.Point(13, 136);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logbox.Size = new System.Drawing.Size(255, 82);
            this.logbox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.seTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourSet);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.folderPath);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "修改文件创建时间";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.ListBox fileBox;
        private System.Windows.Forms.NumericUpDown hourSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seTime;
        private System.Windows.Forms.TextBox logbox;
    }
}

