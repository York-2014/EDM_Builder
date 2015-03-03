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
    public partial class Product_E : UserControl
    {
        public readonly string Product_Style_E_Html = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\ProductStyle\\product_sylte_e.html");

        /// <summary>
        /// 图片路径
        /// </summary>
        public string imgPath;

        public Product_E()
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
                using (StreamReader sr = new StreamReader(Product_Style_E_Html))
                {
                    strHtml = sr.ReadToEnd();
                }
                strHtml = string.Format(strHtml, textBox_URL.Text + MainFrm.strLinkPart, imgPath);
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
            if (string.IsNullOrEmpty(imgPath))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_URL.Text))
            {
                return false;
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
    }
}
