﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.Client.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ToDoItem", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ToDoItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IToDo")]
    public interface IToDo {
        
        // CODEGEN: Generating message contract since element name GetToDosResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/GetToDos", ReplyAction="http://tempuri.org/IToDo/GetToDosResponse")]
        UI.Client.ServiceReference.GetToDosResponse GetToDos(UI.Client.ServiceReference.GetToDosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/GetToDos", ReplyAction="http://tempuri.org/IToDo/GetToDosResponse")]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.GetToDosResponse> GetToDosAsync(UI.Client.ServiceReference.GetToDosRequest request);
        
        // CODEGEN: Generating message contract since element name toDoItem from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/AddOrUpdateToDo", ReplyAction="http://tempuri.org/IToDo/AddOrUpdateToDoResponse")]
        UI.Client.ServiceReference.AddOrUpdateToDoResponse AddOrUpdateToDo(UI.Client.ServiceReference.AddOrUpdateToDoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/AddOrUpdateToDo", ReplyAction="http://tempuri.org/IToDo/AddOrUpdateToDoResponse")]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.AddOrUpdateToDoResponse> AddOrUpdateToDoAsync(UI.Client.ServiceReference.AddOrUpdateToDoRequest request);
        
        // CODEGEN: Generating message contract since element name toDoItem from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/DeleteToDo", ReplyAction="http://tempuri.org/IToDo/DeleteToDoResponse")]
        UI.Client.ServiceReference.DeleteToDoResponse DeleteToDo(UI.Client.ServiceReference.DeleteToDoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDo/DeleteToDo", ReplyAction="http://tempuri.org/IToDo/DeleteToDoResponse")]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.DeleteToDoResponse> DeleteToDoAsync(UI.Client.ServiceReference.DeleteToDoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetToDosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetToDos", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.GetToDosRequestBody Body;
        
        public GetToDosRequest() {
        }
        
        public GetToDosRequest(UI.Client.ServiceReference.GetToDosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetToDosRequestBody {
        
        public GetToDosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetToDosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetToDosResponse", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.GetToDosResponseBody Body;
        
        public GetToDosResponse() {
        }
        
        public GetToDosResponse(UI.Client.ServiceReference.GetToDosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetToDosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UI.Client.ServiceReference.ToDoItem[] GetToDosResult;
        
        public GetToDosResponseBody() {
        }
        
        public GetToDosResponseBody(UI.Client.ServiceReference.ToDoItem[] GetToDosResult) {
            this.GetToDosResult = GetToDosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddOrUpdateToDoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddOrUpdateToDo", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.AddOrUpdateToDoRequestBody Body;
        
        public AddOrUpdateToDoRequest() {
        }
        
        public AddOrUpdateToDoRequest(UI.Client.ServiceReference.AddOrUpdateToDoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddOrUpdateToDoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UI.Client.ServiceReference.ToDoItem toDoItem;
        
        public AddOrUpdateToDoRequestBody() {
        }
        
        public AddOrUpdateToDoRequestBody(UI.Client.ServiceReference.ToDoItem toDoItem) {
            this.toDoItem = toDoItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddOrUpdateToDoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddOrUpdateToDoResponse", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.AddOrUpdateToDoResponseBody Body;
        
        public AddOrUpdateToDoResponse() {
        }
        
        public AddOrUpdateToDoResponse(UI.Client.ServiceReference.AddOrUpdateToDoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddOrUpdateToDoResponseBody {
        
        public AddOrUpdateToDoResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteToDoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteToDo", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.DeleteToDoRequestBody Body;
        
        public DeleteToDoRequest() {
        }
        
        public DeleteToDoRequest(UI.Client.ServiceReference.DeleteToDoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteToDoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public UI.Client.ServiceReference.ToDoItem toDoItem;
        
        public DeleteToDoRequestBody() {
        }
        
        public DeleteToDoRequestBody(UI.Client.ServiceReference.ToDoItem toDoItem) {
            this.toDoItem = toDoItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteToDoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteToDoResponse", Namespace="http://tempuri.org/", Order=0)]
        public UI.Client.ServiceReference.DeleteToDoResponseBody Body;
        
        public DeleteToDoResponse() {
        }
        
        public DeleteToDoResponse(UI.Client.ServiceReference.DeleteToDoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class DeleteToDoResponseBody {
        
        public DeleteToDoResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToDoChannel : UI.Client.ServiceReference.IToDo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToDoClient : System.ServiceModel.ClientBase<UI.Client.ServiceReference.IToDo>, UI.Client.ServiceReference.IToDo {
        
        public ToDoClient() {
        }
        
        public ToDoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToDoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToDoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToDoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.Client.ServiceReference.GetToDosResponse UI.Client.ServiceReference.IToDo.GetToDos(UI.Client.ServiceReference.GetToDosRequest request) {
            return base.Channel.GetToDos(request);
        }
        
        public UI.Client.ServiceReference.ToDoItem[] GetToDos() {
            UI.Client.ServiceReference.GetToDosRequest inValue = new UI.Client.ServiceReference.GetToDosRequest();
            inValue.Body = new UI.Client.ServiceReference.GetToDosRequestBody();
            UI.Client.ServiceReference.GetToDosResponse retVal = ((UI.Client.ServiceReference.IToDo)(this)).GetToDos(inValue);
            return retVal.Body.GetToDosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.GetToDosResponse> UI.Client.ServiceReference.IToDo.GetToDosAsync(UI.Client.ServiceReference.GetToDosRequest request) {
            return base.Channel.GetToDosAsync(request);
        }
        
        public System.Threading.Tasks.Task<UI.Client.ServiceReference.GetToDosResponse> GetToDosAsync() {
            UI.Client.ServiceReference.GetToDosRequest inValue = new UI.Client.ServiceReference.GetToDosRequest();
            inValue.Body = new UI.Client.ServiceReference.GetToDosRequestBody();
            return ((UI.Client.ServiceReference.IToDo)(this)).GetToDosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.Client.ServiceReference.AddOrUpdateToDoResponse UI.Client.ServiceReference.IToDo.AddOrUpdateToDo(UI.Client.ServiceReference.AddOrUpdateToDoRequest request) {
            return base.Channel.AddOrUpdateToDo(request);
        }
        
        public void AddOrUpdateToDo(UI.Client.ServiceReference.ToDoItem toDoItem) {
            UI.Client.ServiceReference.AddOrUpdateToDoRequest inValue = new UI.Client.ServiceReference.AddOrUpdateToDoRequest();
            inValue.Body = new UI.Client.ServiceReference.AddOrUpdateToDoRequestBody();
            inValue.Body.toDoItem = toDoItem;
            UI.Client.ServiceReference.AddOrUpdateToDoResponse retVal = ((UI.Client.ServiceReference.IToDo)(this)).AddOrUpdateToDo(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.AddOrUpdateToDoResponse> UI.Client.ServiceReference.IToDo.AddOrUpdateToDoAsync(UI.Client.ServiceReference.AddOrUpdateToDoRequest request) {
            return base.Channel.AddOrUpdateToDoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UI.Client.ServiceReference.AddOrUpdateToDoResponse> AddOrUpdateToDoAsync(UI.Client.ServiceReference.ToDoItem toDoItem) {
            UI.Client.ServiceReference.AddOrUpdateToDoRequest inValue = new UI.Client.ServiceReference.AddOrUpdateToDoRequest();
            inValue.Body = new UI.Client.ServiceReference.AddOrUpdateToDoRequestBody();
            inValue.Body.toDoItem = toDoItem;
            return ((UI.Client.ServiceReference.IToDo)(this)).AddOrUpdateToDoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.Client.ServiceReference.DeleteToDoResponse UI.Client.ServiceReference.IToDo.DeleteToDo(UI.Client.ServiceReference.DeleteToDoRequest request) {
            return base.Channel.DeleteToDo(request);
        }
        
        public void DeleteToDo(UI.Client.ServiceReference.ToDoItem toDoItem) {
            UI.Client.ServiceReference.DeleteToDoRequest inValue = new UI.Client.ServiceReference.DeleteToDoRequest();
            inValue.Body = new UI.Client.ServiceReference.DeleteToDoRequestBody();
            inValue.Body.toDoItem = toDoItem;
            UI.Client.ServiceReference.DeleteToDoResponse retVal = ((UI.Client.ServiceReference.IToDo)(this)).DeleteToDo(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UI.Client.ServiceReference.DeleteToDoResponse> UI.Client.ServiceReference.IToDo.DeleteToDoAsync(UI.Client.ServiceReference.DeleteToDoRequest request) {
            return base.Channel.DeleteToDoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UI.Client.ServiceReference.DeleteToDoResponse> DeleteToDoAsync(UI.Client.ServiceReference.ToDoItem toDoItem) {
            UI.Client.ServiceReference.DeleteToDoRequest inValue = new UI.Client.ServiceReference.DeleteToDoRequest();
            inValue.Body = new UI.Client.ServiceReference.DeleteToDoRequestBody();
            inValue.Body.toDoItem = toDoItem;
            return ((UI.Client.ServiceReference.IToDo)(this)).DeleteToDoAsync(inValue);
        }
    }
}
