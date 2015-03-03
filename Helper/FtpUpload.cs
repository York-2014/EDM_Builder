using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Globalization;
using Tamir.SharpSsh;
using Tamir.SharpSsh.jsch;
using System.Collections;
using System.Windows.Forms;

namespace EDM_Builder.Helper
{
    class SFTPUpload
    {
        //private ChannelSftp cs;

        private Sftp m_sftp;
        string targetFile;

        public SFTPUpload(string ip, string user, string pwd, string remoteFile)
        {
            m_sftp = new Sftp(ip, user, pwd);
            setTargetFile(remoteFile);

        }
        public SFTPUpload(string ip, string user, string pwd)
        {
            m_sftp = new Sftp(ip, user, pwd);
        }

        public void setTargetFile(string remoteFile)
        {
            targetFile = remoteFile;
        }
        public bool connect()
        {
            try
            {
                m_sftp.Connect();
            }
            catch
            {
                MessageBox.Show("链接失败");
                return false;
            }
            return true;
        }
        public bool isConnected()
        {
            return m_sftp.Connected;
        }
        public string ParseDirectory(string destFilePath)
        {
            return destFilePath.Substring(0, destFilePath.LastIndexOf("/"));
        }
        public bool Put(string localFile)
        {
            try
            {
                try
                {
                    m_sftp.Mkdir(targetFile);
                }
                catch
                {
                }
                m_sftp.Put(localFile, targetFile);
                return true;
            }
            catch
            {
                MessageBox.Show("上传文件失败");
                return false;
            }
        }
    }

    /*其他上传方式*/
    class SFTPHelper
    {
        private Session m_session;
        private Channel m_channel;
        private ChannelSftp m_sftp;
        private Sftp n_sftp;

        private string targetFile;

        public void setTargetFile(string str)
        {
            targetFile = str;
        }

        //host:sftp地址   user：用户名   pwd：密码         
        public SFTPHelper(string ip, string port, string user, string pwd)
        {
            //Logger.info("SFTP ip:" + ip + " port:" + port);

            int serverport = Int32.Parse(port);

            JSch jsch = new JSch();
            m_session = jsch.getSession(user, ip, serverport);

            MyUserInfo ui = new MyUserInfo();
            ui.setPassword(pwd);
            m_session.setUserInfo(ui);
        }

        public bool run()
        {
            string ServerIP = @"106.187.45.29";
            string UserID = "root";
            string Password = "uJsqPQBIAqq42j";
            string Path = "/home/wwwroot/pandacheer.net/edm/test1";
            string localurl = @".\Result\Logos\Australia_logo.png";

            n_sftp = new Sftp(ServerIP, UserID, Password);
            n_sftp.Connect();
            ArrayList k = n_sftp.GetFileList("/home/wwwroot/pandacheer.net/edm/test1");
            //n_sftp.Get("/home/wwwroot/pandacheer.net/edm/test1/dbo.Table_1.sql");
            n_sftp.Put(@"C:\Users\Neo\Desktop\viewmore.png", Path);

            return true;
        }

        //SFTP连接状态         
        public bool Connected { get { return m_session.isConnected(); } }

        //连接SFTP         
        public bool Connect()
        {
            try
            {
                if (!Connected)
                {
                    m_session.connect();
                    m_channel = m_session.openChannel("sftp");
                    m_channel.connect();
                    m_sftp = (ChannelSftp)m_channel;
                }
                return true;
            }
            catch (Exception ex)
            {
                //Logger.error("SFTP连接异常！" + ex.ToString());
                return false;
            }
        }

        //断开SFTP         
        public void Disconnect()
        {
            if (Connected)
            {
                m_channel.disconnect();
                m_session.disconnect();
            }
        }

