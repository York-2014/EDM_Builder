namespace EDM_Builder.MyControls.Product
{
    partial class Product_C
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
            this.pictureBox_Left = new System.Windows.Forms.PictureBox();
            this.textBox_ProductName_Left = new System.Windows.Forms.TextBox();
            this.textBox_Price_Left = new System.Windows.Forms.TextBox();
            this.label_Currency_Left = new System.Windows.Forms.Label();
            this.textBox_ViewMoreLnk_Left = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ViewMoreLnk_Right = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Price_Right = new System.Windows.Forms.TextBox();
            this.label_Currency_Right = new System.Windows.Forms.Label();
            this.textBox_ProductName_Right = new System.Windows.Forms.TextBox();
            this.pictureBox_Right = new System.Windows.Forms.PictureBox();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Img_Left = new System.Windows.Forms.TextBox();
            this.checkBox_LocalImg_Left = new System.Windows.Forms.CheckBox();
            this.textBox_Img_Right = new System.Windows.Forms.TextBox();
            this.checkBox_LocalImg_Right = new System.Windows.Forms.CheckBox();
            this.textBox_URL_Left = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Trick_Left = new System.Windows.Forms.TextBox();
            this.label_Currency_Small_Left = new System.Windows.Forms.Label();
            this.textBox_Trick_Right = new System.Windows.Forms.TextBox();
            this.label_Currency_Small_Right = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_URL_Right = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Left
            // 
            this.pictureBox_Left.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Left.Image = global::EDM_Builder.Properties.Resources.empty_pic_bg;
            this.pictureBox_Left.Location = new System.Drawing.Point(19, 33);
            this.pictureBox_Left.Name = "pictureBox_Left";
            this.pictureBox_Left.Size = new System.Drawing.Size(187, 135);
            this.pictureBox_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Left.TabIndex = 78;
            this.pictureBox_Left.TabStop = false;
            this.pictureBox_Left.Click += new System.EventHandler(this.pictureBox_Left_Click);
            // 
            // textBox_ProductName_Left
            // 
            this.textBox_ProductName_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_ProductName_Left.Location = new System.Drawing.Point(19, 174);
            this.textBox_ProductName_Left.Name = "textBox_ProductName_Left";
            this.textBox_ProductName_Left.Size = new System.Drawing.Size(187, 21);
            this.textBox_ProductName_Left.TabIndex = 80;
            this.textBox_ProductName_Left.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBox_Price_Left
            // 
            this.textBox_Price_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_Price_Left.Location = new System.Drawing.Point(139, 202);
            this.textBox_Price_Left.Name = "textBox_Price_Left";
            this.textBox_Price_Left.Size = new System.Drawing.Size(56, 21);
            this.textBox_Price_Left.TabIndex = 83;
            this.textBox_Price_Left.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency_Left
            // 
            this.label_Currency_Left.AutoSize = true;
            this.label_Currency_Left.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Currency_Left.ForeColor = System.Drawing.Color.Red;
            this.label_Currency_Left.Location = new System.Drawing.Point(114, 203);
            this.label_Currency_Left.Name = "label_Currency_Left";
            this.label_Currency_Left.Size = new System.Drawing.Size(19, 19);
            this.label_Currency_Left.TabIndex = 82;
            this.label_Currency_Left.Text = "$";
            // 
            // textBox_ViewMoreLnk_Left
            // 
            this.textBox_ViewMoreLnk_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_ViewMoreLnk_Left.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ViewMoreLnk_Left.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_ViewMoreLnk_Left.Location = new System.Drawing.Point(22, 329);
            this.textBox_ViewMoreLnk_Left.Multiline = true;
            this.textBox_ViewMoreLnk_Left.Name = "textBox_ViewMoreLnk_Left";
            this.textBox_ViewMoreLnk_Left.Size = new System.Drawing.Size(187, 93);
            this.textBox_ViewMoreLnk_Left.TabIndex = 97;
            this.textBox_ViewMoreLnk_Left.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 96;
            this.label2.Text = "更多:";
            // 
            // textBox_ViewMoreLnk_Right
            // 
            this.textBox_ViewMoreLnk_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_ViewMoreLnk_Right.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ViewMoreLnk_Right.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_ViewMoreLnk_Right.Location = new System.Drawing.Point(223, 329);
            this.textBox_ViewMoreLnk_Right.Multiline = true;
            this.textBox_ViewMoreLnk_Right.Name = "textBox_ViewMoreLnk_Right";
            this.textBox_ViewMoreLnk_Right.Size = new System.Drawing.Size(187, 93);
            this.textBox_ViewMoreLnk_Right.TabIndex = 104;
            this.textBox_ViewMoreLnk_Right.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 103;
            this.label1.Text = "更多:";
            // 
            // textBox_Price_Right
            // 
            this.textBox_Price_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_Price_Right.Location = new System.Drawing.Point(345, 201);
            this.textBox_Price_Right.Name = "textBox_Price_Right";
            this.textBox_Price_Right.Size = new System.Drawing.Size(56, 21);
            this.textBox_Price_Right.TabIndex = 101;
            this.textBox_Price_Right.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency_Right
            // 
            this.label_Currency_Right.AutoSize = true;
            this.label_Currency_Right.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Currency_Right.ForeColor = System.Drawing.Color.Red;
            this.label_Currency_Right.Location = new System.Drawing.Point(320, 202);
            this.label_Currency_Right.Name = "label_Currency_Right";
            this.label_Currency_Right.Size = new System.Drawing.Size(19, 19);
            this.label_Currency_Right.TabIndex = 100;
            this.label_Currency_Right.Text = "$";
            // 
            // textBox_ProductName_Right
            // 
            this.textBox_ProductName_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_ProductName_Right.Location = new System.Drawing.Point(223, 174);
            this.textBox_ProductName_Right.Name = "textBox_ProductName_Right";
            this.textBox_ProductName_Right.Size = new System.Drawing.Size(187, 21);
            this.textBox_ProductName_Right.TabIndex = 99;
            this.textBox_ProductName_Right.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // pictureBox_Right
            // 
            this.pictureBox_Right.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Right.Image = global::EDM_Builder.Properties.Resources.empty_pic_bg;
            this.pictureBox_Right.Location = new System.Drawing.Point(223, 33);
            this.pictureBox_Right.Name = "pictureBox_Right";
            this.pictureBox_Right.Size = new System.Drawing.Size(187, 135);
            this.pictureBox_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Right.TabIndex = 98;
            this.pictureBox_Right.TabStop = false;
            this.pictureBox_Right.Click += new System.EventHandler(this.pictureBox_Right_Click);
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear.Image = global::EDM_Builder.Properties.Resources.waiting_clear;
            this.pictureBox_Clear.Location = new System.Drawing.Point(407, 3);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Clear.TabIndex = 105;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_Img_Left
            // 
            this.textBox_Img_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_Img_Left.Location = new System.Drawing.Point(19, 33);
            this.textBox_Img_Left.Multiline = true;
            this.textBox_Img_Left.Name = "textBox_Img_Left";
            this.textBox_Img_Left.Size = new System.Drawing.Size(187, 135);
            this.textBox_Img_Left.TabIndex = 107;
            this.textBox_Img_Left.Visible = false;
            this.textBox_Img_Left.TextChanged += new System.EventHandler(this.textBox_Img_Left_TextChanged);
            // 
            // checkBox_LocalImg_Left
            // 
            this.checkBox_LocalImg_Left.AutoSize = true;
            this.checkBox_LocalImg_Left.Checked = true;
            this.checkBox_LocalImg_Left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LocalImg_Left.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_LocalImg_Left.Location = new System.Drawing.Point(19, 11);
            this.checkBox_LocalImg_Left.Name = "checkBox_LocalImg_Left";
            this.checkBox_LocalImg_Left.Size = new System.Drawing.Size(72, 16);
            this.checkBox_LocalImg_Left.TabIndex = 106;
            this.checkBox_LocalImg_Left.Text = "本地图片";
            this.checkBox_LocalImg_Left.UseVisualStyleBackColor = true;
            this.checkBox_LocalImg_Left.CheckedChanged += new System.EventHandler(this.checkBox_LocalImg_Left_CheckedChanged);
            // 
            // textBox_Img_Right
            // 
            this.textBox_Img_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_Img_Right.Location = new System.Drawing.Point(223, 33);
            this.textBox_Img_Right.Multiline = true;
            this.textBox_Img_Right.Name = "textBox_Img_Right";
            this.textBox_Img_Right.Size = new System.Drawing.Size(187, 135);
            this.textBox_Img_Right.TabIndex = 109;
            this.textBox_Img_Right.Visible = false;
            this.textBox_Img_Right.TextChanged += new System.EventHandler(this.textBox_Img_Right_TextChanged);
            // 
            // checkBox_LocalImg_Right
            // 
            this.checkBox_LocalImg_Right.AutoSize = true;
            this.checkBox_LocalImg_Right.Checked = true;
            this.checkBox_LocalImg_Right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LocalImg_Right.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_LocalImg_Right.Location = new System.Drawing.Point(223, 11);
            this.checkBox_LocalImg_Right.Name = "checkBox_LocalImg_Right";
            this.checkBox_LocalImg_Right.Size = new System.Drawing.Size(72, 16);
            this.checkBox_LocalImg_Right.TabIndex = 108;
            this.checkBox_LocalImg_Right.Text = "本地图片";
            this.checkBox_LocalImg_Right.UseVisualStyleBackColor = true;
            this.checkBox_LocalImg_Right.CheckedChanged += new System.EventHandler(this.checkBox_LocalImg_Right_CheckedChanged);
            // 
            // textBox_URL_Left
            // 
            this.textBox_URL_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_URL_Left.Location = new System.Drawing.Point(22, 252);
            this.textBox_URL_Left.Multiline = true;
            this.textBox_URL_Left.Name = "textBox_URL_Left";
            this.textBox_URL_Left.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_URL_Left.Size = new System.Drawing.Size(187, 52);
            this.textBox_URL_Left.TabIndex = 110;
            this.textBox_URL_Left.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 111;
            this.label3.Text = "URL:";
            // 
            // textBox_Trick_Left
            // 
            this.textBox_Trick_Left.BackColor = System.Drawing.Color.Red;
            this.textBox_Trick_Left.Location = new System.Drawing.Point(40, 202);
            this.textBox_Trick_Left.Name = "textBox_Trick_Left";
            this.textBox_Trick_Left.Size = new System.Drawing.Size(59, 21);
            this.textBox_Trick_Left.TabIndex = 113;
            this.textBox_Trick_Left.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency_Small_Left
            // 
            this.label_Currency_Small_Left.AutoSize = true;
            this.label_Currency_Small_Left.Location = new System.Drawing.Point(24, 207);
            this.label_Currency_Small_Left.Name = "label_Currency_Small_Left";
            this.label_Currency_Small_Left.Size = new System.Drawing.Size(11, 12);
            this.label_Currency_Small_Left.TabIndex = 112;
            this.label_Currency_Small_Left.Text = "$";
            // 
            // textBox_Trick_Right
            // 
            this.textBox_Trick_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_Trick_Right.Location = new System.Drawing.Point(243, 201);
            this.textBox_Trick_Right.Name = "textBox_Trick_Right";
            this.textBox_Trick_Right.Size = new System.Drawing.Size(59, 21);
            this.textBox_Trick_Right.TabIndex = 115;
            this.textBox_Trick_Right.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label_Currency_Small_Right
            // 
            this.label_Currency_Small_Right.AutoSize = true;
            this.label_Currency_Small_Right.Location = new System.Drawing.Point(227, 206);
            this.label_Currency_Small_Right.Name = "label_Currency_Small_Right";
            this.label_Currency_Small_Right.Size = new System.Drawing.Size(11, 12);
            this.label_Currency_Small_Right.TabIndex = 114;
            this.label_Currency_Small_Right.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "URL:";
            // 
            // textBox_URL_Right
            // 
            this.textBox_URL_Right.BackColor = System.Drawing.Color.Red;
            this.textBox_URL_Right.Location = new System.Drawing.Point(223, 252);
            this.textBox_URL_Right.Multiline = true;
            this.textBox_URL_Right.Name = "textBox_URL_Right";
            this.textBox_URL_Right.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_URL_Right.Size = new System.Drawing.Size(187, 52);
            this.textBox_URL_Right.TabIndex = 116;
            this.textBox_URL_Right.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Product_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_URL_Right);
            this.Controls.Add(this.textBox_Trick_Right);
            this.Controls.Add(this.label_Currency_Small_Right);
            this.Controls.Add(this.textBox_Trick_Left);
            this.Controls.Add(this.label_Currency_Small_Left);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_URL_Left);
            this.Controls.Add(this.textBox_Img_Right);
            this.Controls.Add(this.checkBox_LocalImg_Right);
            this.Controls.Add(this.textBox_Img_Left);
            this.Controls.Add(this.checkBox_LocalImg_Left);
            this.Controls.Add(this.pictureBox_Clear);
            this.Controls.Add(this.textBox_ViewMoreLnk_Right);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price_Right);
            this.Controls.Add(this.label_Currency_Right);
            this.Controls.Add(this.textBox_ProductName_Right);
            this.Controls.Add(this.pictureBox_Right);
            this.Controls.Add(this.textBox_ViewMoreLnk_Left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Price_Left);
            this.Controls.Add(this.label_Currency_Left);
            this.Controls.Add(this.textBox_ProductName_Left);
            this.Controls.Add(this.pictureBox_Left);
            this.Name = "Product_C";
            this.Size = new System.Drawing.Size(434, 454);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Left;
        private System.Windows.Forms.TextBox textBox_ProductName_Left;
        private System.Windows.Forms.TextBox textBox_Price_Left;
        private System.Windows.Forms.Label label_Currency_Left;
        private System.Windows.Forms.TextBox textBox_ViewMoreLnk_Left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ViewMoreLnk_Right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Price_Right;
        private System.Windows.Forms.Label label_Currency_Right;
        private System.Windows.Forms.TextBox textBox_ProductName_Right;
        private System.Windows.Forms.PictureBox pictureBox_Right;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_Img_Left;
        private System.Windows.Forms.CheckBox checkBox_LocalImg_Left;
        private System.Windows.Forms.TextBox textBox_Img_Right;
        private System.Windows.Forms.CheckBox checkBox_LocalImg_Right;
        private System.Windows.Forms.TextBox textBox_URL_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Trick_Left;
        private System.Windows.Forms.Label label_Currency_Small_Left;
        private System.Windows.Forms.TextBox textBox_Trick_Right;
        private System.Windows.Forms.Label label_Currency_Small_Right;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_URL_Right;
    }
}
