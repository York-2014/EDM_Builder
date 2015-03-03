namespace EDM_Builder.MyControls.Product
{
    partial class Product_E
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.textBox_Img = new System.Windows.Forms.TextBox();
            this.checkBox_LocalImg = new System.Windows.Forms.CheckBox();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 94;
            this.label1.Text = "URL:";
            // 
            // textBox_URL
            // 
            this.textBox_URL.BackColor = System.Drawing.Color.Red;
            this.textBox_URL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_URL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_URL.Location = new System.Drawing.Point(56, 155);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(359, 58);
            this.textBox_URL.TabIndex = 95;
            this.textBox_URL.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox_Img
            // 
            this.textBox_Img.BackColor = System.Drawing.Color.Red;
            this.textBox_Img.Location = new System.Drawing.Point(15, 32);
            this.textBox_Img.Multiline = true;
            this.textBox_Img.Name = "textBox_Img";
            this.textBox_Img.Size = new System.Drawing.Size(400, 117);
            this.textBox_Img.TabIndex = 102;
            this.textBox_Img.Visible = false;
            this.textBox_Img.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // checkBox_LocalImg
            // 
            this.checkBox_LocalImg.AutoSize = true;
            this.checkBox_LocalImg.Checked = true;
            this.checkBox_LocalImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LocalImg.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_LocalImg.Location = new System.Drawing.Point(15, 10);
            this.checkBox_LocalImg.Name = "checkBox_LocalImg";
            this.checkBox_LocalImg.Size = new System.Drawing.Size(72, 16);
            this.checkBox_LocalImg.TabIndex = 101;
            this.checkBox_LocalImg.Text = "本地图片";
            this.checkBox_LocalImg.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Img.Image = global::EDM_Builder.Properties.Resources.empty_pic_bg;
            this.pictureBox_Img.Location = new System.Drawing.Point(15, 32);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(400, 117);
            this.pictureBox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Img.TabIndex = 103;
            this.pictureBox_Img.TabStop = false;
            this.pictureBox_Img.Click += new System.EventHandler(this.pictureBox_Img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Product_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Img);
            this.Controls.Add(this.checkBox_LocalImg);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Img);
            this.Name = "Product_E";
            this.Size = new System.Drawing.Size(428, 233);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.TextBox textBox_Img;
        private System.Windows.Forms.CheckBox checkBox_LocalImg;
        private System.Windows.Forms.PictureBox pictureBox_Img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}
