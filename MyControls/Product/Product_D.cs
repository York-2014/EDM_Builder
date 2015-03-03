using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EDM_Builder.MyControls.Product
{
    public partial class Product_D : UserControl
    {
        public readonly string Product_Style_D_Html = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\ProductStyle\\product_sylte_d.html");

        private readonly string strLine = " style=\"border-top:1px solid #dadada;\"";

        /// <summary>
        /// 图片路径
        /// </summary>
        public string imgPath;

        public Product_D()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取即将加入的html内容
        /// </summary>
        /// <returns></returns>
        public string Get_Pending_Join_Html_Content()
        {
            string strHtml = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(Product_Style_D_Html))
                {
                    strHtml = sr.ReadToEnd();
                }
                if (checkBox_HasLine.Checked)
                {
                    strHtml = string.Format(strHtml, imgPath, textBox_URL.Text.Trim() + MainFrm.strLinkPart,
                        textBox_ProductName.Text, textBox_Reference.Text, MainFrm.ViewMoreString, textBox_ViewMore.Text + MainFrm.strLinkPart, strLine);
                }
                else
                {
                    strHtml = string.Format(strHtml, imgPath, textBox_URL.Text.Trim() + MainFrm.strLinkPart,
                        textBox_ProductName.Text, textBox_Reference.Text, MainFrm.ViewMoreString, textBox_ViewMore.Text + MainFrm.strLinkPart, string.Empty);
                }
                MainFrm.lstImagePath.Add(imgPath);
            }
            catch (Exception ex)
            {
                //
            }
            return strHtml;
        }

        /// <summary>
        /// 检查是否准备好了
        /// </summary>
        /// <returns></returns>
        public bool IsReady()
        {
            if (((MainFrm)(this.TopLevelControl)).strEditHtmlContent.Contains("<!--end-->") == false)
            {
                return false;
            }
            if (string.IsNullOrEmpty(imgPath))
            {
                return false;
            }
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        if (c.Name != "textBox_Img")
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 修改图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Img_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = string.Empty;
                openFileDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.bmp";
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    imgPath = openFileDialog1.FileName;
                    pictureBox_Img.Image = Image.FromFile(imgPath);
                    UpdateJoinButtonState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载图片异常，请重试！\r\n" + ex.Message + "\r\n" + ex.StackTrace, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 更改文本框内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.White;
            }
            UpdateJoinButtonState();
        }

        /// <summary>
        /// 更新加入按钮的状态
        /// </summary>
        public void UpdateJoinButtonState()
        {
            ((MainFrm)(this.TopLevelControl)).SetJoinButtonState(IsReady());
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            imgPath = string.Empty;
            pictureBox_Img.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// 更新货币符号
        /// </summary>
        /// <param name="currencySymbol"></param>
        public void UpdateCurrencySymbol(string currencySymbol)
        {
            //this.label_Currency.Text = currencySymbol;
            //this.label_Currency_small.Text = currencySymbol;
        }

        private void checkBox_LocalImg_CheckedChanged(object sender, EventArgs e)
        {
            imgPath = string.Empty;
            if (checkBox_LocalImg.Checked)
            {
                checkBox_LocalImg.ForeColor = Color.Blue;
                textBox_Img.Hide();
                pictureBox_Img.Show();
            }
            else
            {
                checkBox_LocalImg.ForeColor = Color.Black;
                pictureBox_Img.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
                pictureBox_Img.Hide();
                textBox_Img.Show();
            }
            UpdateJoinButtonState();
        }

        private void textBox_Img_TextChanged(object sender, EventArgs e)
        {
            imgPath = textBox_Img.Text.Trim();
            TextBox_TextChanged(sender, e);
        }
    }
}
