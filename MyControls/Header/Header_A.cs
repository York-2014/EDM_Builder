using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EDM_Builder.MyControls.Header
{
    public partial class Header_A : UserControl
    {
        public readonly string Header_Style_A_Html = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\HeaderStyle\\header_style_a.html");

        public Header_A()
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
                using (StreamReader sr = new StreamReader(Header_Style_A_Html))
                {
                    strHtml = sr.ReadToEnd();
                }
                strHtml = string.Format(strHtml,
                            textBox_Title_1.Text,
                            textBox_Title_2.Text,
                            textBox_Title_3.Text,
                            textBox_Title_4.Text,
                            textBox_Title_5.Text,
                            textBox_Title_6.Text,
                            textBox_Title_7.Text,
                            textBox_URL_1.Text + MainFrm.strLinkPart,
                            textBox_URL_2.Text + MainFrm.strLinkPart,
                            textBox_URL_3.Text + MainFrm.strLinkPart,
                            textBox_URL_4.Text + MainFrm.strLinkPart,
                            textBox_URL_5.Text + MainFrm.strLinkPart,
                            textBox_URL_6.Text + MainFrm.strLinkPart,
                            textBox_URL_7.Text + MainFrm.strLinkPart);
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
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
            }
            return true;
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