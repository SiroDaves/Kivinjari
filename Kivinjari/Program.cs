using EasyTabs;
using System;
using System.Windows.Forms;

namespace Kivinjari
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BbMainWindow kivinjari = new BbMainWindow();

            kivinjari.Tabs.Add(new TitleBarTab(kivinjari)
            {
                Content = new CcTabWindow("")
                {
                    Text = "New Tab"
                }
            });
            kivinjari.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(kivinjari);

            Application.Run(applicationContext);
        }
    }
}
