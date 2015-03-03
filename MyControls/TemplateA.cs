using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EDM_Builder.Entity;

namespace EDM_Builder.Control
{
    public partial class TemplateA : UserControl
    {
        private readonly string STRING_TEMPLATE_A_PATH = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\TemplateA\\TemplateA.html");
        private readonly string STRING_TEMPLATE_A_ITEM_PATH = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\TemplateA\\TemplateA_Item.html");
        private readonly string STRING_TEMPLATE_A_CURRENT_PATH = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\TemplateA\\Temp.html");
        private string imgPath;

        public TemplateA()
        {
            InitializeComponent();
            NavigateTemplateA();
        }

        private void NavigateTemplateA()
        {
            if (File.Exists(STRING_TEMPLATE_A_CURRENT_PATH))
            {
                webBrowser_TemplateA.Navigate(STRING_TEMPLATE_A_CURRENT_PATH);
            }
            else
            {
                webBrowser_TemplateA.Navigate(STRING_TEMPLATE_A_PATH);
            }
        }

        private void TemplateA_Load(object sender, EventArgs e)
        {
        }

        private void textBox_ProductName_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
            button_Join.Enabled = VerifyCanJoin();
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
        }

        /// <summary>
        /// 验证是否可以加入
        /// </summary>
        /// <returns></returns>
        private bool VerifyCanJoin()
        {
            if (string.IsNullOrEmpty(imgPath))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ProductName.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ProductDescription.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Price.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Trick.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox_BuyNowLnk.Text))
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
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.bmp";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                imgPath = openFileDialog1.FileName;
                pictureBox_Img.Image = Image.FromFile(imgPath);
                button_Join.Enabled = VerifyCanJoin();
            }
        }

        /// <summary>
        /// 更改模版头部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ChangeHeader_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlElement templateAContent = webBrowser_TemplateA.Document.GetElementById("template-title");
                templateAContent.InnerText = textBox_Title.Text;
                templateAContent = webBrowser_TemplateA.Document.GetElementById("template-view-more");
                templateAContent.SetAttribute("href", textBox_ViewMoreLnk.Text);
                NavigateTemplateA();
                MessageBox.Show("修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！\r\n" + ex.Message + "\r\n" + ex.StackTrace, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_ViewMoreLnk_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
            if (string.IsNullOrEmpty(textBox_Title.Text) == false && string.IsNullOrEmpty(textBox_ViewMoreLnk.Text) == false)
            {
                button_ChangeHeader.Enabled = true;
            }
            else
            {
                button_ChangeHeader.Enabled = false;
            }
        }

        /// <summary>
        /// 加入模版
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Join_Click(object sender, EventArgs e)
        {
            TemplateA_ItemEntity templateA_Item = new TemplateA_ItemEntity();
            templateA_Item.ImagePath = imgPath;
            templateA_Item.Name = textBox_ProductName.Text;
            templateA_Item.Description = textBox_ProductDescription.Text;
            templateA_Item.Price = textBox_Price.Text;
            templateA_Item.Trick = textBox_Trick.Text;
            templateA_Item.BuyNowLnk = textBox_ViewMoreLnk.Text;

            string strTemplateA_item = string.Format(File.ReadAllText(STRING_TEMPLATE_A_ITEM_PATH)
                , templateA_Item.BuyNowLnk
                , templateA_Item.ImagePath
                , templateA_Item.BuyNowLnk
                , templateA_Item.Name
                , templateA_Item.Price
                , templateA_Item.Trick
                , templateA_Item.Description
                , templateA_Item.BuyNowLnk
                );

            if (File.Exists(STRING_TEMPLATE_A_CURRENT_PATH))
            {
                strTemplateA_item = string.Format(File.ReadAllText(STRING_TEMPLATE_A_CURRENT_PATH), strTemplateA_item + "{0}");
            }
            else
            {
                strTemplateA_item = string.Format(File.ReadAllText(STRING_TEMPLATE_A_PATH), strTemplateA_item + "{0}");
            }

            using (FileStream fs = File.Open(STRING_TEMPLATE_A_CURRENT_PATH, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(strTemplateA_item);
                    webBrowser_TemplateA.AllowNavigation = true;
                    webBrowser_TemplateA.Navigate(STRING_TEMPLATE_A_CURRENT_PATH);
                }
            }
        }

        private void webBrowser_TemplateA_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_TemplateA.AllowNavigation = false;
        }

        private void button_ClearTemplate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定要清空当前编辑的模版吗？\r\n清空后不可恢复！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                File.Delete(STRING_TEMPLATE_A_CURRENT_PATH);
                webBrowser_TemplateA.AllowNavigation = true;
                NavigateTemplateA();
            }
        }
    }
}
