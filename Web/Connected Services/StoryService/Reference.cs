﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.StoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="StoriesList", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelLists", ItemName="Story")]
    [System.SerializableAttribute()]
    public class StoriesList : System.Collections.Generic.List<Web.StoryService.Story> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Story", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class Story : Web.StoryService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.StoryService.AgeBarrier ageBarrierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.StoryService.Category categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string datePublishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageLinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.StoryService.User userField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.StoryService.AgeBarrier ageBarrier {
            get {
                return this.ageBarrierField;
            }
            set {
                if ((object.ReferenceEquals(this.ageBarrierField, value) != true)) {
                    this.ageBarrierField = value;
                    this.RaisePropertyChanged("ageBarrier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.StoryService.Category category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string datePublished {
            get {
                return this.datePublishedField;
            }
            set {
                if ((object.ReferenceEquals(this.datePublishedField, value) != true)) {
                    this.datePublishedField = value;
                    this.RaisePropertyChanged("datePublished");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imageLink {
            get {
                return this.imageLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.imageLinkField, value) != true)) {
                    this.imageLinkField = value;
                    this.RaisePropertyChanged("imageLink");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.StoryService.User user {
            get {
                return this.userField;
            }
            set {
                if ((object.ReferenceEquals(this.userField, value) != true)) {
                    this.userField = value;
                    this.RaisePropertyChanged("user");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Leaf))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.LeafType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.AgeBarrier))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Category))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Auth))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Story))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Leaf", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.AgeBarrier))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Category))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.StoryService.Auth))]
    public partial class Leaf : Web.StoryService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.StoryService.LeafType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.StoryService.LeafType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LeafType", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class LeafType : Web.StoryService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgeBarrier", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class AgeBarrier : Web.StoryService.Leaf {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class Category : Web.StoryService.Leaf {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auth", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class Auth : Web.StoryService.Leaf {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model.ModelObjects")]
    [System.SerializableAttribute()]
    public partial class User : Web.StoryService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.StoryService.Auth authField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string birthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.StoryService.Auth auth {
            get {
                return this.authField;
            }
            set {
                if ((object.ReferenceEquals(this.authField, value) != true)) {
                    this.authField = value;
                    this.RaisePropertyChanged("auth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string birthDate {
            get {
                return this.birthDateField;
            }
            set {
                if ((object.ReferenceEquals(this.birthDateField, value) != true)) {
                    this.birthDateField = value;
                    this.RaisePropertyChanged("birthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoryService.IStoryService")]
    public interface IStoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Select", ReplyAction="http://tempuri.org/IStoryService/SelectResponse")]
        Web.StoryService.StoriesList Select();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Select", ReplyAction="http://tempuri.org/IStoryService/SelectResponse")]
        System.Threading.Tasks.Task<Web.StoryService.StoriesList> SelectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Insert", ReplyAction="http://tempuri.org/IStoryService/InsertResponse")]
        int Insert(Web.StoryService.Story story);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Insert", ReplyAction="http://tempuri.org/IStoryService/InsertResponse")]
        System.Threading.Tasks.Task<int> InsertAsync(Web.StoryService.Story story);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Update", ReplyAction="http://tempuri.org/IStoryService/UpdateResponse")]
        int Update(Web.StoryService.Story story);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Update", ReplyAction="http://tempuri.org/IStoryService/UpdateResponse")]
        System.Threading.Tasks.Task<int> UpdateAsync(Web.StoryService.Story story);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Delete", ReplyAction="http://tempuri.org/IStoryService/DeleteResponse")]
        int Delete(Web.StoryService.Story story);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoryService/Delete", ReplyAction="http://tempuri.org/IStoryService/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(Web.StoryService.Story story);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStoryServiceChannel : Web.StoryService.IStoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StoryServiceClient : System.ServiceModel.ClientBase<Web.StoryService.IStoryService>, Web.StoryService.IStoryService {
        
        public StoryServiceClient() {
        }
        
        public StoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Web.StoryService.StoriesList Select() {
            return base.Channel.Select();
        }
        
        public System.Threading.Tasks.Task<Web.StoryService.StoriesList> SelectAsync() {
            return base.Channel.SelectAsync();
        }
        
        public int Insert(Web.StoryService.Story story) {
            return base.Channel.Insert(story);
        }
        
        public System.Threading.Tasks.Task<int> InsertAsync(Web.StoryService.Story story) {
            return base.Channel.InsertAsync(story);
        }
        
        public int Update(Web.StoryService.Story story) {
            return base.Channel.Update(story);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAsync(Web.StoryService.Story story) {
            return base.Channel.UpdateAsync(story);
        }
        
        public int Delete(Web.StoryService.Story story) {
            return base.Channel.Delete(story);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(Web.StoryService.Story story) {
            return base.Channel.DeleteAsync(story);
        }
    }
}
