﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_ProjectCostManager
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Window M = new MainWindow();
            //Wpf_LoginSystem.MainWindow w = new Wpf_LoginSystem.MainWindow();
            //if ((bool)w.ShowDialog())
            //{
                M.Show();
            //}
            //else
            //{
            //    M.Close();
            //}
        }
    }
}
