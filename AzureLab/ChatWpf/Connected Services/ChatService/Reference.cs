﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace ChatWpf.Connected_Services.ChatService {
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="ChatMessage", Namespace="http://schemas.datacontract.org/2004/07/ChatService.Models")]
    [Serializable()]
    public partial class ChatMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [NonSerialized()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [OptionalField()]
        private string MessageField;
        
        [OptionalField()]
        private string SenderField;
        
        [OptionalField()]
        private System.DateTime TimeStampField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [DataMember()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [DataMember()]
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
        
        [DataMember()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatService.IChatService")]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SendMessage", ReplyAction="http://tempuri.org/IChatService/SendMessageResponse")]
        void SendMessage(ChatMessage chatMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/SendMessage", ReplyAction="http://tempuri.org/IChatService/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(ChatMessage chatMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/ClearMessages", ReplyAction="http://tempuri.org/IChatService/ClearMessagesResponse")]
        void ClearMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/ClearMessages", ReplyAction="http://tempuri.org/IChatService/ClearMessagesResponse")]
        System.Threading.Tasks.Task ClearMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetAllMessages", ReplyAction="http://tempuri.org/IChatService/GetAllMessagesResponse")]
        ChatMessage[] GetAllMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetAllMessages", ReplyAction="http://tempuri.org/IChatService/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<ChatMessage[]> GetAllMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceChannel : IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.ClientBase<IChatService>, IChatService {
        
        public ChatServiceClient() {
        }
        
        public ChatServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendMessage(ChatMessage chatMessage) {
            base.Channel.SendMessage(chatMessage);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(ChatMessage chatMessage) {
            return base.Channel.SendMessageAsync(chatMessage);
        }
        
        public void ClearMessages() {
            base.Channel.ClearMessages();
        }
        
        public System.Threading.Tasks.Task ClearMessagesAsync() {
            return base.Channel.ClearMessagesAsync();
        }
        
        public ChatMessage[] GetAllMessages() {
            return base.Channel.GetAllMessages();
        }
        
        public System.Threading.Tasks.Task<ChatMessage[]> GetAllMessagesAsync() {
            return base.Channel.GetAllMessagesAsync();
        }
    }
}