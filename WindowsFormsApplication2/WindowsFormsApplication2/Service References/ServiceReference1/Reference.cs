﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/editarUsuario", ReplyAction="*")]
        WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse editarUsuario(WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/editarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse> editarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarUsuario", ReplyAction="*")]
        WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse agregarUsuario(WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse> agregarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarUsuario", ReplyAction="*")]
        WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse eliminarUsuario(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse> eliminarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class editarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="editarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.editarUsuarioRequestBody Body;
        
        public editarUsuarioRequest() {
        }
        
        public editarUsuarioRequest(WindowsFormsApplication2.ServiceReference1.editarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class editarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string direc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string depa;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int telf;
        
        public editarUsuarioRequestBody() {
        }
        
        public editarUsuarioRequestBody(string usuario, string nom, string direc, string depa, int telf) {
            this.usuario = usuario;
            this.nom = nom;
            this.direc = direc;
            this.depa = depa;
            this.telf = telf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class editarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="editarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.editarUsuarioResponseBody Body;
        
        public editarUsuarioResponse() {
        }
        
        public editarUsuarioResponse(WindowsFormsApplication2.ServiceReference1.editarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class editarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int editarUsuarioResult;
        
        public editarUsuarioResponseBody() {
        }
        
        public editarUsuarioResponseBody(int editarUsuarioResult) {
            this.editarUsuarioResult = editarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class agregarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="agregarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequestBody Body;
        
        public agregarUsuarioRequest() {
        }
        
        public agregarUsuarioRequest(WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class agregarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contra;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string rol;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int ci;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string direc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string depa;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int telf;
        
        public agregarUsuarioRequestBody() {
        }
        
        public agregarUsuarioRequestBody(string usuario, string contra, string rol, int ci, string nom, string direc, string depa, int telf) {
            this.usuario = usuario;
            this.contra = contra;
            this.rol = rol;
            this.ci = ci;
            this.nom = nom;
            this.direc = direc;
            this.depa = depa;
            this.telf = telf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class agregarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="agregarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponseBody Body;
        
        public agregarUsuarioResponse() {
        }
        
        public agregarUsuarioResponse(WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class agregarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int agregarUsuarioResult;
        
        public agregarUsuarioResponseBody() {
        }
        
        public agregarUsuarioResponseBody(int agregarUsuarioResult) {
            this.agregarUsuarioResult = agregarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequestBody Body;
        
        public eliminarUsuarioRequest() {
        }
        
        public eliminarUsuarioRequest(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string contra;
        
        public eliminarUsuarioRequestBody() {
        }
        
        public eliminarUsuarioRequestBody(int id, string usuario, string contra) {
            this.id = id;
            this.usuario = usuario;
            this.contra = contra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponseBody Body;
        
        public eliminarUsuarioResponse() {
        }
        
        public eliminarUsuarioResponse(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int eliminarUsuarioResult;
        
        public eliminarUsuarioResponseBody() {
        }
        
        public eliminarUsuarioResponseBody(int eliminarUsuarioResult) {
            this.eliminarUsuarioResult = eliminarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowsFormsApplication2.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication2.ServiceReference1.WebServiceSoap>, WindowsFormsApplication2.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse WindowsFormsApplication2.ServiceReference1.WebServiceSoap.editarUsuario(WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest request) {
            return base.Channel.editarUsuario(request);
        }
        
        public int editarUsuario(string usuario, string nom, string direc, string depa, int telf) {
            WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.editarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.nom = nom;
            inValue.Body.direc = direc;
            inValue.Body.depa = depa;
            inValue.Body.telf = telf;
            WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse retVal = ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).editarUsuario(inValue);
            return retVal.Body.editarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse> WindowsFormsApplication2.ServiceReference1.WebServiceSoap.editarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest request) {
            return base.Channel.editarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.editarUsuarioResponse> editarUsuarioAsync(string usuario, string nom, string direc, string depa, int telf) {
            WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.editarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.editarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.nom = nom;
            inValue.Body.direc = direc;
            inValue.Body.depa = depa;
            inValue.Body.telf = telf;
            return ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).editarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse WindowsFormsApplication2.ServiceReference1.WebServiceSoap.agregarUsuario(WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest request) {
            return base.Channel.agregarUsuario(request);
        }
        
        public int agregarUsuario(string usuario, string contra, string rol, int ci, string nom, string direc, string depa, int telf) {
            WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.rol = rol;
            inValue.Body.ci = ci;
            inValue.Body.nom = nom;
            inValue.Body.direc = direc;
            inValue.Body.depa = depa;
            inValue.Body.telf = telf;
            WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse retVal = ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).agregarUsuario(inValue);
            return retVal.Body.agregarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse> WindowsFormsApplication2.ServiceReference1.WebServiceSoap.agregarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest request) {
            return base.Channel.agregarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.agregarUsuarioResponse> agregarUsuarioAsync(string usuario, string contra, string rol, int ci, string nom, string direc, string depa, int telf) {
            WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.agregarUsuarioRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            inValue.Body.rol = rol;
            inValue.Body.ci = ci;
            inValue.Body.nom = nom;
            inValue.Body.direc = direc;
            inValue.Body.depa = depa;
            inValue.Body.telf = telf;
            return ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).agregarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse WindowsFormsApplication2.ServiceReference1.WebServiceSoap.eliminarUsuario(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuario(request);
        }
        
        public int eliminarUsuario(int id, string usuario, string contra) {
            WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequestBody();
            inValue.Body.id = id;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse retVal = ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).eliminarUsuario(inValue);
            return retVal.Body.eliminarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse> WindowsFormsApplication2.ServiceReference1.WebServiceSoap.eliminarUsuarioAsync(WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication2.ServiceReference1.eliminarUsuarioResponse> eliminarUsuarioAsync(int id, string usuario, string contra) {
            WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest inValue = new WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequest();
            inValue.Body = new WindowsFormsApplication2.ServiceReference1.eliminarUsuarioRequestBody();
            inValue.Body.id = id;
            inValue.Body.usuario = usuario;
            inValue.Body.contra = contra;
            return ((WindowsFormsApplication2.ServiceReference1.WebServiceSoap)(this)).eliminarUsuarioAsync(inValue);
        }
    }
}
