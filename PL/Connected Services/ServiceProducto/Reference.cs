﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.ServiceProducto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SL_WCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Producto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Exception))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ObjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] ObjectsField;
        
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
        public bool Correct {
            get {
                return this.CorrectField;
            }
            set {
                if ((this.CorrectField.Equals(value) != true)) {
                    this.CorrectField = value;
                    this.RaisePropertyChanged("Correct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Ex {
            get {
                return this.ExField;
            }
            set {
                if ((object.ReferenceEquals(this.ExField, value) != true)) {
                    this.ExField = value;
                    this.RaisePropertyChanged("Ex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Object {
            get {
                return this.ObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectField, value) != true)) {
                    this.ObjectField = value;
                    this.RaisePropertyChanged("Object");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Objects {
            get {
                return this.ObjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsField, value) != true)) {
                    this.ObjectsField = value;
                    this.RaisePropertyChanged("Objects");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceProducto.IProducto")]
    public interface IProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoAdd", ReplyAction="http://tempuri.org/IProducto/ProductoAddResponse")]
        PL.ServiceProducto.Result ProductoAdd(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoAdd", ReplyAction="http://tempuri.org/IProducto/ProductoAddResponse")]
        System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoAddAsync(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoUpdate", ReplyAction="http://tempuri.org/IProducto/ProductoUpdateResponse")]
        PL.ServiceProducto.Result ProductoUpdate(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoUpdate", ReplyAction="http://tempuri.org/IProducto/ProductoUpdateResponse")]
        System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoUpdateAsync(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoDelete", ReplyAction="http://tempuri.org/IProducto/ProductoDeleteResponse")]
        PL.ServiceProducto.Result ProductoDelete(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoDelete", ReplyAction="http://tempuri.org/IProducto/ProductoDeleteResponse")]
        System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoDeleteAsync(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoGetAll", ReplyAction="http://tempuri.org/IProducto/ProductoGetAllResponse")]
        PL.ServiceProducto.Result ProductoGetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoGetAll", ReplyAction="http://tempuri.org/IProducto/ProductoGetAllResponse")]
        System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoGetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoGetById", ReplyAction="http://tempuri.org/IProducto/ProductoGetByIdResponse")]
        PL.ServiceProducto.Result ProductoGetById(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducto/ProductoGetById", ReplyAction="http://tempuri.org/IProducto/ProductoGetByIdResponse")]
        System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoGetByIdAsync(int IdProducto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductoChannel : PL.ServiceProducto.IProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoClient : System.ServiceModel.ClientBase<PL.ServiceProducto.IProducto>, PL.ServiceProducto.IProducto {
        
        public ProductoClient() {
        }
        
        public ProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL.ServiceProducto.Result ProductoAdd(ML.Producto producto) {
            return base.Channel.ProductoAdd(producto);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoAddAsync(ML.Producto producto) {
            return base.Channel.ProductoAddAsync(producto);
        }
        
        public PL.ServiceProducto.Result ProductoUpdate(ML.Producto producto) {
            return base.Channel.ProductoUpdate(producto);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoUpdateAsync(ML.Producto producto) {
            return base.Channel.ProductoUpdateAsync(producto);
        }
        
        public PL.ServiceProducto.Result ProductoDelete(int IdProducto) {
            return base.Channel.ProductoDelete(IdProducto);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoDeleteAsync(int IdProducto) {
            return base.Channel.ProductoDeleteAsync(IdProducto);
        }
        
        public PL.ServiceProducto.Result ProductoGetAll() {
            return base.Channel.ProductoGetAll();
        }
        
        public System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoGetAllAsync() {
            return base.Channel.ProductoGetAllAsync();
        }
        
        public PL.ServiceProducto.Result ProductoGetById(int IdProducto) {
            return base.Channel.ProductoGetById(IdProducto);
        }
        
        public System.Threading.Tasks.Task<PL.ServiceProducto.Result> ProductoGetByIdAsync(int IdProducto) {
            return base.Channel.ProductoGetByIdAsync(IdProducto);
        }
    }
}
