namespace EDM_Builder.Control
{
    partial class TemplateA
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
            this.button_ClearTemplate = new System.Windows.Forms.Button();
            this.button_ChangeHeader = new System.Windows.Forms.Button();
            this.button_Join = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_TemplateName = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_TemplateA = new System.Windows.Forms.ListBox();
            this.textBox_ViewMoreLnk = new System.Windows.Forms.TextBox();
            this.textBox_BuyNowLnk = new System.Windows.Forms.TextBox();
            this.textBox_Trick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ProductDescription = new System.Windows.Forms.TextBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.button_SaveTemplate = new System.Windows.Forms.Button();
            this.button_ViewTemplate = new System.Windows.Forms.Button();
            this.webBrowser_TemplateA = new System.Windows.Forms.WebBrowser();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ClearTemplate
            // 
            this.button_ClearTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearTemplate.Location = new System.Drawing.Point(998, 455);
            this.button_ClearTemplate.Name = "button_ClearTemplate";
            this.button_ClearTemplate.Size = new System.Drawing.Size(102, 23);
            this.button_ClearTemplate.TabIndex = 62;
            this.button_ClearTemplate.Text = "清空模版";
            this.button_ClearTemplate.UseVisualStyleBackColor = true;
            this.button_ClearTemplate.Click += new System.EventHandler(this.button_ClearTemplate_Click);
            // 
            // button_ChangeHeader
            // 
            this.button_ChangeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangeHeader.Enabled = false;
            this.button_ChangeHeader.Location = new System.Drawing.Point(1025, 6);
            this.button_ChangeHeader.Name = "button_ChangeHeader";
            this.button_ChangeHeader.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeHeader.TabIndex = 61;
            this.button_ChangeHeader.Text = "更改";
            this.button_ChangeHeader.UseVisualStyleBackColor = true;
            this.button_ChangeHeader.Click += new System.EventHandler(this.button_ChangeHeader_Click);
            // 
            // button_Join
            // 
            this.button_Join.Enabled = false;
            this.button_Join.Location = new System.Drawing.Point(337, 239);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(73, 23);
            this.button_Join.TabIndex = 60;
            this.button_Join.Text = "加入→";
            this.button_Join.UseVisualStyleBackColor = true;
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "名称:";
            // 
            // textBox_TemplateName
            // 
            this.textBox_TemplateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TemplateName.BackColor = System.Drawing.Color.Red;
            this.textBox_TemplateName.Location = new System.Drawing.Point(464, 456);
            this.textBox_TemplateName.Name = "textBox_TemplateName";
            this.textBox_TemplateName.Size = new System.Drawing.Size(172, 21);
            this.textBox_TemplateName.TabIndex = 58;
            this.textBox_TemplateName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(337, 315);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(73, 23);
            this.button_Delete.TabIndex = 57;
            this.button_Delete.Text = "删除×";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 56;
            this.label7.Text = "标题:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "购买链接:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 54;
            this.label5.Text = "查看更多链接:";
            // 
            // listBox_TemplateA
            // 
            this.listBox_TemplateA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_TemplateA.FormattingEnabled = true;
            this.listBox_TemplateA.ItemHeight = 12;
            this.listBox_TemplateA.Location = new System.Drawing.Point(10, 286);
            this.listBox_TemplateA.Name = "listBox_TemplateA";
            this.listBox_TemplateA.Size = new System.Drawing.Size(321, 184);
            this.listBox_TemplateA.TabIndex = 53;
            // 
            // textBox_ViewMoreLnk
            // 
            this.textBox_ViewMoreLnk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ViewMoreLnk.BackColor = System.Drawing.Color.Red;
            this.textBox_ViewMoreLnk.Location = new System.Drawing.Point(708, 7);
            this.textBox_ViewMoreLnk.Name = "textBox_ViewMoreLnk";
            this.textBox_ViewMoreLnk.Size = new System.Drawing.Size(312, 21);
            this.textBox_ViewMoreLnk.TabIndex = 52;
            this.textBox_ViewMoreLnk.TextChanged += new System.EventHandler(this.textBox_ViewMoreLnk_TextChanged);
            // 
            // textBox_BuyNowLnk
            // 
            this.textBox_BuyNowLnk.BackColor = System.Drawing.Color.Red;
            this.textBox_BuyNowLnk.Location = new System.Drawing.Point(73, 212);
            this.textBox_BuyNowLnk.Name = "textBox_BuyNowLnk";
            this.textBox_BuyNowLnk.Size = new System.Drawing.Size(337, 21);
            this.textBox_BuyNowLnk.TabIndex = 51;
            this.textBox_BuyNowLnk.TextChanged += new System.EventHandler(this.textBox_ProductName_TextChanged);
            // 
            // textBox_Trick
            // 
            this.textBox_Trick.BackColor = System.Drawing.Color.Red;
            this.textBox_Trick.Location = new System.Drawing.Point(351, 133);
            this.textBox_Trick.Name = "textBox_Trick";
            this.textBox_Trick.Size = new System.Drawing.Size(59, 21);
            this.textBox_Trick.TabIndex = 50;
            this.textBox_Trick.TextChanged += new System.EventHandler(this.textBox_ProductName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "$";
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.Red;
            this.textBox_Price.Location = new System.Drawing.Point(275, 133);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(56, 21);
            this.textBox_Price.TabIndex = 48;
            this.textBox_Price.TextChanged += new System.EventHandler(this.textBox_ProductName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(261, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "$";
            // 
            // textBox_ProductDescription
            // 
            this.textBox_ProductDescription.BackColor = System.Drawing.Color.Red;
            this.textBox_ProductDescription.Location = new System.Drawing.Point(10, 161);
            this.textBox_ProductDescription.Multiline = true;
            this.textBox_ProductDescription.Name = "textBox_ProductDescription";
            this.textBox_ProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ProductDescription.Size = new System.Drawing.Size(400, 41);
            this.textBox_ProductDescription.TabIndex = 46;
            this.textBox_ProductDescription.TextChanged += new System.EventHandler(this.textBox_ProductName_TextChanged);
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.BackColor = System.Drawing.Color.Red;
            this.textBox_ProductName.Location = new System.Drawing.Point(10, 134);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(231, 21);
            this.textBox_ProductName.TabIndex = 45;
            this.textBox_ProductName.TextChanged += new System.EventHandler(this.textBox_ProductName_TextChanged);
            // 
            // textBox_Title
            // 
            this.textBox_Title.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Title.ForeColor = System.Drawing.Color.Red;
            this.textBox_Title.Location = new System.Drawing.Point(464, 7);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(149, 21);
            this.textBox_Title.TabIndex = 43;
            this.textBox_Title.Text = "Today\'s Hot";
            this.textBox_Title.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // button_SaveTemplate
            // 
            this.button_SaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SaveTemplate.Location = new System.Drawing.Point(642, 455);
            this.button_SaveTemplate.Name = "button_SaveTemplate";
            this.button_SaveTemplate.Size = new System.Drawing.Size(130, 23);
            this.button_SaveTemplate.TabIndex = 42;
            this.button_SaveTemplate.Text = "保存模版";
            this.button_SaveTemplate.UseVisualStyleBackColor = true;
            // 
            // button_ViewTemplate
            // 
            this.button_ViewTemplate.Location = new System.Drawing.Point(337, 286);
            this.button_ViewTemplate.Name = "button_ViewTemplate";
            this.button_ViewTemplate.Size = new System.Drawing.Size(73, 23);
            this.button_ViewTemplate.TabIndex = 41;
            this.button_ViewTemplate.Text = "查看→";
            this.button_ViewTemplate.UseVisualStyleBackColor = true;
            // 
            // webBrowser_TemplateA
            // 
            this.webBrowser_TemplateA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser_TemplateA.Location = new System.Drawing.Point(425, 34);
            this.webBrowser_TemplateA.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_TemplateA.Name = "webBrowser_TemplateA";
            this.webBrowser_TemplateA.Size = new System.Drawing.Size(675, 414);
            this.webBrowser_TemplateA.TabIndex = 40;
            this.webBrowser_TemplateA.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_TemplateA_DocumentCompleted);
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Img.Image = global::EDM_Builder.Properties.Resources.empty_pic_bg;
            this.pictureBox_Img.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(400, 117);
            this.pictureBox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Img.TabIndex = 44;
            this.pictureBox_Img.TabStop = false;
            this.pictureBox_Img.Click += new System.EventHandler(this.pictureBox_Img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TemplateA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_ClearTemplate);
            this.Controls.Add(this.button_ChangeHeader);
            this.Controls.Add(this.button_Join);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_TemplateName);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_TemplateA);
            this.Controls.Add(this.textBox_ViewMoreLnk);
            this.Controls.Add(this.textBox_BuyNowLnk);
            this.Controls.Add(this.textBox_Trick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ProductDescription);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.pictureBox_Img);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.button_SaveTemplate);
            this.Controls.Add(this.button_ViewTemplate);
            this.Controls.Add(this.webBrowser_TemplateA);
            this.Name = "TemplateA";
            this.Size = new System.Drawing.Size(1108, 485);
            this.Load += new System.EventHandler(this.TemplateA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ClearTemplate;
        private System.Windows.Forms.Button button_ChangeHeader;
        private System.Windows.Forms.Button button_Join;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_TemplateName;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_TemplateA;
        private System.Windows.Forms.TextBox textBox_ViewMoreLnk;
        private System.Windows.Forms.TextBox textBox_BuyNowLnk;
        private System.Windows.Forms.TextBox textBox_Trick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ProductDescription;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.PictureBox pictureBox_Img;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Button button_SaveTemplate;
        private System.Windows.Forms.Button button_ViewTemplate;
        private System.Windows.Forms.WebBrowser webBrowser_TemplateA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
