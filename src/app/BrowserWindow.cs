using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EasyTabs;
using Kivinjari.Helpers;
using Webview;

namespace Kivinjari
{
    public partial class BrowserWindow : Form
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(BrowserWindow));
        
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        //ChromiumWebBrowser webBrowser;
        public static BrowserWindow Instance;

        public static string Branding = "Kivinjari";
        public static string UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36";
        public static string AcceptLanguage = "en-US,en;q=0.9";
        public static string HomepageURL = "https://www.google.com";
        public static string NewTabURL = "about:blank";
        public static string InternalURL = "kivinjari";
        public static string DownloadsURL = "kivinjari://helpers/downloads.html";
        public static string FileNotFoundURL = "kivinjari://helpers/errors/notFound.html";
        public static string CannotConnectURL = "kivinjari://helpers/errors/cannotConnect.html";
        public static string SearchURL = "https://www.google.com/search?q=";

        public bool WebSecurity = true;
        public bool CrossDomainSecurity = true;
        public bool WebGL = true;
        public bool ApplicationCache = true;

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        public BrowserWindow(string Url)
        {
            InitializeComponent();

            string finalUrl = Url == "" ? NewTabURL : Url;
            TxtAddress.Text = finalUrl;
            Callbacks.AddCallback(nameof(DisplayName), DisplayName);

            /*var webview = new WebviewBuilder("Eval", Content.FromHtml(html))
                .WithSize(new Size(1024, 768))
                .WithInvokeCallback(Callbacks.Handler)
                .Debug()
                .Build();*/
            var webview = new WebviewBuilder(new Uri("https://www.google.com"))
                .WithSize(new Size(1024, 768))
                .WithInvokeCallback(Callbacks.Handler)
                .Debug()
                .Build();

            var tick = 0;
            while (webview.Loop() == 0)
            {
                if (tick % 1000 == 0)
                {
                    webview.Eval(@"document.getElementById('content').textContent = 'Time:" + DateTime.Now + "'");
                }

                tick++;
                GC.Collect();
            }

            //webBrowser = new ChromiumWebBrowser(finalUrl);
            //webPanel.Controls.Add(webBrowser);

            //webBrowser.TitleChanged += Browser_TitleChanged;
            //webBrowser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private static void DisplayName(Webview.Webview webview, string name)
        {
            webview.Eval($@"document.getElementById('display').textContent = 'Hello {name}'");
        }

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }

        private void EnableBackButton(bool canGoBack)
        {
            InvokeIfNeeded(() => BtnBack.Enabled = canGoBack);
        }

        private void EnableForwardButton(bool canGoForward)
        {
            InvokeIfNeeded(() => BtnForward.Enabled = canGoForward);
        }

        private void TxtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fullUrl = TxtAddress.Text;
                if (!Regex.IsMatch(fullUrl, "^[a-zA-Z0-9]+\\://")) fullUrl = "http://" + fullUrl;
                //webBrowser.Load(fullUrl);

                // im handling this
                e.Handled = true;
                e.SuppressKeyPress = true;

                // defocus from url textbox
                this.Focus();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //webBrowser.Back();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            //webBrowser.Forward();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //webBrowser.Refresh();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //webBrowser.Load("about:blank");
        }
        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            //BtnBack.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnBack.BackgroundImage = null;
        }

        private void BtnForward_MouseEnter(object sender, EventArgs e)
        {
            //BtnForward.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void BtnForward_MouseLeave(object sender, EventArgs e)
        {
            BtnForward.BackgroundImage = null;
        }

        private void BtnRefresh_MouseEnter(object sender, EventArgs e)
        {
            //BtnRefresh.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void BtnRefresh_MouseLeave(object sender, EventArgs e)
        {
            BtnRefresh.BackgroundImage = null;
        }

        private void BtnHome_MouseEnter(object sender, EventArgs e)
        {
            //BtnHome.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void BtnHome_MouseLeave(object sender, EventArgs e)
        {
            BtnHome.BackgroundImage = null;
        }
    }
}
