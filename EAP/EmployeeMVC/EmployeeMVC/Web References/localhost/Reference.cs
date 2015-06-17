﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.33440.
// 
#pragma warning disable 1591

namespace EmployeeMVC.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddEmployeesOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchEmployeesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmployeesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::EmployeeMVC.Properties.Settings.Default.EmployeeMVC_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddEmployeesCompletedEventHandler AddEmployeesCompleted;
        
        /// <remarks/>
        public event SearchEmployeesCompletedEventHandler SearchEmployeesCompleted;
        
        /// <remarks/>
        public event GetEmployeesCompletedEventHandler GetEmployeesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/AddEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddEmployees([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] tbEmployee e) {
            this.Invoke("AddEmployees", new object[] {
                        e});
        }
        
        /// <remarks/>
        public void AddEmployeesAsync(tbEmployee e) {
            this.AddEmployeesAsync(e, null);
        }
        
        /// <remarks/>
        public void AddEmployeesAsync(tbEmployee e, object userState) {
            if ((this.AddEmployeesOperationCompleted == null)) {
                this.AddEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddEmployeesOperationCompleted);
            }
            this.InvokeAsync("AddEmployees", new object[] {
                        e}, this.AddEmployeesOperationCompleted, userState);
        }
        
        private void OnAddEmployeesOperationCompleted(object arg) {
            if ((this.AddEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddEmployeesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SearchEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public tbEmployee SearchEmployees([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string id) {
            object[] results = this.Invoke("SearchEmployees", new object[] {
                        id});
            return ((tbEmployee)(results[0]));
        }
        
        /// <remarks/>
        public void SearchEmployeesAsync(string id) {
            this.SearchEmployeesAsync(id, null);
        }
        
        /// <remarks/>
        public void SearchEmployeesAsync(string id, object userState) {
            if ((this.SearchEmployeesOperationCompleted == null)) {
                this.SearchEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchEmployeesOperationCompleted);
            }
            this.InvokeAsync("SearchEmployees", new object[] {
                        id}, this.SearchEmployeesOperationCompleted, userState);
        }
        
        private void OnSearchEmployeesOperationCompleted(object arg) {
            if ((this.SearchEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchEmployeesCompleted(this, new SearchEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
        public tbEmployee[] GetEmployees() {
            object[] results = this.Invoke("GetEmployees", new object[0]);
            return ((tbEmployee[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmployeesAsync() {
            this.GetEmployeesAsync(null);
        }
        
        /// <remarks/>
        public void GetEmployeesAsync(object userState) {
            if ((this.GetEmployeesOperationCompleted == null)) {
                this.GetEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmployeesOperationCompleted);
            }
            this.InvokeAsync("GetEmployees", new object[0], this.GetEmployeesOperationCompleted, userState);
        }
        
        private void OnGetEmployeesOperationCompleted(object arg) {
            if ((this.GetEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmployeesCompleted(this, new GetEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class tbEmployee {
        
        private string employeeDepartmentField;
        
        private string employeeIDField;
        
        private string employeeNameField;
        
        private System.Nullable<double> employeeSalaryField;
        
        private bool employeeSalaryFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string EmployeeDepartment {
            get {
                return this.employeeDepartmentField;
            }
            set {
                this.employeeDepartmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string EmployeeID {
            get {
                return this.employeeIDField;
            }
            set {
                this.employeeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string EmployeeName {
            get {
                return this.employeeNameField;
            }
            set {
                this.employeeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> EmployeeSalary {
            get {
                return this.employeeSalaryField;
            }
            set {
                this.employeeSalaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmployeeSalarySpecified {
            get {
                return this.employeeSalaryFieldSpecified;
            }
            set {
                this.employeeSalaryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void AddEmployeesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void SearchEmployeesCompletedEventHandler(object sender, SearchEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public tbEmployee Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((tbEmployee)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetEmployeesCompletedEventHandler(object sender, GetEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public tbEmployee[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((tbEmployee[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591