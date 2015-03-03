namespace EDM_Builder.MyControls.Product
{
    partial class Product_A
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Trick = new System.Windows.Forms.TextBox();
            this.label_Currency_small = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Currency = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.textBox_Img = new System.Windows.Forms.TextBox();
            this.checkBox_LocalImg = new System.Windows.Forms.CheckBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_Reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ViewMore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 85;
            this.label6.Text = "更多:";
            // 
            // textBox_Trick
            // 
            this.textBox_Trick.BackColor = System.Drawing.Color.Red;
            this.textBox_Trick.Location = new System.Drawing.Point(357, 167);
            this.textBox_Trick.Name = "textBox_Trick";
            this.textBox_Trick.Size = new System.Drawing.Size(59, 21);
            this.textBox_Trick.TabIndex = 83;
            this.textBox_Trick.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency_small
            // 
            this.label_Currency_small.AutoSize = true;
            this.label_Currency_small.Location = new System.Drawing.Point(345, 172);
            this.label_Currency_small.Name = "label_Currency_small";
            this.label_Currency_small.Size = new System.Drawing.Size(11, 12);
            this.label_Currency_small.TabIndex = 82;
            this.label_Currency_small.Text = "$";
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.Red;
            this.textBox_Price.Location = new System.Drawing.Point(281, 167);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(56, 21);
            this.textBox_Price.TabIndex = 81;
            this.textBox_Price.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency
            // 
            this.label_Currency.AutoSize = true;
            this.label_Currency.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Currency.ForeColor = System.Drawing.Color.Red;
            this.label_Currency.Location = new System.Drawing.Point(262, 168);
            this.label_Currency.Name = "label_Currency";
            this.label_Currency.Size = new System.Drawing.Size(19, 19);
            this.label_Currency.TabIndex = 80;
            this.label_Currency.Text = "$";
            // 
            // textBox_URL
            // 
            this.textBox_URL.BackColor = System.Drawing.Color.Red;
            this.textBox_URL.Location = new System.Drawing.Point(55, 224);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_URL.Size = new System.Drawing.Size(361, 46);
            this.textBox_URL.TabIndex = 79;
            this.textBox_URL.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear.Image = global::EDM_Builder.Properties.Resources.waiting_clear;
            this.pictureBox_Clear.Location = new System.Drawing.Point(407, 3);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Clear.TabIndex = 92;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Img.Image = global::EDM_Builder.Properties.Resources.empty_pic_bg;
            this.pictureBox_Img.Location = new System.Drawing.Point(16, 38);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(400, 117);
            this.pictureBox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Img.TabIndex = 77;
            this.pictureBox_Img.TabStop = false;
            this.pictureBox_Img.Click += new System.EventHandler(this.pictureBox_Img_Click);
            // 
            // textBox_Img
            // 
            this.textBox_Img.BackColor = System.Drawing.Color.Red;
            this.textBox_Img.Location = new System.Drawing.Point(16, 38);
            this.textBox_Img.Multiline = true;
            this.textBox_Img.Name = "textBox_Img";
            this.textBox_Img.Size = new System.Drawing.Size(400, 117);
            this.textBox_Img.TabIndex = 100;
            this.textBox_Img.Visible = false;
            this.textBox_Img.TextChanged += new System.EventHandler(this.textBox_Img_TextChanged);
            // 
            // checkBox_LocalImg
            // 
            this.checkBox_LocalImg.AutoSize = true;
            this.checkBox_LocalImg.Checked = true;
            this.checkBox_LocalImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LocalImg.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_LocalImg.Location = new System.Drawing.Point(16, 16);
            this.checkBox_LocalImg.Name = "checkBox_LocalImg";
            this.checkBox_LocalImg.Size = new System.Drawing.Size(72, 16);
            this.checkBox_LocalImg.TabIndex = 99;
            this.checkBox_LocalImg.Text = "本地图片";
            this.checkBox_LocalImg.UseVisualStyleBackColor = true;
            this.checkBox_LocalImg.CheckedChanged += new System.EventHandler(this.checkBox_LocalImg_CheckedChanged);
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.BackColor = System.Drawing.Color.Red;
            this.textBox_ProductName.Location = new System.Drawing.Point(16, 168);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(231, 21);
            this.textBox_ProductName.TabIndex = 78;
            this.textBox_ProductName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox_Reference
            // 
            this.textBox_Reference.BackColor = System.Drawing.Color.Red;
            this.textBox_Reference.Location = new System.Drawing.Point(55, 194);
            this.textBox_Reference.Name = "textBox_Reference";
            this.textBox_Reference.Size = new System.Drawing.Size(359, 21);
            this.textBox_Reference.TabIndex = 101;
            this.textBox_Reference.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 102;
            this.label1.Text = "参考:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 103;
            this.label2.Text = "URL:";
            // 
            // textBox_ViewMore
            // 
            this.textBox_ViewMore.BackColor = System.Drawing.Color.Red;
            this.textBox_ViewMore.Location = new System.Drawing.Point(55, 276);
            this.textBox_ViewMore.Multiline = true;
            this.textBox_ViewMore.Name = "textBox_ViewMore";
            this.textBox_ViewMore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ViewMore.Size = new System.Drawing.Size(361, 71);
            this.textBox_ViewMore.TabIndex = 104;
            this.textBox_ViewMore.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Product_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_ViewMore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Reference);
            this.Controls.Add(this.textBox_Img);
            this.Controls.Add(this.checkBox_LocalImg);
            this.Controls.Add(this.pictureBox_Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Trick);
            this.Controls.Add(this.label_Currency_small);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label_Currency);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.pictureBox_Img);
            this.Name = "Product_A";
            this.Size = new System.Drawing.Size(434, 367);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Trick;
        private System.Windows.Forms.Label label_Currency_small;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Currency;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.PictureBox pictureBox_Img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.TextBox textBox_Img;
        private System.Windows.Forms.CheckBox checkBox_LocalImg;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_Reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ViewMore;
    }
}
