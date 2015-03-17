using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using EDM_Builder.Entity;
using EDM_Builder.Helper;

namespace EDM_Builder
{
    public partial class MainFrm : Form
    {
        private List<string> lstAddedElement = new List<string>();
        //SFTPUpload uploader;
        private SFTPHelper sh_uploader;

        //远端连接参数
        private string ServerIP = @"45.56.85.239";//106.187.45.29";
        private string UserID = "root";
        private string Password = "uJsqPQBIAqq42j";
        private static string ServerPath = "pandacheer.net/edm";
        private static string dic = DateTime.Now.ToString("yyyyMMdd");
        private static string WebResoursePath = "http://www.pandacheer.net/edm/" + dic + '/';
        private string strTargetPath = "/home/wwwroot/" + ServerPath + "/" + dic;
        public static string strLinkPart = "?utm_medium=email&amp;utm_source=transactional&amp;utm_campaign=edm";
        public static string strMark = "edm";


        public static List<string> lstImagePath = new List<string>();
        public string strEditHtmlContent = string.Empty;
        private string CurrentCountryFrameHtml = string.Empty;

        private readonly string Temp_Edit_Html_File = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\temp_edit.html");
        private readonly string Header_Foot_Html = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "Html\\Template\\Header\\header_foot.html");

        private readonly string Settings_Xml = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + "EDMSettings.xml");
        private static CountrySettings settings = new CountrySettings();

        public static string OldCurrency = "$";
        public static string CurrentCurrency = "$";
        public static string ViewMoreImgPath = "http://www.sydneytoday.com/8818/emailpage/images/more.jpg";
        public static string ViewMoreString = "View More";

        private static readonly string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private Thread thSubmit;

        private bool JoinButtionEnable = false;

        public MainFrm()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.Text = string.Format("{0} - {1}", this.Text, Common.AssemblyFileVersion());
            comboBox_Country.SelectedIndex = 0;
            //"January 20,  2015"
            //this.textBox_Date.TextChanged -= textBox_Date_TextChanged;
            //this.textBox_Date.Text = string.Format("{0} {1},  {2}", Months[System.DateTime.Now.Month - 1], System.DateTime.Now.Day, DateTime.Now.Year);
            //this.textBox_Date.TextChanged += textBox_Date_TextChanged;
        }

        /// <summary>
        /// 当前国家
        /// </summary>
        private enum CurrentCountry
        {
            /// <summary>
            /// 澳大利亚
            /// </summary>
            AU = 0,

            /// <summary>
            /// 加拿大
            /// </summary>
            CA = 1,

            /// <summary>
            /// 新西兰
            /// </summary>
            NZ = 2,

            /// <summary>
            /// 英国
            /// </summary>
            UK = 3,

            /// <summary>
            /// 美国
            /// </summary>
            US = 4,

            /// <summary>
            /// 法国
            /// </summary>
            FR = 5
        }

        #region 通知UI更新状态
        /// <summary>
        /// 通知状态的委托
        /// </summary>
        /// <param name="obj"></param>
        private delegate void NotifyStatusDelegate(object[] obj);

        #region Invoke通知状态
        /// <summary>
        /// 通知状态
        /// </summary>
        /// <param name="obj"></param>        
        private void NotifyStatus(object[] obj)
        {
            Invoke(new NotifyStatusDelegate(UpdateStatus), new object[] { obj });
        }
        #endregion

        /// <summary>
        /// 通知类型
        /// </summary>
        private enum NotifyType
        {
            /// <summary>
            /// 简单
            /// </summary>
            Simple = 0,

            /// <summary>
            /// 复杂
            /// </summary>
            Complex = 1,

            /// <summary>
            /// 完成
            /// </summary>
            Finished = 2,

            /// <summary>
            /// 结束
            /// </summary>
            Failed = 3
        }

        #region 更新状态
        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="obj"></param>
        private void UpdateStatus(object[] obj)
        {
            //Update UI
            switch ((NotifyType)obj[0])
            {
                case NotifyType.Simple:
                    this.toolStripStatusLabel2.Text = obj[1].ToString();
                    break;
                case NotifyType.Complex:
                    ReLoadingHtmlWeb();
                    this.toolStripStatusLabel2.Text = obj[1].ToString();
                    break;
                case NotifyType.Finished:
                    this.toolStripStatusLabel2.Text = obj[1].ToString();
                    MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                    comboBox_Country.Enabled = true;
                    tabControl1.Enabled = true;
                    button_Join.Enabled = JoinButtionEnable;
                    if (lstAddedElement.Count == 0)
                    {
                        button_Undo.Enabled = false;
                    }
                    else
                    {
                        button_Undo.Enabled = true;
                    }
                    textBox_Mark.Enabled = true;
                    textBox_Date.Enabled = true;
                    Process.Start(textBox_SavePath.Text.Trim());
                    break;
                case NotifyType.Failed:
                    this.toolStripStatusLabel2.Text = obj[1].ToString();
                    MessageBox.Show("生成失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                    comboBox_Country.Enabled = true;
                    tabControl1.Enabled = true;
                    button_Join.Enabled = JoinButtionEnable;
                    if (lstAddedElement.Count == 0)
                    {
                        button_Undo.Enabled = false;
                    }
                    else
                    {
                        button_Undo.Enabled = true;
                    }
                    textBox_Mark.Enabled = true;
                    textBox_Date.Enabled = true;
                    break;
            }
        }
        #endregion
        #endregion

        /// <summary>
        /// 设置加入按钮状态
        /// </summary>
        /// <param name="enabled"></param>
        public void SetJoinButtonState(bool enabled)
        {
            button_Join.Enabled = enabled;
        }

        /// <summary>
        /// 切换国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            dic = string.Format("{0}{1}", DateTime.Now.ToString("yyyyMMdd"), (CurrentCountry)comboBox_Country.SelectedIndex);
            ReLoadingHtmlWeb();
        }

        private void RefreshCurrencyOnUI()
        {
            product_A1.UpdateCurrencySymbol(CurrentCurrency);
            product_B1.UpdateCurrencySymbol(CurrentCurrency);
            product_C1.UpdateCurrencySymbol(CurrentCurrency);
            header_A1.LoadingURL(settings.WebSite);
        }

        private void ReLoadingHtmlWeb()
        {
            switch (comboBox_Country.SelectedIndex)
            {
                case 0:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.AU);
                    break;
                case 1:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.CA);
                    break;
                case 2:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.NZ);
                    break;
                case 3:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.US);
                    break;
                case 4:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.UK);
                    break;
                case 5:
                    CurrentCountryFrameHtml = GetFrameHtmlContent(CurrentCountry.FR);
                    break;
            }
            CurrentCountryFrameHtml = CurrentCountryFrameHtml.Replace("<!--join-->", strEditHtmlContent + "<!--join-->");
            if (null != settings)
            {
                OldCurrency = CurrentCurrency;
                CurrentCurrency = settings.Currency;
                ViewMoreImgPath = settings.ViewMoreImgPath;
                ViewMoreString = settings.ViewDealString;
                CurrentCountryFrameHtml = CurrentCountryFrameHtml.Replace(OldCurrency, CurrentCurrency);
                RefreshCurrencyOnUI();
            }
            //写入临时编辑html文件
            WriteHtmlFile(CurrentCountryFrameHtml);
            webBrowserView.AllowNavigation = true;
            webBrowserView.Navigate(Temp_Edit_Html_File);
        }

        /// <summary>
        /// 写入html文件
        /// </summary>
        /// <param name="htmlContent"></param>
        public void WriteHtmlFile(string htmlContent)
        {
            using (FileStream fs = File.Open(Temp_Edit_Html_File, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(htmlContent);
                }
            }
        }

        /// <summary>
        /// webBrowser1加载完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserView.AllowNavigation = false;
            webBrowserView.Document.Window.ScrollTo(0, webBrowserView.Document.Body.ScrollRectangle.Height);
        }

        /// <summary>
        /// 加入模版
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Join_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strMark))
            {
                MessageBox.Show("请先设置标识内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                strMark = textBox_Mark.Text.Trim();
                strLinkPart = strLinkPart.Replace("edm", strMark);
            }
            string strPendingJoinHtml = string.Empty;
            bool isHeader = false;
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_Header1":
                    strPendingJoinHtml = header_A1.Get_Pending_Join_Html_Content();
                    isHeader = true;
                    break;
                case "tabPage_Header2":
                    strPendingJoinHtml = header_B1.Get_Pending_Join_Html_Content();
                    isHeader = true;
                    break;
                case "tabPage_Header3":
                    strPendingJoinHtml = header_C1.Get_Pending_Join_Html_Content();
                    isHeader = true;
                    break;
                case "tabPage_Product1":
                    strPendingJoinHtml = product_A1.Get_Pending_Join_Html_Content();
                    isHeader = false;
                    break;
                case "tabPage_Product2":
                    strPendingJoinHtml = product_B1.Get_Pending_Join_Html_Content();
                    isHeader = false;
                    break;
                case "tabPage_Product3":
                    strPendingJoinHtml = product_C1.Get_Pending_Join_Html_Content();
                    isHeader = false;
                    break;
                case "tabPage_Product4":
                    strPendingJoinHtml = product_D1.Get_Pending_Join_Html_Content();
                    isHeader = false;
                    break;
                case "tabPage_Product5":
                    strPendingJoinHtml = product_E1.Get_Pending_Join_Html_Content();
                    isHeader = false;
                    break;
            }

            if (isHeader)
            {
                if (string.IsNullOrEmpty(strEditHtmlContent))
                {
                    strEditHtmlContent = strPendingJoinHtml;
                }
                else
                //if (strEditHtmlContent != strPendingJoinHtml)
                {
                    strEditHtmlContent = strEditHtmlContent.Replace("<!--end-->", string.Empty);
                    strEditHtmlContent = strEditHtmlContent + strPendingJoinHtml;
                }
            }
            else
            {
                strEditHtmlContent = strEditHtmlContent.Replace("<!--end-->", strPendingJoinHtml + "<!--end-->");
            }
            lstAddedElement.Add(strEditHtmlContent);
            if (lstAddedElement.Count > 0)
            {
                button_Undo.Enabled = true;
            }
            ReLoadingHtmlWeb();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage_Header1":
                    header_A1.UpdateJoinButtonState();
                    break;
                case "tabPage_Header2":
                    header_B1.UpdateJoinButtonState();
                    break;
                case "tabPage_Header3":
                    header_C1.UpdateJoinButtonState();
                    break;
                case "tabPage_Product1":
                    product_A1.UpdateJoinButtonState();
                    break;
                case "tabPage_Product2":
                    product_B1.UpdateJoinButtonState();
                    break;
                case "tabPage_Product3":
                    product_C1.UpdateJoinButtonState();
                    break;
                case "tabPage_Product4":
                    product_D1.UpdateJoinButtonState();
                    break;
                case "tabPage_Product5":
                    product_E1.UpdateJoinButtonState();
                    break;
            }
        }

        private string GetFrameHtmlContent(CurrentCountry cuntry)
        {
            string strCountryFrameHtml = string.Empty;
            using (StreamReader sr = new StreamReader(Header_Foot_Html))
            {
                strCountryFrameHtml = sr.ReadToEnd();
            }
            settings = GetSettingsByCountry(cuntry);
            if (null != settings)
            {
                strMark = textBox_Mark.Text.Trim();
                strLinkPart = strLinkPart.Replace("edm", strMark);
                strCountryFrameHtml = string.Format(strCountryFrameHtml
                    , textBox_Date.Text
                    , string.Format("{0}{1}", settings.WebSite, strLinkPart)
                    , settings.Logo
                    , settings.Unsubscribe
                    , settings.Twitter
                    , settings.Facebook
                    , settings.Email
                    , settings.FootStringLineOne
                    , settings.FootStringLineTwo
                    , settings.UnsubscribeString
                    );
            }
            return strCountryFrameHtml;
        }

        private CountrySettings GetSettingsByCountry(CurrentCountry cuntry)
        {
            CountrySettings currentCountrySettings = new CountrySettings();
            string settings = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Settings_Xml);

            ServerIP = xmlDoc.DocumentElement.SelectSingleNode("serverIP").InnerText;
            UserID = xmlDoc.DocumentElement.SelectSingleNode("userID").InnerText;
            Password = xmlDoc.DocumentElement.SelectSingleNode("password").InnerText;
            ServerPath = xmlDoc.DocumentElement.SelectSingleNode("serverPath").InnerText;
            strLinkPart = xmlDoc.DocumentElement.SelectSingleNode("linkPart").InnerText;

            XmlNodeList nl = xmlDoc.GetElementsByTagName("country");
            XmlNode EdmParams = null;
            foreach (XmlNode xn in nl)
            {
                if (xn.Attributes["name"].Value.ToLower() == cuntry.ToString().ToLower())
                {
                    EdmParams = xn;
                    break;
                }
            }
            if (null != EdmParams)
            {
                currentCountrySettings.Email = EdmParams.SelectSingleNode("email").InnerText;
                currentCountrySettings.WebSite = EdmParams.SelectSingleNode("website").InnerText;
                currentCountrySettings.Currency = EdmParams.SelectSingleNode("currency").InnerText;
                currentCountrySettings.Logo = EdmParams.SelectSingleNode("logo").InnerText;
                currentCountrySettings.Support = EdmParams.SelectSingleNode("support").InnerText;
                currentCountrySettings.Twitter = EdmParams.SelectSingleNode("twitter").InnerText;
                currentCountrySettings.Facebook = EdmParams.SelectSingleNode("facebook").InnerText;
                currentCountrySettings.Unsubscribe = EdmParams.SelectSingleNode("unsubscribe").InnerText;
                currentCountrySettings.ViewMoreImgPath = EdmParams.SelectSingleNode("viewMoreImgPath").InnerText;
                currentCountrySettings.ViewDealString = EdmParams.SelectSingleNode("viewDealString").InnerText;
                currentCountrySettings.FootStringLineOne = EdmParams.SelectSingleNode("footStringLineOne").InnerText;
                currentCountrySettings.FootStringLineTwo = EdmParams.SelectSingleNode("footStringLineTwo").InnerText;
                currentCountrySettings.UnsubscribeString = EdmParams.SelectSingleNode("unsubscribeString").InnerText;
            }
            else
            {
                currentCountrySettings = null;
            }
            return currentCountrySettings;
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
            UpdateSubmitButtonState();
        }

        private void button_SelectSaveFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择一个文件夹保存生成的模版。";
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                textBox_SavePath.Text = folderBrowserDialog1.SelectedPath;
                UpdateSubmitButtonState();
            }
        }

        /// <summary>
        /// 检查是否准备好了
        /// </summary>
        /// <returns></returns>
        public bool IsReady()
        {
            if (string.IsNullOrEmpty(textBox_SavePath.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 更新提交按钮的状态
        /// </summary>
        public void UpdateSubmitButtonState()
        {
            button_Submit.Enabled = IsReady();
        }

        /// <summary>
        /// 提交并保存模版
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Submit_Click(object sender, EventArgs e)
        {
            textBox_Mark.Enabled = false;
            textBox_Date.Enabled = false;
            button_Undo.Enabled = false;
            JoinButtionEnable = button_Join.Enabled;
            button_Join.Enabled = false;
            comboBox_Country.Enabled = false;
            tabControl1.Enabled = false;
            groupBox1.Enabled = false;

            thSubmit = new Thread(new ThreadStart(SubmitAndSave));
            thSubmit.IsBackground = true;
            thSubmit.Start();
        }

        private void SubmitAndSave()
        {
            //1、上传图片
            NotifyStatus(new object[] { NotifyType.Simple, "正在连接服务器..." });
            sh_uploader = new SFTPHelper(ServerIP, "22", UserID, Password);
            if (sh_uploader.Connect())
            {
                sh_uploader.setTargetFile(strTargetPath);
                foreach (string imgPath in lstImagePath)
                {
                    NotifyStatus(new object[] { NotifyType.Simple, string.Format("连接服务器成功，开始提交图片({0}/{1})...", lstImagePath.IndexOf(imgPath) + 1, lstImagePath.Count) });
                    if (imgPath.Contains("http") || File.Exists(imgPath) == false)
                    {
                        //网络图片则跳过
                        continue;
                    }
                    else
                    {
                        FileInfo fi = new FileInfo(imgPath);
                        while (!sh_uploader.Put(imgPath))
                        {
                            NotifyStatus(new object[] { NotifyType.Simple, "提交图片失败，正在重试..." });
                            while (!sh_uploader.Connected)
                            {
                                NotifyStatus(new object[] { NotifyType.Simple, "服务器连接失败，正在重新连接..." });
                                sh_uploader = new SFTPHelper(ServerIP, "22", UserID, Password);
                                sh_uploader.Connect();
                            }
                        }
                        //2、替换html中的图片路径
                        string strRemoteUrl = WebResoursePath + fi.Name;
                        strEditHtmlContent = strEditHtmlContent.Replace(imgPath, strRemoteUrl);
                    }
                }
                sh_uploader.Disconnect();
                NotifyStatus(new object[] { NotifyType.Complex, "所有图片提交完成,正在保存模版..." });
                //3、保存到指定文件夹
                File.Copy(Temp_Edit_Html_File, Path.Combine(textBox_SavePath.Text, string.Format("Pandacheer_EDM_{0}.html", DateTime.Now.ToString("yyyyMMdd_HHmmss"))));
                NotifyStatus(new object[] { NotifyType.Finished, "完成." });
            }
            else
            {
                NotifyStatus(new object[] { NotifyType.Failed, "连接服务器不成功，请检查网络通信是否正常." });
            }
        }

        private void button_Undo_Click(object sender, EventArgs e)
        {
            if (lstAddedElement.Count > 0)
            {
                strEditHtmlContent = lstAddedElement.Count == 1 ? string.Empty : lstAddedElement[lstAddedElement.Count - 2];
                lstAddedElement.RemoveAt(lstAddedElement.Count - 1);
                if (lstAddedElement.Count == 0)
                {
                    button_Undo.Enabled = false;
                }
                ReLoadingHtmlWeb();
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void textBox_Date_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
            ReLoadingHtmlWeb();
        }
    }
}