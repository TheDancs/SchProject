﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ServiceModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using Telerik.Windows.Data;
using System.ComponentModel;
using Microsoft.Practices.ServiceLocation;

namespace SchProject.ViewModel
{
    public class SolvedQuestionsByDay : ObservableObject
    {
        private DateTime  time;
        public DateTime Time
        {
            get { return time; }
            set { Set(ref time, value); }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { Set(ref count, value); }
        }
    }

    public class DemonstrationViewModel : DependencyObject, INotifyPropertyChanged
    {
        //public RadObservableCollection<SolvedQuestionsByDay> Data
        //{
        //    get { return (RadObservableCollection<SolvedQuestionsByDay>)GetValue(DataProperty); }
        //    set { SetValue(DataProperty, value); }
        //}

        //public static readonly DependencyProperty DataProperty =
        //    DependencyProperty.Register("Data", typeof(RadObservableCollection<SolvedQuestionsByDay>), typeof(DemonstrationViewModel));

        public ObservableCollection<SolvedQuestionsByDay> Data { get; private set; } = new ObservableCollection<SolvedQuestionsByDay>();

        public event PropertyChangedEventHandler PropertyChanged;


        private int[] Counts;
        private DateTime[] Dates;
        private List<KeyValuePair<string, int>> pie;

        public  DemonstrationViewModel()
        {
            GetQuestions();
            
        }

        private  void GetQuestions()
        {
            //Counts = ServiceLocator.Current.GetInstance<TechSupportServer>().host.GetLastSevedDaysSolves(out Dates);

            //for (int i = 0; i < Counts.Length; i++)
            //{
            //    Data.Add(new SolvedQuestionsByDay
            //    {
            //        Time = Dates[i],
            //        Count = Counts[i]
            //    });
            //}


        }



    }
}
