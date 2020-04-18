﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomepageApp.WebServiceClientERP1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceClientERP1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name initials from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        HomepageApp.WebServiceClientERP1.CreateResponse Create(HomepageApp.WebServiceClientERP1.CreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Create", ReplyAction="*")]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.CreateResponse> CreateAsync(HomepageApp.WebServiceClientERP1.CreateRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        HomepageApp.WebServiceClientERP1.UpdateResponse Update(HomepageApp.WebServiceClientERP1.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.UpdateResponse> UpdateAsync(HomepageApp.WebServiceClientERP1.UpdateRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        HomepageApp.WebServiceClientERP1.DeleteResponse Delete(HomepageApp.WebServiceClientERP1.DeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.DeleteResponse> DeleteAsync(HomepageApp.WebServiceClientERP1.DeleteRequest request);
        
        // CODEGEN: Generating message contract since element name ReadResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Read", ReplyAction="*")]
        HomepageApp.WebServiceClientERP1.ReadResponse Read(HomepageApp.WebServiceClientERP1.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Read", ReplyAction="*")]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.ReadResponse> ReadAsync(HomepageApp.WebServiceClientERP1.ReadRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Find", ReplyAction="*")]
        HomepageApp.WebServiceClientERP1.FindResponse Find(HomepageApp.WebServiceClientERP1.FindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Find", ReplyAction="*")]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.FindResponse> FindAsync(HomepageApp.WebServiceClientERP1.FindRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Create", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.CreateRequestBody Body;
        
        public CreateRequest() {
        }
        
        public CreateRequest(HomepageApp.WebServiceClientERP1.CreateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string initials;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string title;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string phoneNumber;
        
        public CreateRequestBody() {
        }
        
        public CreateRequestBody(string initials, string name, string lastName, string title, string address, string phoneNumber) {
            this.initials = initials;
            this.name = name;
            this.lastName = lastName;
            this.title = title;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.CreateResponseBody Body;
        
        public CreateResponse() {
        }
        
        public CreateResponse(HomepageApp.WebServiceClientERP1.CreateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateResult;
        
        public CreateResponseBody() {
        }
        
        public CreateResponseBody(bool CreateResult) {
            this.CreateResult = CreateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(HomepageApp.WebServiceClientERP1.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string title;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string phoneNumber;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(string id, string name, string lastName, string title, string address, string phoneNumber) {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.title = title;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(HomepageApp.WebServiceClientERP1.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(bool UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.DeleteRequestBody Body;
        
        public DeleteRequest() {
        }
        
        public DeleteRequest(HomepageApp.WebServiceClientERP1.DeleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        public DeleteRequestBody() {
        }
        
        public DeleteRequestBody(string id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.DeleteResponseBody Body;
        
        public DeleteResponse() {
        }
        
        public DeleteResponse(HomepageApp.WebServiceClientERP1.DeleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool DeleteResult;
        
        public DeleteResponseBody() {
        }
        
        public DeleteResponseBody(bool DeleteResult) {
            this.DeleteResult = DeleteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Read", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.ReadRequestBody Body;
        
        public ReadRequest() {
        }
        
        public ReadRequest(HomepageApp.WebServiceClientERP1.ReadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReadRequestBody {
        
        public ReadRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.ReadResponseBody Body;
        
        public ReadResponse() {
        }
        
        public ReadResponse(HomepageApp.WebServiceClientERP1.ReadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public HomepageApp.WebServiceClientERP1.ArrayOfString[] ReadResult;
        
        public ReadResponseBody() {
        }
        
        public ReadResponseBody(HomepageApp.WebServiceClientERP1.ArrayOfString[] ReadResult) {
            this.ReadResult = ReadResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Find", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.FindRequestBody Body;
        
        public FindRequest() {
        }
        
        public FindRequest(HomepageApp.WebServiceClientERP1.FindRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        public FindRequestBody() {
        }
        
        public FindRequestBody(string id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomepageApp.WebServiceClientERP1.FindResponseBody Body;
        
        public FindResponse() {
        }
        
        public FindResponse(HomepageApp.WebServiceClientERP1.FindResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public HomepageApp.WebServiceClientERP1.ArrayOfString FindResult;
        
        public FindResponseBody() {
        }
        
        public FindResponseBody(HomepageApp.WebServiceClientERP1.ArrayOfString FindResult) {
            this.FindResult = FindResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : HomepageApp.WebServiceClientERP1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<HomepageApp.WebServiceClientERP1.WebService1Soap>, HomepageApp.WebServiceClientERP1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomepageApp.WebServiceClientERP1.CreateResponse HomepageApp.WebServiceClientERP1.WebService1Soap.Create(HomepageApp.WebServiceClientERP1.CreateRequest request) {
            return base.Channel.Create(request);
        }
        
        public bool Create(string initials, string name, string lastName, string title, string address, string phoneNumber) {
            HomepageApp.WebServiceClientERP1.CreateRequest inValue = new HomepageApp.WebServiceClientERP1.CreateRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.CreateRequestBody();
            inValue.Body.initials = initials;
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.title = title;
            inValue.Body.address = address;
            inValue.Body.phoneNumber = phoneNumber;
            HomepageApp.WebServiceClientERP1.CreateResponse retVal = ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).Create(inValue);
            return retVal.Body.CreateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.CreateResponse> HomepageApp.WebServiceClientERP1.WebService1Soap.CreateAsync(HomepageApp.WebServiceClientERP1.CreateRequest request) {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.CreateResponse> CreateAsync(string initials, string name, string lastName, string title, string address, string phoneNumber) {
            HomepageApp.WebServiceClientERP1.CreateRequest inValue = new HomepageApp.WebServiceClientERP1.CreateRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.CreateRequestBody();
            inValue.Body.initials = initials;
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.title = title;
            inValue.Body.address = address;
            inValue.Body.phoneNumber = phoneNumber;
            return ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).CreateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomepageApp.WebServiceClientERP1.UpdateResponse HomepageApp.WebServiceClientERP1.WebService1Soap.Update(HomepageApp.WebServiceClientERP1.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public bool Update(string id, string name, string lastName, string title, string address, string phoneNumber) {
            HomepageApp.WebServiceClientERP1.UpdateRequest inValue = new HomepageApp.WebServiceClientERP1.UpdateRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.UpdateRequestBody();
            inValue.Body.id = id;
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.title = title;
            inValue.Body.address = address;
            inValue.Body.phoneNumber = phoneNumber;
            HomepageApp.WebServiceClientERP1.UpdateResponse retVal = ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.UpdateResponse> HomepageApp.WebServiceClientERP1.WebService1Soap.UpdateAsync(HomepageApp.WebServiceClientERP1.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.UpdateResponse> UpdateAsync(string id, string name, string lastName, string title, string address, string phoneNumber) {
            HomepageApp.WebServiceClientERP1.UpdateRequest inValue = new HomepageApp.WebServiceClientERP1.UpdateRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.UpdateRequestBody();
            inValue.Body.id = id;
            inValue.Body.name = name;
            inValue.Body.lastName = lastName;
            inValue.Body.title = title;
            inValue.Body.address = address;
            inValue.Body.phoneNumber = phoneNumber;
            return ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).UpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomepageApp.WebServiceClientERP1.DeleteResponse HomepageApp.WebServiceClientERP1.WebService1Soap.Delete(HomepageApp.WebServiceClientERP1.DeleteRequest request) {
            return base.Channel.Delete(request);
        }
        
        public bool Delete(string id) {
            HomepageApp.WebServiceClientERP1.DeleteRequest inValue = new HomepageApp.WebServiceClientERP1.DeleteRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.DeleteRequestBody();
            inValue.Body.id = id;
            HomepageApp.WebServiceClientERP1.DeleteResponse retVal = ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).Delete(inValue);
            return retVal.Body.DeleteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.DeleteResponse> HomepageApp.WebServiceClientERP1.WebService1Soap.DeleteAsync(HomepageApp.WebServiceClientERP1.DeleteRequest request) {
            return base.Channel.DeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.DeleteResponse> DeleteAsync(string id) {
            HomepageApp.WebServiceClientERP1.DeleteRequest inValue = new HomepageApp.WebServiceClientERP1.DeleteRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.DeleteRequestBody();
            inValue.Body.id = id;
            return ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).DeleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomepageApp.WebServiceClientERP1.ReadResponse HomepageApp.WebServiceClientERP1.WebService1Soap.Read(HomepageApp.WebServiceClientERP1.ReadRequest request) {
            return base.Channel.Read(request);
        }
        
        public HomepageApp.WebServiceClientERP1.ArrayOfString[] Read() {
            HomepageApp.WebServiceClientERP1.ReadRequest inValue = new HomepageApp.WebServiceClientERP1.ReadRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.ReadRequestBody();
            HomepageApp.WebServiceClientERP1.ReadResponse retVal = ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).Read(inValue);
            return retVal.Body.ReadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.ReadResponse> HomepageApp.WebServiceClientERP1.WebService1Soap.ReadAsync(HomepageApp.WebServiceClientERP1.ReadRequest request) {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.ReadResponse> ReadAsync() {
            HomepageApp.WebServiceClientERP1.ReadRequest inValue = new HomepageApp.WebServiceClientERP1.ReadRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.ReadRequestBody();
            return ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomepageApp.WebServiceClientERP1.FindResponse HomepageApp.WebServiceClientERP1.WebService1Soap.Find(HomepageApp.WebServiceClientERP1.FindRequest request) {
            return base.Channel.Find(request);
        }
        
        public HomepageApp.WebServiceClientERP1.ArrayOfString Find(string id) {
            HomepageApp.WebServiceClientERP1.FindRequest inValue = new HomepageApp.WebServiceClientERP1.FindRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.FindRequestBody();
            inValue.Body.id = id;
            HomepageApp.WebServiceClientERP1.FindResponse retVal = ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).Find(inValue);
            return retVal.Body.FindResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.FindResponse> HomepageApp.WebServiceClientERP1.WebService1Soap.FindAsync(HomepageApp.WebServiceClientERP1.FindRequest request) {
            return base.Channel.FindAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomepageApp.WebServiceClientERP1.FindResponse> FindAsync(string id) {
            HomepageApp.WebServiceClientERP1.FindRequest inValue = new HomepageApp.WebServiceClientERP1.FindRequest();
            inValue.Body = new HomepageApp.WebServiceClientERP1.FindRequestBody();
            inValue.Body.id = id;
            return ((HomepageApp.WebServiceClientERP1.WebService1Soap)(this)).FindAsync(inValue);
        }
    }
}
