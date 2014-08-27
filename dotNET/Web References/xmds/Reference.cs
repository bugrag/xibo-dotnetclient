﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace XiboClient.xmds {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="xmdsBinding", Namespace="urn:xmds")]
    public partial class xmds : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RegisterDisplayOperationCompleted;
        
        private System.Threading.SendOrPostCallback RequiredFilesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback ScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback BlackListOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubmitLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubmitStatsOperationCompleted;
        
        private System.Threading.SendOrPostCallback MediaInventoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetResourceOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public xmds() {
            this.Url = global::XiboClient.ApplicationSettings.Default.XiboClient_xmds_xmds;
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
        public event RegisterDisplayCompletedEventHandler RegisterDisplayCompleted;
        
        /// <remarks/>
        public event RequiredFilesCompletedEventHandler RequiredFilesCompleted;
        
        /// <remarks/>
        public event GetFileCompletedEventHandler GetFileCompleted;
        
        /// <remarks/>
        public event ScheduleCompletedEventHandler ScheduleCompleted;
        
        /// <remarks/>
        public event BlackListCompletedEventHandler BlackListCompleted;
        
        /// <remarks/>
        public event SubmitLogCompletedEventHandler SubmitLogCompleted;
        
        /// <remarks/>
        public event SubmitStatsCompletedEventHandler SubmitStatsCompleted;
        
        /// <remarks/>
        public event MediaInventoryCompletedEventHandler MediaInventoryCompleted;
        
        /// <remarks/>
        public event GetResourceCompletedEventHandler GetResourceCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#RegisterDisplay", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("ActivationMessage")]
        public string RegisterDisplay(string serverKey, string hardwareKey, string displayName, string clientType, string clientVersion, int clientCode, string macAddress, string version) {
            object[] results = this.Invoke("RegisterDisplay", new object[] {
                        serverKey,
                        hardwareKey,
                        displayName,
                        clientType,
                        clientVersion,
                        clientCode,
                        macAddress,
                        version});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterDisplayAsync(string serverKey, string hardwareKey, string displayName, string clientType, string clientVersion, int clientCode, string macAddress, string version) {
            this.RegisterDisplayAsync(serverKey, hardwareKey, displayName, clientType, clientVersion, clientCode, macAddress, version, null);
        }
        
        /// <remarks/>
        public void RegisterDisplayAsync(string serverKey, string hardwareKey, string displayName, string clientType, string clientVersion, int clientCode, string macAddress, string version, object userState) {
            if ((this.RegisterDisplayOperationCompleted == null)) {
                this.RegisterDisplayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterDisplayOperationCompleted);
            }
            this.InvokeAsync("RegisterDisplay", new object[] {
                        serverKey,
                        hardwareKey,
                        displayName,
                        clientType,
                        clientVersion,
                        clientCode,
                        macAddress,
                        version}, this.RegisterDisplayOperationCompleted, userState);
        }
        
        private void OnRegisterDisplayOperationCompleted(object arg) {
            if ((this.RegisterDisplayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterDisplayCompleted(this, new RegisterDisplayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#RequiredFiles", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("RequiredFilesXml")]
        public string RequiredFiles(string serverKey, string hardwareKey, string version) {
            object[] results = this.Invoke("RequiredFiles", new object[] {
                        serverKey,
                        hardwareKey,
                        version});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RequiredFilesAsync(string serverKey, string hardwareKey, string version) {
            this.RequiredFilesAsync(serverKey, hardwareKey, version, null);
        }
        
        /// <remarks/>
        public void RequiredFilesAsync(string serverKey, string hardwareKey, string version, object userState) {
            if ((this.RequiredFilesOperationCompleted == null)) {
                this.RequiredFilesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequiredFilesOperationCompleted);
            }
            this.InvokeAsync("RequiredFiles", new object[] {
                        serverKey,
                        hardwareKey,
                        version}, this.RequiredFilesOperationCompleted, userState);
        }
        
        private void OnRequiredFilesOperationCompleted(object arg) {
            if ((this.RequiredFilesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequiredFilesCompleted(this, new RequiredFilesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#GetFile", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("file", DataType="base64Binary")]
        public byte[] GetFile(string serverKey, string hardwareKey, int fileId, string fileType, int chunkOffset, int chuckSize, string version) {
            object[] results = this.Invoke("GetFile", new object[] {
                        serverKey,
                        hardwareKey,
                        fileId,
                        fileType,
                        chunkOffset,
                        chuckSize,
                        version});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFileAsync(string serverKey, string hardwareKey, int fileId, string fileType, int chunkOffset, int chuckSize, string version) {
            this.GetFileAsync(serverKey, hardwareKey, fileId, fileType, chunkOffset, chuckSize, version, null);
        }
        
        /// <remarks/>
        public void GetFileAsync(string serverKey, string hardwareKey, int fileId, string fileType, int chunkOffset, int chuckSize, string version, object userState) {
            if ((this.GetFileOperationCompleted == null)) {
                this.GetFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileOperationCompleted);
            }
            this.InvokeAsync("GetFile", new object[] {
                        serverKey,
                        hardwareKey,
                        fileId,
                        fileType,
                        chunkOffset,
                        chuckSize,
                        version}, this.GetFileOperationCompleted, userState);
        }
        
        private void OnGetFileOperationCompleted(object arg) {
            if ((this.GetFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileCompleted(this, new GetFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#Schedule", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("ScheduleXml")]
        public string Schedule(string serverKey, string hardwareKey, string version) {
            object[] results = this.Invoke("Schedule", new object[] {
                        serverKey,
                        hardwareKey,
                        version});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ScheduleAsync(string serverKey, string hardwareKey, string version) {
            this.ScheduleAsync(serverKey, hardwareKey, version, null);
        }
        
        /// <remarks/>
        public void ScheduleAsync(string serverKey, string hardwareKey, string version, object userState) {
            if ((this.ScheduleOperationCompleted == null)) {
                this.ScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnScheduleOperationCompleted);
            }
            this.InvokeAsync("Schedule", new object[] {
                        serverKey,
                        hardwareKey,
                        version}, this.ScheduleOperationCompleted, userState);
        }
        
        private void OnScheduleOperationCompleted(object arg) {
            if ((this.ScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ScheduleCompleted(this, new ScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#BlackList", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool BlackList(string serverKey, string hardwareKey, int mediaId, string type, string reason, string version) {
            object[] results = this.Invoke("BlackList", new object[] {
                        serverKey,
                        hardwareKey,
                        mediaId,
                        type,
                        reason,
                        version});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void BlackListAsync(string serverKey, string hardwareKey, int mediaId, string type, string reason, string version) {
            this.BlackListAsync(serverKey, hardwareKey, mediaId, type, reason, version, null);
        }
        
        /// <remarks/>
        public void BlackListAsync(string serverKey, string hardwareKey, int mediaId, string type, string reason, string version, object userState) {
            if ((this.BlackListOperationCompleted == null)) {
                this.BlackListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBlackListOperationCompleted);
            }
            this.InvokeAsync("BlackList", new object[] {
                        serverKey,
                        hardwareKey,
                        mediaId,
                        type,
                        reason,
                        version}, this.BlackListOperationCompleted, userState);
        }
        
        private void OnBlackListOperationCompleted(object arg) {
            if ((this.BlackListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BlackListCompleted(this, new BlackListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#SubmitLog", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool SubmitLog(string version, string serverKey, string hardwareKey, string logXml) {
            object[] results = this.Invoke("SubmitLog", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        logXml});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SubmitLogAsync(string version, string serverKey, string hardwareKey, string logXml) {
            this.SubmitLogAsync(version, serverKey, hardwareKey, logXml, null);
        }
        
        /// <remarks/>
        public void SubmitLogAsync(string version, string serverKey, string hardwareKey, string logXml, object userState) {
            if ((this.SubmitLogOperationCompleted == null)) {
                this.SubmitLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitLogOperationCompleted);
            }
            this.InvokeAsync("SubmitLog", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        logXml}, this.SubmitLogOperationCompleted, userState);
        }
        
        private void OnSubmitLogOperationCompleted(object arg) {
            if ((this.SubmitLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitLogCompleted(this, new SubmitLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#SubmitLog", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool SubmitStats(string version, string serverKey, string hardwareKey, string statXml) {
            object[] results = this.Invoke("SubmitStats", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        statXml});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SubmitStatsAsync(string version, string serverKey, string hardwareKey, string statXml) {
            this.SubmitStatsAsync(version, serverKey, hardwareKey, statXml, null);
        }
        
        /// <remarks/>
        public void SubmitStatsAsync(string version, string serverKey, string hardwareKey, string statXml, object userState) {
            if ((this.SubmitStatsOperationCompleted == null)) {
                this.SubmitStatsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitStatsOperationCompleted);
            }
            this.InvokeAsync("SubmitStats", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        statXml}, this.SubmitStatsOperationCompleted, userState);
        }
        
        private void OnSubmitStatsOperationCompleted(object arg) {
            if ((this.SubmitStatsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitStatsCompleted(this, new SubmitStatsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#MediaInventory", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool MediaInventory(string version, string serverKey, string hardwareKey, [System.Xml.Serialization.SoapElementAttribute("mediaInventory")] string mediaInventory1) {
            object[] results = this.Invoke("MediaInventory", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        mediaInventory1});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void MediaInventoryAsync(string version, string serverKey, string hardwareKey, string mediaInventory1) {
            this.MediaInventoryAsync(version, serverKey, hardwareKey, mediaInventory1, null);
        }
        
        /// <remarks/>
        public void MediaInventoryAsync(string version, string serverKey, string hardwareKey, string mediaInventory1, object userState) {
            if ((this.MediaInventoryOperationCompleted == null)) {
                this.MediaInventoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMediaInventoryOperationCompleted);
            }
            this.InvokeAsync("MediaInventory", new object[] {
                        version,
                        serverKey,
                        hardwareKey,
                        mediaInventory1}, this.MediaInventoryOperationCompleted, userState);
        }
        
        private void OnMediaInventoryOperationCompleted(object arg) {
            if ((this.MediaInventoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MediaInventoryCompleted(this, new MediaInventoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:xmds#GetResource", RequestNamespace="urn:xmds", ResponseNamespace="urn:xmds")]
        [return: System.Xml.Serialization.SoapElementAttribute("resource")]
        public string GetResource(string serverKey, string hardwareKey, int layoutId, string regionId, string mediaId, string version) {
            object[] results = this.Invoke("GetResource", new object[] {
                        serverKey,
                        hardwareKey,
                        layoutId,
                        regionId,
                        mediaId,
                        version});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetResourceAsync(string serverKey, string hardwareKey, int layoutId, string regionId, string mediaId, string version) {
            this.GetResourceAsync(serverKey, hardwareKey, layoutId, regionId, mediaId, version, null);
        }
        
        /// <remarks/>
        public void GetResourceAsync(string serverKey, string hardwareKey, int layoutId, string regionId, string mediaId, string version, object userState) {
            if ((this.GetResourceOperationCompleted == null)) {
                this.GetResourceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResourceOperationCompleted);
            }
            this.InvokeAsync("GetResource", new object[] {
                        serverKey,
                        hardwareKey,
                        layoutId,
                        regionId,
                        mediaId,
                        version}, this.GetResourceOperationCompleted, userState);
        }
        
        private void OnGetResourceOperationCompleted(object arg) {
            if ((this.GetResourceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetResourceCompleted(this, new GetResourceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void RegisterDisplayCompletedEventHandler(object sender, RegisterDisplayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterDisplayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterDisplayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void RequiredFilesCompletedEventHandler(object sender, RequiredFilesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequiredFilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequiredFilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetFileCompletedEventHandler(object sender, GetFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ScheduleCompletedEventHandler(object sender, ScheduleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void BlackListCompletedEventHandler(object sender, BlackListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BlackListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BlackListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SubmitLogCompletedEventHandler(object sender, SubmitLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubmitLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SubmitStatsCompletedEventHandler(object sender, SubmitStatsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitStatsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubmitStatsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void MediaInventoryCompletedEventHandler(object sender, MediaInventoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MediaInventoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MediaInventoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetResourceCompletedEventHandler(object sender, GetResourceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetResourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetResourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591