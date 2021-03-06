﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchProject.Resources.Layout.StyleResources
{
    public partial class AquaWindowStyle : ResourceDictionary
    {
        public AquaWindowStyle()
        {
            InitializeComponent();
        }
        private void CloseClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }
        private void MaximizeRestoreClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = window.WindowState == System.Windows.WindowState.Normal ? System.Windows.WindowState.Maximized : System.Windows.WindowState.Normal;
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
