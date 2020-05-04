using EasyTabs;

namespace Kivinjari
{
    public partial class BbMainWindow : TitleBarTabs
    {
        public BbMainWindow()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Resources.DefaultIcon;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new CcTabWindow("")
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
