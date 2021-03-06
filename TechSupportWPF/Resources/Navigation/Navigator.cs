﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using SchProject.Annotations;
using SchProject.Resources.Layout;
using SchProject.TechSupportSecure;

namespace SchProject
{
    internal class NavigatorSingleton
    {
        private Navigator _navigator;

        public Navigator Navigator
        {
            get { return _navigator ?? (_navigator = new Navigator()); }
        }
    }
    public class Navigator : INotifyPropertyChanged
    {
        private UserControl _rootControl;

        public Navigator()
        {
            RootControl = new Login();
        }

        public UserControl RootControl
        {
            get
            {
                return _rootControl;
            }

            private set
            {
                _rootControl = value;
                OnPropertyChanged();
            }
        }
        public void Login()
        {
            RootControl = new RootMenu();
        }

        public void Logout()
        {
            SimpleIoc.Default.GetInstance<TechSupportServer>().host?.ChangeMyStatus(Status.Away);
            RootControl = new Login();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
