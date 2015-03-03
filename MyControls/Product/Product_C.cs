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
    public partial class Product_C : UserControl
    {
        public readonly string Product_Style_C_Html = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\ProductStyle\\product_sylte_c.html");

        /// <summary>
        /// 图片路径
        /// </summary>
        public string imgPath_Left;

        /// <summary>
        /// 图片路径
        /// </summary>
        public string imgPath_Right;


        public Product_C()
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
                using (StreamReader sr = new StreamReader(Product_Style_C_Html))
                {
                    strHtml = sr.ReadToEnd();
                }
                strHtml = string.Format(strHtml,
                    textBox_URL_Left.Text + MainFrm.strLinkPart, imgPath_Left
                    , textBox_ProductName_Left.Text
                    , MainFrm.CurrentCurrency + textBox_Price_Left.Text
                    , MainFrm.CurrentCurrency + textBox_Trick_Left.Text
                    , textBox_ViewMoreLnk_Left.Text + MainFrm.strLinkPart
                    , MainFrm.ViewMoreString,
                    textBox_URL_Right.Text + MainFrm.strLinkPart, imgPath_Right
                    , textBox_ProductName_Right.Text
                    , MainFrm.CurrentCurrency + textBox_Price_Right.Text
                    , MainFrm.CurrentCurrency + textBox_Trick_Right.Text
                    , textBox_ViewMoreLnk_Right.Text + MainFrm.strLinkPart
                    , MainFrm.ViewMoreString);
                MainFrm.lstImagePath.Add(imgPath_Left);
                MainFrm.lstImagePath.Add(imgPath_Right);
            }
            catch (Exception ex)
            {
                //
            }
            return strHtml;
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
        /// 设置图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Left_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = string.Empty;
                openFileDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.bmp";
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    imgPath_Left = openFileDialog1.FileName;
                    pictureBox_Left.Image = Image.FromFile(imgPath_Left);
                    UpdateJoinButtonState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载图片异常，请重试！\r\n" + ex.Message + "\r\n" + ex.StackTrace, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Right_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = string.Empty;
                openFileDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.bmp";
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    imgPath_Right = openFileDialog1.FileName;
                    pictureBox_Right.Image = Image.FromFile(imgPath_Right);
                    UpdateJoinButtonState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载图片异常，请重试！\r\n" + ex.Message + "\r\n" + ex.StackTrace, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (string.IsNullOrEmpty(imgPath_Left))
            {
                return false;
            }
            if (string.IsNullOrEmpty(imgPath_Right))
            {
                return false;
            }
            foreach (object c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (c != textBox_Img_Left && c != textBox_Img_Right)
                    {
                        if (string.IsNullOrEmpty(((TextBox)c).Text))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
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
            imgPath_Left = string.Empty;
            imgPath_Right = string.Empty;
            pictureBox_Left.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
            pictureBox_Right.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
            foreach (object c in this.Controls)
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
            this.label_Currency_Left.Text = currencySymbol;
            this.label_Currency_Right.Text = currencySymbol;
        }

        private void checkBox_LocalImg_Left_CheckedChanged(object sender, EventArgs e)
        {
            imgPath_Left = string.Empty;
            if (checkBox_LocalImg_Left.Checked)
            {
                checkBox_LocalImg_Left.ForeColor = Color.Blue;
                textBox_Img_Left.Text = string.Empty;
                textBox_Img_Left.Hide();
                pictureBox_Left.Show();
            }
            else
            {
                checkBox_LocalImg_Left.ForeColor = Color.Black;
                pictureBox_Left.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
                pictureBox_Left.Hide();
                textBox_Img_Left.Show();
            }
            UpdateJoinButtonState();
        }

        private void checkBox_LocalImg_Right_CheckedChanged(object sender, EventArgs e)
        {
            imgPath_Right = string.Empty;
            if (checkBox_LocalImg_Right.Checked)
            {
                checkBox_LocalImg_Right.ForeColor = Color.Blue;
                textBox_Img_Right.Text = string.Empty;
                textBox_Img_Right.Hide();
                pictureBox_Right.Show();
            }
            else
            {
                checkBox_LocalImg_Right.ForeColor = Color.Black;
                pictureBox_Right.Image = EDM_Builder.Properties.Resources.empty_pic_bg;
                pictureBox_Right.Hide();
                textBox_Img_Right.Show();
            }
            UpdateJoinButtonState();
        }

        private void textBox_Img_Left_TextChanged(object sender, EventArgs e)
        {
            imgPath_Left = textBox_Img_Left.Text.Trim();
            TextBox_TextChanged(sender, e);
        }

        private void textBox_Img_Right_TextChanged(object sender, EventArgs e)
        {
            imgPath_Right = textBox_Img_Right.Text.Trim();
            TextBox_TextChanged(sender, e);
        }
    }
}
