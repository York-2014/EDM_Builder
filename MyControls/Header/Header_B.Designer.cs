﻿namespace EDM_Builder.MyControls.Header
{
    partial class Header_B
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_SortId_1 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_SortId_1
            // 
            this.label_SortId_1.AutoSize = true;
            this.label_SortId_1.Location = new System.Drawing.Point(15, 21);
            this.label_SortId_1.Name = "label_SortId_1";
            this.label_SortId_1.Size = new System.Drawing.Size(35, 12);
            this.label_SortId_1.TabIndex = 91;
            this.label_SortId_1.Text = "标题:";
            // 
            // textBox_Title
            // 
            this.textBox_Title.BackColor = System.Drawing.Color.Red;
            this.textBox_Title.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Title.Location = new System.Drawing.Point(56, 17);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(309, 21);
            this.textBox_Title.TabIndex = 90;
            this.textBox_Title.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox_URL
            // 
            this.textBox_URL.BackColor = System.Drawing.Color.Red;
            this.textBox_URL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_URL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_URL.Location = new System.Drawing.Point(56, 44);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(359, 32);
            this.textBox_URL.TabIndex = 95;
            this.textBox_URL.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 94;
            this.label1.Text = "URL:";
            // 
            // Header_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SortId_1);
            this.Controls.Add(this.textBox_Title);
            this.Name = "Header_B";
            this.Size = new System.Drawing.Size(428, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SortId_1;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Label label1;
    }
}
