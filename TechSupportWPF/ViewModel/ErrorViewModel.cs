﻿namespace SchProject.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.CommandWpf;
    using GalaSoft.MvvmLight.Messaging;
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System.Windows.Forms;
    using System.Net.Http;
    using Microsoft.AspNet.SignalR.Client;
    using GalaSoft.MvvmLight.Ioc;
    using System.Windows.Threading;
    using Microsoft.Practices.ServiceLocation;

    public class ErrorViewModel : ViewModelBase
    {
        public String UserName { get; set; }
        public IHubProxy HubProxy { get; set; }
        const string ServerURI = "http://localhost:8080/signalr";
        public HubConnection Connection { get; set; }

        public ObservableCollection<string> Messages { get; private set; } = new ObservableCollection<string>();

        private string message;
        public string Message
        {
            get { return message; }
            set {  Set(ref message, value); }
        }

        public NewWorkData NewWorkData { get; set; } = new NewWorkData();

        public ICommand SendMessageCommand
        {
            get;
            private set;                        
        }

        public ICommand NewWorkCommand
        {
            get { return new RelayCommand(NewTechWork); }
        }

        public ICommand SaveNewTechWork
        {
            get { return new RelayCommand(SaveTehcWork, () => NewWorkData != null); }
        }

        private async void SaveTehcWork()
        {
            await ServiceLocator.Current.GetInstance<TechSupportServer>().host.InsertNewTechWorksAsync(
                new TechSupportSecure.NewTechWork
                {
                    CustomerName = NewWorkData.Name,
                    Address = NewWorkData.Address,
                    TimeOrdered = NewWorkData.Time,
                    TechID = NewWorkData.TechID
                });

            NewWorkData.Reset();
            RaisePropertyChanged(nameof(NewWorkData.Visibility), NewWorkData.Visibility = true, NewWorkData.Visibility = false, false);
        }

        private async void NewTechWork()
        {
            NewWorkData.Visibility = true;
            TechSupportSecure.TechnicianData[] available = await ServiceLocator.Current.GetInstance<TechSupportServer>().host.GetAvailableTechnicianAsync();
            int member = available.Length == 1 ? 0 : new Random().Next(0, available.Length - 1);
            NewWorkData.TechName = ( available != null && available[member] != null) ? available[member]?.FullName : "Sorry, no available technician";
            NewWorkData.TechID = NewWorkData.TechName == "Sorry no available tech" ? -1 : available[member].TechnicianID;
            NewWorkData.Time = DateTime.Now;
        }

        public ICommand EventCommand
        {
            get;
            private set;
        }

        private void ButtonSend_Click()
        {
            HubProxy.Invoke("Send", UserName, message);
        }

        //---------------------------------------------------
        //using System.Windows.Threading;
        DispatcherTimer timer = new DispatcherTimer();

        public void ToConsole(object sender, EventArgs e)
        {

            HubProxy.Invoke("Send", UserName, "uzenet");
        }
        private void Event_Click()
        {
            timer.Tick += new EventHandler(ToConsole);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }
        //---------------------------------------------------

        public ErrorViewModel()
        {
            WriteToConsole("Starting server...");
            Messenger.Default.Register<string>(this, WPFClient_Closing);
            UserName = SimpleIoc.Default.GetInstance<UserData>().FullName;
            SendMessageCommand = new RelayCommand(ButtonSend_Click);
            EventCommand = new RelayCommand(Event_Click);

            ConnectAsync();

            NewWorkData.Visibility = false;
        }

        private async void ConnectAsync()
        {
            Connection = new HubConnection(ServerURI);
            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("MyHub");
            //Handle incoming event from server: use Invoke to write to console from SignalR's thread
            HubProxy.On<string, string>("AddMessage", (name, message) =>
                App.Current.Dispatcher.Invoke(() =>
                    Messages.Add(String.Format("{0}: {1}\r", name, message))
                )
            );
            try
            {
                await Connection.Start();
            }
            catch (HttpRequestException)
            {
                //TODO log
                //StatusText.Content = "Unable to connect to server: Start server before connecting clients.";
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            //TODO booltoimage
            //RichTextBoxConsole.AppendText("Connected to server at " + ServerURI + "\r");
        }

        void Connection_Closed()
        {
            //Hide chat UI; show login UI
            var dispatcher = App.Current.Dispatcher;
        }

        private void WPFClient_Closing(string o)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
            }
        }


        public void WriteToConsole(String message)
        {
            Messages.Add(message);
        }


        private async void UploadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.DefaultExt = "*.png";
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                //TODO

            }
        }

    }

    public class NewWorkData : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { Set(ref time, value); }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { Set(ref address, value); }
        }

        private int techID;
        public int TechID
        {
            get { return techID; }
            set { Set(ref techID, value); }
        }

        private string techName;
        public string TechName
        {
            get { return techName; }
            set { Set(ref techName, value); }
        }

        private bool visibility;
        public bool Visibility
        {
            get { return visibility; }
            set { Set(ref visibility, value); }
        }

        public void Reset()
        {
            Address = TechName = Name = string.Empty;
            Visibility = false;
        }





    }
 
}
