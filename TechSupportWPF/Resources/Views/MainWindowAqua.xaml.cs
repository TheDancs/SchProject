﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DesktopToast;
using DesktopToast.Wpf;
using GalaSoft.MvvmLight.Ioc;
using SchProject.TechSupportSecure;
using GalaSoft.MvvmLight.Messaging;
using System.Timers;

namespace SchProject.Resources.Layout
{
    /// <summary>
    /// Interaction logic for MainWindowAqua.xaml
    /// </summary>
    public partial class MainWindowAqua : Window
    {
        public MainWindowAqua()
        {
            InitializeComponent();
        }
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            NotificationActivator.RegisterComType(typeof(NotificationActivator), OnActivated);
            NotificationHelper.RegisterComServer(typeof(NotificationActivator), Assembly.GetExecutingAssembly().Location);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            NotificationActivator.UnregisterComType();
        }
        private void OnActivated(string arguments, Dictionary<string, string> data)
        {
            var result = "Activated";
            if ((arguments?.StartsWith("action=")).GetValueOrDefault())
            {
                result = arguments.Substring("action=".Length);

                if (data.Count > 0 && result == "Replied")
                {
                    var res = data.FirstOrDefault();
                    Messenger.Default.Send<ReplyMessage>(new ReplyMessage(res.Key, res.Value));
                }
            }
        }

        private void MainWindowAqua_OnClosing(object sender, CancelEventArgs e)
        {
            Messenger.Default.Send<string>("closing");
            SimpleIoc.Default.GetInstance<TechSupportServer>().host?.ChangeMyStatus(Status.Away);
        }
    }
}