namespace EDM_Builder.MyControls.Dialog
{
    partial class Dialog_InputImage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton_Local = new System.Windows.Forms.RadioButton();
            this.textBox_Local = new System.Windows.Forms.TextBox();
            this.radioButton_Url = new System.Windows.Forms.RadioButton();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButton_Local
            // 
            this.radioButton_Local.AutoSize = true;
            this.radioButton_Local.Checked = true;
            this.radioButton_Local.Location = new System.Drawing.Point(25, 35);
            this.radioButton_Local.Name = "radioButton_Local";
            this.radioButton_Local.Size = new System.Drawing.Size(83, 16);
            this.radioButton_Local.TabIndex = 0;
            this.radioButton_Local.TabStop = true;
            this.radioButton_Local.Text = "本地图片：";
            this.radioButton_Local.UseVisualStyleBackColor = true;
            // 
            // textBox_Local
            // 
            this.textBox_Local.Location = new System.Drawing.Point(25, 58);
            this.textBox_Local.Name = "textBox_Local";
            this.textBox_Local.Size = new System.Drawing.Size(475, 21);
            this.textBox_Local.TabIndex = 0;
            // 
            // radioButton_Url
            // 
            this.radioButton_Url.AutoSize = true;
            this.radioButton_Url.Location = new System.Drawing.Point(25, 85);
            this.radioButton_Url.Name = "radioButton_Url";
            this.radioButton_Url.Size = new System.Drawing.Size(83, 16);
            this.radioButton_Url.TabIndex = 2;
            this.radioButton_Url.Text = "网络图片：";
            this.radioButton_Url.UseVisualStyleBackColor = true;
            // 
            // textBox_Url
            // 
            this.textBox_Url.Location = new System.Drawing.Point(24, 107);
            this.textBox_Url.Multiline = true;
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(521, 59);
            this.textBox_Url.TabIndex = 3;
            this.textBox_Url.TextChanged += new System.EventHandler(this.textBox_Url_TextChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(206, 181);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "确 定(&O)";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(287, 181);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取 消(&C)";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(506, 58);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(39, 23);
            this.button_OpenFile.TabIndex = 1;
            this.button_OpenFile.Text = "...";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "设置图片";
            // 
            // Dialog_InputImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Url);
            this.Controls.Add(this.radioButton_Url);
            this.Controls.Add(this.textBox_Local);
            this.Controls.Add(this.radioButton_Local);
            this.Name = "Dialog_InputImage";
            this.Size = new System.Drawing.Size(569, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButton_Local;
        private System.Windows.Forms.TextBox textBox_Local;
        private System.Windows.Forms.RadioButton radioButton_Url;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Label label1;
    }
}