        //SFTP存放文件         
        public bool Put(string localPath, string remotePath)
        {
            try
            {
                Connect();
                if (this.Connected)
                {
                    Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(localPath);
                    Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(remotePath);
                    m_sftp.put(src, dst);
                    return true;
                }
            }
            catch (Exception ex)
            {
                //Logger.error("SFTP上传文件错误！" + ex.ToString());
                return false;
            }
            return false;
        }
        public bool Put(string localFile)
        {

            try
            {
                m_sftp.mkdir(new Tamir.SharpSsh.java.String(targetFile));
            }
            catch
            {
            }
            if(Put(localFile, targetFile))
            {
                 return true;
            }
            else
            {
                //MessageBox.Show("上传文件失败");
                return false;
            }
        }
        //SFTP获取文件         
        public bool Get(string remotePath, string localPath)
        {
            try
            {
                Tamir.SharpSsh.java.String src = new Tamir.SharpSsh.java.String(remotePath);
                Tamir.SharpSsh.java.String dst = new Tamir.SharpSsh.java.String(localPath);
                m_sftp.get(src, dst);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //删除SFTP文件 
        public bool Delete(string remoteFile)
        {
            try
            {
                m_sftp.rm(remoteFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //获取SFTP文件列表         
        public ArrayList GetFileList(string remotePath, string fileType)
        {
            try
            {
                Tamir.SharpSsh.java.util.Vector vvv = m_sftp.ls(remotePath);
                ArrayList objList = new ArrayList();
                foreach (Tamir.SharpSsh.jsch.ChannelSftp.LsEntry qqq in vvv)
                {
                    string sss = qqq.getFilename();
                    if (sss.Length > (fileType.Length + 1) && fileType == sss.Substring(sss.Length - fileType.Length))
                    { objList.Add(sss); }
                    else { continue; }
                }

                return objList;
            }
            catch
            {
                return null;
            }
        }

    }

    //登录验证信息         
    public class MyUserInfo : UserInfo
    {
        String passwd;

        public String getPassword() { return passwd; }
        public void setPassword(String passwd) { this.passwd = passwd; }

        public String getPassphrase() { return null; }
        public bool promptPassphrase(String message) { return true; }

        public bool promptPassword(String message) { return true; }
        public bool promptYesNo(String message) { return true; }
        public void showMessage(String message) { }

    }

    class FtpUpload
    {
        //上传文件
        string ftpServerIP = @"106.187.45.29";
        string ftpUserID = "root";
        string ftpPassword = "uJsqPQBIAqq42j";
        string ftpPath = @"/home/wwwroot/pandacheer.netedm/test1/";

        public FtpUpload() { }

        public FtpUpload(string path)
        {
            ftpPath = path;
        }

        public string Upload(string localFile)
        {
            //检查目录是否存在，不存在创建
            FtpCheckDirectoryExist(ftpPath);
            FileInfo fi = new FileInfo(localFile);
            FileStream fs = fi.OpenRead();
            long length = fs.Length;
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + ftpServerIP + ftpPath + fi.Name);
            req.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.ContentLength = length;
            req.Timeout = 10 * 1000;
            try
            {
                Stream stream = req.GetRequestStream();
                int BufferLength = 2048; //2K   
                byte[] b = new byte[BufferLength];
                int i;
                while ((i = fs.Read(b, 0, BufferLength)) > 0)
                {
                    stream.Write(b, 0, i);
                }
                stream.Close();
                stream.Dispose();
            }
            catch (Exception e)
            {
                //ErrLog(e.Message + e.StackTrace);
                return "Upload Error";
            }
            finally
            {
                fs.Close();
                req.Abort();
            }
            req.Abort();
            return ftpServerIP + ftpPath + fi.Name;
        }

        //判断文件的目录是否存,不存则创建
        public void FtpCheckDirectoryExist(string destFilePath)
        {
            string fullDir = FtpParseDirectory(destFilePath);
            string[] dirs = fullDir.Split('/');
            string curDir = "/";
            for (int i = 0; i < dirs.Length; i++)
            {
                string dir = dirs[i];
                //如果是以/开始的路径,第一个为空  
                if (dir != null && dir.Length > 0)
                {
                    try
                    {
                        curDir += dir + "/";
                        FtpMakeDir(curDir);
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        public string FtpParseDirectory(string destFilePath)
        {
            return destFilePath.Substring(0, destFilePath.LastIndexOf("/"));
        }

        //创建目录
        public Boolean FtpMakeDir(string localFile)
        {
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpServerIP + localFile);
            req.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            req.Method = WebRequestMethods.Ftp.MakeDirectory;
            try
            {
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                response.Close();
            }
            catch (Exception)
            {
                req.Abort();
                return false;
            }
            req.Abort();
            return true;
        }

    }


}

