using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VMATTBIAutoPlanMT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    MainWindow mw = new MainWindow(e.Args);
        //    mw.Show();
        //}
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var args = e.Args;
            if (args != null && args.Count() > 0)
            {
                //foreach (var arg in args)
                //{
                //    // write code to use the command line arg value 
                //}
            }
            MainWindow mw = new MainWindow(e.Args);
            mw.Show();
        }
    }
}
