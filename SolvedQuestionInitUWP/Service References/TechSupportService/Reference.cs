﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace SolvedQuestionInit.TechSupportService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginResult", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService")]
    public partial class LoginResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string FullNameField;
        
        private SolvedQuestionInit.TechSupportService.Role RoleField;
        
        private bool ValidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SolvedQuestionInit.TechSupportService.Role Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Valid {
            get {
                return this.ValidField;
            }
            set {
                if ((this.ValidField.Equals(value) != true)) {
                    this.ValidField = value;
                    this.RaisePropertyChanged("Valid");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService.DataContract")]
    public enum Role : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HelpDesk = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Admin = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Technician = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Boss = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WorkerData", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService")]
    public partial class WorkerData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AddressField;
        
        private string EmailField;
        
        private string FullNameField;
        
        private int IDField;
        
        private string PhoneField;
        
        private string ProfilePictureField;
        
        private SolvedQuestionInit.TechSupportService.Role RoleField;
        
        private SolvedQuestionInit.TechSupportService.Status StatusField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfilePicture {
            get {
                return this.ProfilePictureField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfilePictureField, value) != true)) {
                    this.ProfilePictureField = value;
                    this.RaisePropertyChanged("ProfilePicture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SolvedQuestionInit.TechSupportService.Role Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SolvedQuestionInit.TechSupportService.Status Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Away = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Working = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerData", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService.DataContract")]
    public partial class CustomerData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string EmailField;
        
        private string FullNameField;
        
        private int IDField;
        
        private string PhoneField;
        
        private string PictureField;
        
        private int PointsField;
        
        private System.DateTime RegTimeField;
        
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Points {
            get {
                return this.PointsField;
            }
            set {
                if ((this.PointsField.Equals(value) != true)) {
                    this.PointsField = value;
                    this.RaisePropertyChanged("Points");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RegTime {
            get {
                return this.RegTimeField;
            }
            set {
                if ((this.RegTimeField.Equals(value) != true)) {
                    this.RegTimeField = value;
                    this.RaisePropertyChanged("RegTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NewTechWork", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService.DataContract")]
    public partial class NewTechWork : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AddressField;
        
        private string CustomerNameField;
        
        private int IDField;
        
        private int TechIDField;
        
        private System.DateTime TimeOrderedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TechID {
            get {
                return this.TechIDField;
            }
            set {
                if ((this.TechIDField.Equals(value) != true)) {
                    this.TechIDField = value;
                    this.RaisePropertyChanged("TechID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeOrdered {
            get {
                return this.TimeOrderedField;
            }
            set {
                if ((this.TimeOrderedField.Equals(value) != true)) {
                    this.TimeOrderedField = value;
                    this.RaisePropertyChanged("TimeOrdered");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SolvedQuestion", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService")]
    public partial class SolvedQuestion : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AnswerField;
        
        private string CategoryField;
        
        private int CustomerIDField;
        
        private int IDField;
        
        private System.Collections.ObjectModel.ObservableCollection<string> KeyWordsField;
        
        private string QuestionField;
        
        private System.DateTime TimeAnsweredField;
        
        private System.DateTime TimeAskedField;
        
        private string TopicField;
        
        private int WorkerIDField;
        
        private string WorkerNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<string> KeyWords {
            get {
                return this.KeyWordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyWordsField, value) != true)) {
                    this.KeyWordsField = value;
                    this.RaisePropertyChanged("KeyWords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeAnswered {
            get {
                return this.TimeAnsweredField;
            }
            set {
                if ((this.TimeAnsweredField.Equals(value) != true)) {
                    this.TimeAnsweredField = value;
                    this.RaisePropertyChanged("TimeAnswered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeAsked {
            get {
                return this.TimeAskedField;
            }
            set {
                if ((this.TimeAskedField.Equals(value) != true)) {
                    this.TimeAskedField = value;
                    this.RaisePropertyChanged("TimeAsked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Topic {
            get {
                return this.TopicField;
            }
            set {
                if ((object.ReferenceEquals(this.TopicField, value) != true)) {
                    this.TopicField = value;
                    this.RaisePropertyChanged("Topic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WorkerID {
            get {
                return this.WorkerIDField;
            }
            set {
                if ((this.WorkerIDField.Equals(value) != true)) {
                    this.WorkerIDField = value;
                    this.RaisePropertyChanged("WorkerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkerName {
            get {
                return this.WorkerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkerNameField, value) != true)) {
                    this.WorkerNameField = value;
                    this.RaisePropertyChanged("WorkerName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService.DataContract")]
    public partial class Message : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string MessagField;
        
        private string SenderField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Messag {
            get {
                return this.MessagField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagField, value) != true)) {
                    this.MessagField = value;
                    this.RaisePropertyChanged("Messag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TechnicianStatus", Namespace="http://schemas.datacontract.org/2004/07/TechSupportService.DataContract")]
    public enum TechnicianStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FromCustomer = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AtCustomer = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Break = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Available = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TechSupportService.ITechSupportService1")]
    public interface ITechSupportService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/TechnicianLogin", ReplyAction="http://tempuri.org/ITechSupportService1/TechnicianLoginResponse")]
        System.Threading.Tasks.Task<SolvedQuestionInit.TechSupportService.LoginResult> TechnicianLoginAsync(string username, string passWD);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/HelpDeskWorkerList", ReplyAction="http://tempuri.org/ITechSupportService1/HelpDeskWorkerListResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.WorkerData>> HelpDeskWorkerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/CustomerList", ReplyAction="http://tempuri.org/ITechSupportService1/CustomerListResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.CustomerData>> CustomerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/GetMyNewTechworks", ReplyAction="http://tempuri.org/ITechSupportService1/GetMyNewTechworksResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.NewTechWork>> GetMyNewTechworksAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/UploadSolvedQuestion", ReplyAction="http://tempuri.org/ITechSupportService1/UploadSolvedQuestionResponse")]
        System.Threading.Tasks.Task UploadSolvedQuestionAsync(SolvedQuestionInit.TechSupportService.SolvedQuestion question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/UserLogin", ReplyAction="http://tempuri.org/ITechSupportService1/UserLoginResponse")]
        System.Threading.Tasks.Task<bool> UserLoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/GetProfilePicture", ReplyAction="http://tempuri.org/ITechSupportService1/GetProfilePictureResponse")]
        System.Threading.Tasks.Task<string> GetProfilePictureAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/GetUserProfilePicture", ReplyAction="http://tempuri.org/ITechSupportService1/GetUserProfilePictureResponse")]
        System.Threading.Tasks.Task<string> GetUserProfilePictureAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITechSupportService1/RegisterNewUser")]
        System.Threading.Tasks.Task RegisterNewUserAsync(string fullName, string email, string userName, string password, string profilePicture);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITechSupportService1/SendMessageToSupport")]
        System.Threading.Tasks.Task SendMessageToSupportAsync(string username, string sender, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITechSupportService1/GetMyMessages", ReplyAction="http://tempuri.org/ITechSupportService1/GetMyMessagesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.Message>> GetMyMessagesAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITechSupportService1/Logout")]
        System.Threading.Tasks.Task LogoutAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITechSupportService1/ChangeMyStatus")]
        System.Threading.Tasks.Task ChangeMyStatusAsync(string username, SolvedQuestionInit.TechSupportService.Status newStatus);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITechSupportService1/ChangeMyTechnicianStatus")]
        System.Threading.Tasks.Task ChangeMyTechnicianStatusAsync(string username, SolvedQuestionInit.TechSupportService.TechnicianStatus status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITechSupportService1Channel : SolvedQuestionInit.TechSupportService.ITechSupportService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TechSupportService1Client : System.ServiceModel.ClientBase<SolvedQuestionInit.TechSupportService.ITechSupportService1>, SolvedQuestionInit.TechSupportService.ITechSupportService1 {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TechSupportService1Client() : 
                base(TechSupportService1Client.GetDefaultBinding(), TechSupportService1Client.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpsBinding_ITechSupportService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TechSupportService1Client(EndpointConfiguration endpointConfiguration) : 
                base(TechSupportService1Client.GetBindingForEndpoint(endpointConfiguration), TechSupportService1Client.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TechSupportService1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TechSupportService1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TechSupportService1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TechSupportService1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TechSupportService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<SolvedQuestionInit.TechSupportService.LoginResult> TechnicianLoginAsync(string username, string passWD) {
            return base.Channel.TechnicianLoginAsync(username, passWD);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.WorkerData>> HelpDeskWorkerListAsync() {
            return base.Channel.HelpDeskWorkerListAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.CustomerData>> CustomerListAsync() {
            return base.Channel.CustomerListAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.NewTechWork>> GetMyNewTechworksAsync(string username) {
            return base.Channel.GetMyNewTechworksAsync(username);
        }
        
        public System.Threading.Tasks.Task UploadSolvedQuestionAsync(SolvedQuestionInit.TechSupportService.SolvedQuestion question) {
            return base.Channel.UploadSolvedQuestionAsync(question);
        }
        
        public System.Threading.Tasks.Task<bool> UserLoginAsync(string username, string password) {
            return base.Channel.UserLoginAsync(username, password);
        }
        
        public System.Threading.Tasks.Task<string> GetProfilePictureAsync(string username) {
            return base.Channel.GetProfilePictureAsync(username);
        }
        
        public System.Threading.Tasks.Task<string> GetUserProfilePictureAsync(string username) {
            return base.Channel.GetUserProfilePictureAsync(username);
        }
        
        public System.Threading.Tasks.Task RegisterNewUserAsync(string fullName, string email, string userName, string password, string profilePicture) {
            return base.Channel.RegisterNewUserAsync(fullName, email, userName, password, profilePicture);
        }
        
        public System.Threading.Tasks.Task SendMessageToSupportAsync(string username, string sender, string message) {
            return base.Channel.SendMessageToSupportAsync(username, sender, message);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SolvedQuestionInit.TechSupportService.Message>> GetMyMessagesAsync(string username) {
            return base.Channel.GetMyMessagesAsync(username);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string username) {
            return base.Channel.LogoutAsync(username);
        }
        
        public System.Threading.Tasks.Task ChangeMyStatusAsync(string username, SolvedQuestionInit.TechSupportService.Status newStatus) {
            return base.Channel.ChangeMyStatusAsync(username, newStatus);
        }
        
        public System.Threading.Tasks.Task ChangeMyTechnicianStatusAsync(string username, SolvedQuestionInit.TechSupportService.TechnicianStatus status) {
            return base.Channel.ChangeMyTechnicianStatusAsync(username, status);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ITechSupportService1)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ITechSupportService1)) {
                return new System.ServiceModel.EndpointAddress("https://techsupportserver.azurewebsites.net/TechSupportService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return TechSupportService1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpsBinding_ITechSupportService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return TechSupportService1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpsBinding_ITechSupportService1);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpsBinding_ITechSupportService1,
        }
    }
}
