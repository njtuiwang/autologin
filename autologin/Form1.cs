using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsharpHttpHelper;
using CsharpHttpHelper.Enum;

namespace autologin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string refurl = "";
        private string loginurl = "";
        private string codeurl = "";
        private string successurl = "";

        private void Btn_login_Click(object sender, EventArgs e)
        {
            var username = "";
            var pwd = "";
            var data = string.Format("username={0}&password={1}&verify={2}", username, pwd, txt_code.Text);
            MessageBox.Show(data);
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = loginurl,
                Encoding = System.Text.Encoding.GetEncoding("utf-8"),
                Method = "get",
                IsToLower = false,
                Cookie = txt_cookie.Text,
                Referer = refurl,
                Postdata = data,
                Timeout = 100000,
                ReadWriteTimeout = 30000,
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
                ContentType = "application/x-www-form-urlencoded",
                Allowautoredirect = false,
                ResultType = ResultType.String
            };
            item.Header.Add("X-Requested-With", "XMLHttpRequest");

            HttpResult result = http.GetHtml(item);

            txt_res.Text = result.Html;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = refurl,//URL     必需项   
                Encoding = System.Text.Encoding.GetEncoding("utf-8"),//URL     可选项 默认为Get  
                Method = "get",//URL     可选项 默认为Get  
                Referer = refurl,//来源URL     可选项  
                Allowautoredirect = false,//是否根据301跳转     可选项   
                ProxyIp = "",//代理服务器ID     可选项 不需要代理 时可以不设置这三个参数   
            };
            HttpResult result = http.GetHtml(item);

            txt_cookie.Text = result.Cookie;
            item = new HttpItem()
            {
                URL = codeurl,//URL     必需项   
                Encoding = System.Text.Encoding.GetEncoding("utf-8"),//URL     可选项 默认为Get  
                Method = "get",//URL     可选项 默认为Get  
                Referer = refurl,//来源URL     可选项  
                Allowautoredirect = false,//是否根据301跳转     可选项  
                ResultType = ResultType.Byte,
                Cookie = result.Cookie
            };
            result = http.GetHtml(item);
            btn_code.BackgroundImage = byteArrayToImage(result.ResultByte);
        }

        /// <summary>
        /// 字节数组生成图片
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns></returns>
        private Image byteArrayToImage(byte[] Bytes)
        {
            MemoryStream ms = new MemoryStream(Bytes);
            Image outputImg = Image.FromStream(ms);
            return outputImg;
        }
    }
}