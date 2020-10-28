using EasyTabs;
using System.ComponentModel;
using System.Drawing;

namespace Kivinjari
{
    public partial class MainWindow : TitleBarTabs
    {
        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new BrowserWindow("")
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
