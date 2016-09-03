﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchProject.Chatservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Chatservice.IChat", CallbackContract=typeof(SchProject.Chatservice.IChatCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/Connect")]
        void Connect(string client);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/Connect")]
        System.Threading.Tasks.Task ConnectAsync(string client);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, Action="http://tempuri.org/IChat/Disconnect")]
        void Disconnect(string client);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, Action="http://tempuri.org/IChat/Disconnect")]
        System.Threading.Tasks.Task DisconnectAsync(string client);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/SendFile")]
        void SendFile(byte[] content, string description, string receiverName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/SendFile")]
        System.Threading.Tasks.Task SendFileAsync(byte[] content, string description, string receiverName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/SendMessage")]
        void SendMessage(string message, string receiverName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string message, string receiverName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/IsAnyWorker", ReplyAction="http://tempuri.org/IChat/IsAnyWorkerResponse")]
        bool IsAnyWorker();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/IsAnyWorker", ReplyAction="http://tempuri.org/IChat/IsAnyWorkerResponse")]
        System.Threading.Tasks.Task<bool> IsAnyWorkerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/AddWorker", ReplyAction="http://tempuri.org/IChat/AddWorkerResponse")]
        void AddWorker(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/AddWorker", ReplyAction="http://tempuri.org/IChat/AddWorkerResponse")]
        System.Threading.Tasks.Task AddWorkerAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RemoveWorker", ReplyAction="http://tempuri.org/IChat/RemoveWorkerResponse")]
        void RemoveWorker(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RemoveWorker", ReplyAction="http://tempuri.org/IChat/RemoveWorkerResponse")]
        System.Threading.Tasks.Task RemoveWorkerAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/ReceiveMessageCallback")]
        void ReceiveMessageCallback(string message, string receiver);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/ReceiveFileMessageeCallback")]
        void ReceiveFileMessageeCallback(byte[] fileMessage, string description);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChat/ClientConnectCallback")]
        void ClientConnectCallback(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : SchProject.Chatservice.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<SchProject.Chatservice.IChat>, SchProject.Chatservice.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Connect(string client) {
            base.Channel.Connect(client);
        }
        
        public System.Threading.Tasks.Task ConnectAsync(string client) {
            return base.Channel.ConnectAsync(client);
        }
        
        public void Disconnect(string client) {
            base.Channel.Disconnect(client);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(string client) {
            return base.Channel.DisconnectAsync(client);
        }
        
        public void SendFile(byte[] content, string description, string receiverName) {
            base.Channel.SendFile(content, description, receiverName);
        }
        
        public System.Threading.Tasks.Task SendFileAsync(byte[] content, string description, string receiverName) {
            return base.Channel.SendFileAsync(content, description, receiverName);
        }
        
        public void SendMessage(string message, string receiverName) {
            base.Channel.SendMessage(message, receiverName);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message, string receiverName) {
            return base.Channel.SendMessageAsync(message, receiverName);
        }
        
        public bool IsAnyWorker() {
            return base.Channel.IsAnyWorker();
        }
        
        public System.Threading.Tasks.Task<bool> IsAnyWorkerAsync() {
            return base.Channel.IsAnyWorkerAsync();
        }
        
        public void AddWorker(string name) {
            base.Channel.AddWorker(name);
        }
        
        public System.Threading.Tasks.Task AddWorkerAsync(string name) {
            return base.Channel.AddWorkerAsync(name);
        }
        
        public void RemoveWorker(string name) {
            base.Channel.RemoveWorker(name);
        }
        
        public System.Threading.Tasks.Task RemoveWorkerAsync(string name) {
            return base.Channel.RemoveWorkerAsync(name);
        }
    }
}
