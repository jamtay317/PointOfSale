﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointOfSale.UsersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/PointOfSale.Models")]
    [System.SerializableAttribute()]
    public partial class User : PointOfSale.UsersService.ModelBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsClockedInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeNumber {
            get {
                return this.EmployeeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNumberField, value) != true)) {
                    this.EmployeeNumberField = value;
                    this.RaisePropertyChanged("EmployeeNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsClockedIn {
            get {
                return this.IsClockedInField;
            }
            set {
                if ((this.IsClockedInField.Equals(value) != true)) {
                    this.IsClockedInField = value;
                    this.RaisePropertyChanged("IsClockedIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModelBase", Namespace="http://schemas.datacontract.org/2004/07/PointOfSale.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PointOfSale.UsersService.User))]
    public partial class ModelBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsersService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetClockedInUsers", ReplyAction="http://tempuri.org/IUserService/GetClockedInUsersResponse")]
        PointOfSale.UsersService.User[] GetClockedInUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetClockedInUsers", ReplyAction="http://tempuri.org/IUserService/GetClockedInUsersResponse")]
        System.Threading.Tasks.Task<PointOfSale.UsersService.User[]> GetClockedInUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        PointOfSale.Contracts.Users.LoginStatus Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        System.Threading.Tasks.Task<PointOfSale.Contracts.Users.LoginStatus> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ClockIn", ReplyAction="http://tempuri.org/IUserService/ClockInResponse")]
        void ClockIn(string employeeNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ClockIn", ReplyAction="http://tempuri.org/IUserService/ClockInResponse")]
        System.Threading.Tasks.Task ClockInAsync(string employeeNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ClockOut", ReplyAction="http://tempuri.org/IUserService/ClockOutResponse")]
        void ClockOut(string employeeNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ClockOut", ReplyAction="http://tempuri.org/IUserService/ClockOutResponse")]
        System.Threading.Tasks.Task ClockOutAsync(string employeeNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : PointOfSale.UsersService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<PointOfSale.UsersService.IUserService>, PointOfSale.UsersService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PointOfSale.UsersService.User[] GetClockedInUsers() {
            return base.Channel.GetClockedInUsers();
        }
        
        public System.Threading.Tasks.Task<PointOfSale.UsersService.User[]> GetClockedInUsersAsync() {
            return base.Channel.GetClockedInUsersAsync();
        }
        
        public PointOfSale.Contracts.Users.LoginStatus Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<PointOfSale.Contracts.Users.LoginStatus> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public void ClockIn(string employeeNumber) {
            base.Channel.ClockIn(employeeNumber);
        }
        
        public System.Threading.Tasks.Task ClockInAsync(string employeeNumber) {
            return base.Channel.ClockInAsync(employeeNumber);
        }
        
        public void ClockOut(string employeeNumber) {
            base.Channel.ClockOut(employeeNumber);
        }
        
        public System.Threading.Tasks.Task ClockOutAsync(string employeeNumber) {
            return base.Channel.ClockOutAsync(employeeNumber);
        }
    }
}
