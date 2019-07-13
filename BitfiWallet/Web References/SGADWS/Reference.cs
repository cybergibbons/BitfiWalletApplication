﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BitfiWallet.SGADWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SGADWSSoap", Namespace="https://bitfi.com/dataservices/")]
    public partial class SGADWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetMessageConfigOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOverviewModelOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAddressIndexesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAddressIndexesV3OperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSGATokenForSignInOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSGATokenOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSGAMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SGADWS() {
            this.Url = "https://bitfi.com/NoxPortalWS/V1/SGADWS.asmx";
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
        public event GetMessageConfigCompletedEventHandler GetMessageConfigCompleted;
        
        /// <remarks/>
        public event GetOverviewModelCompletedEventHandler GetOverviewModelCompleted;
        
        /// <remarks/>
        public event GetAddressIndexesCompletedEventHandler GetAddressIndexesCompleted;
        
        /// <remarks/>
        public event GetAddressIndexesV3CompletedEventHandler GetAddressIndexesV3Completed;
        
        /// <remarks/>
        public event GetSGATokenForSignInCompletedEventHandler GetSGATokenForSignInCompleted;
        
        /// <remarks/>
        public event GetSGATokenCompletedEventHandler GetSGATokenCompleted;
        
        /// <remarks/>
        public event GetSGAMessageCompletedEventHandler GetSGAMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetMessageConfig", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public NoxMessagesConfig GetMessageConfig() {
            object[] results = this.Invoke("GetMessageConfig", new object[0]);
            return ((NoxMessagesConfig)(results[0]));
        }
        
        /// <remarks/>
        public void GetMessageConfigAsync() {
            this.GetMessageConfigAsync(null);
        }
        
        /// <remarks/>
        public void GetMessageConfigAsync(object userState) {
            if ((this.GetMessageConfigOperationCompleted == null)) {
                this.GetMessageConfigOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMessageConfigOperationCompleted);
            }
            this.InvokeAsync("GetMessageConfig", new object[0], this.GetMessageConfigOperationCompleted, userState);
        }
        
        private void OnGetMessageConfigOperationCompleted(object arg) {
            if ((this.GetMessageConfigCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMessageConfigCompleted(this, new GetMessageConfigCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetOverviewModel", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OverviewViewModel GetOverviewModel(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            object[] results = this.Invoke("GetOverviewModel", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage});
            return ((OverviewViewModel)(results[0]));
        }
        
        /// <remarks/>
        public void GetOverviewModelAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            this.GetOverviewModelAsync(noxsig, noxmsg, pubkeyD, GCMToken, TokenMessage, null);
        }
        
        /// <remarks/>
        public void GetOverviewModelAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage, object userState) {
            if ((this.GetOverviewModelOperationCompleted == null)) {
                this.GetOverviewModelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOverviewModelOperationCompleted);
            }
            this.InvokeAsync("GetOverviewModel", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage}, this.GetOverviewModelOperationCompleted, userState);
        }
        
        private void OnGetOverviewModelOperationCompleted(object arg) {
            if ((this.GetOverviewModelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOverviewModelCompleted(this, new GetOverviewModelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetAddressIndexes", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public NoxAddressReview[] GetAddressIndexes(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            object[] results = this.Invoke("GetAddressIndexes", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage});
            return ((NoxAddressReview[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAddressIndexesAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            this.GetAddressIndexesAsync(noxsig, noxmsg, pubkeyD, GCMToken, TokenMessage, null);
        }
        
        /// <remarks/>
        public void GetAddressIndexesAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage, object userState) {
            if ((this.GetAddressIndexesOperationCompleted == null)) {
                this.GetAddressIndexesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAddressIndexesOperationCompleted);
            }
            this.InvokeAsync("GetAddressIndexes", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage}, this.GetAddressIndexesOperationCompleted, userState);
        }
        
        private void OnGetAddressIndexesOperationCompleted(object arg) {
            if ((this.GetAddressIndexesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAddressIndexesCompleted(this, new GetAddressIndexesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetAddressIndexesV3", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public NoxAddressReviewV3 GetAddressIndexesV3(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            object[] results = this.Invoke("GetAddressIndexesV3", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage});
            return ((NoxAddressReviewV3)(results[0]));
        }
        
        /// <remarks/>
        public void GetAddressIndexesV3Async(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage) {
            this.GetAddressIndexesV3Async(noxsig, noxmsg, pubkeyD, GCMToken, TokenMessage, null);
        }
        
        /// <remarks/>
        public void GetAddressIndexesV3Async(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string TokenMessage, object userState) {
            if ((this.GetAddressIndexesV3OperationCompleted == null)) {
                this.GetAddressIndexesV3OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAddressIndexesV3OperationCompleted);
            }
            this.InvokeAsync("GetAddressIndexesV3", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        TokenMessage}, this.GetAddressIndexesV3OperationCompleted, userState);
        }
        
        private void OnGetAddressIndexesV3OperationCompleted(object arg) {
            if ((this.GetAddressIndexesV3Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAddressIndexesV3Completed(this, new GetAddressIndexesV3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetSGATokenForSignIn", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSGATokenForSignIn(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU, string DisplayCode) {
            object[] results = this.Invoke("GetSGATokenForSignIn", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        pubkeyU,
                        signatureU,
                        DisplayCode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSGATokenForSignInAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU, string DisplayCode) {
            this.GetSGATokenForSignInAsync(noxsig, noxmsg, pubkeyD, GCMToken, pubkeyU, signatureU, DisplayCode, null);
        }
        
        /// <remarks/>
        public void GetSGATokenForSignInAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU, string DisplayCode, object userState) {
            if ((this.GetSGATokenForSignInOperationCompleted == null)) {
                this.GetSGATokenForSignInOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSGATokenForSignInOperationCompleted);
            }
            this.InvokeAsync("GetSGATokenForSignIn", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        pubkeyU,
                        signatureU,
                        DisplayCode}, this.GetSGATokenForSignInOperationCompleted, userState);
        }
        
        private void OnGetSGATokenForSignInOperationCompleted(object arg) {
            if ((this.GetSGATokenForSignInCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSGATokenForSignInCompleted(this, new GetSGATokenForSignInCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetSGAToken", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSGAToken(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU) {
            object[] results = this.Invoke("GetSGAToken", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        pubkeyU,
                        signatureU});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSGATokenAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU) {
            this.GetSGATokenAsync(noxsig, noxmsg, pubkeyD, GCMToken, pubkeyU, signatureU, null);
        }
        
        /// <remarks/>
        public void GetSGATokenAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, string pubkeyU, string signatureU, object userState) {
            if ((this.GetSGATokenOperationCompleted == null)) {
                this.GetSGATokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSGATokenOperationCompleted);
            }
            this.InvokeAsync("GetSGAToken", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken,
                        pubkeyU,
                        signatureU}, this.GetSGATokenOperationCompleted, userState);
        }
        
        private void OnGetSGATokenOperationCompleted(object arg) {
            if ((this.GetSGATokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSGATokenCompleted(this, new GetSGATokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://bitfi.com/dataservices/GetSGAMessage", RequestNamespace="https://bitfi.com/dataservices/", ResponseNamespace="https://bitfi.com/dataservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSGAMessage(string noxsig, string noxmsg, string pubkeyD, string GCMToken) {
            object[] results = this.Invoke("GetSGAMessage", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSGAMessageAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken) {
            this.GetSGAMessageAsync(noxsig, noxmsg, pubkeyD, GCMToken, null);
        }
        
        /// <remarks/>
        public void GetSGAMessageAsync(string noxsig, string noxmsg, string pubkeyD, string GCMToken, object userState) {
            if ((this.GetSGAMessageOperationCompleted == null)) {
                this.GetSGAMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSGAMessageOperationCompleted);
            }
            this.InvokeAsync("GetSGAMessage", new object[] {
                        noxsig,
                        noxmsg,
                        pubkeyD,
                        GCMToken}, this.GetSGAMessageOperationCompleted, userState);
        }
        
        private void OnGetSGAMessageOperationCompleted(object arg) {
            if ((this.GetSGAMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSGAMessageCompleted(this, new GetSGAMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class NoxMessagesConfig {
        
        private string endPointField;
        
        private string welcomeMessageField;
        
        private bool serviceEnabledField;
        
        /// <remarks/>
        public string EndPoint {
            get {
                return this.endPointField;
            }
            set {
                this.endPointField = value;
            }
        }
        
        /// <remarks/>
        public string WelcomeMessage {
            get {
                return this.welcomeMessageField;
            }
            set {
                this.welcomeMessageField = value;
            }
        }
        
        /// <remarks/>
        public bool ServiceEnabled {
            get {
                return this.serviceEnabledField;
            }
            set {
                this.serviceEnabledField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class NoxAddresses {
        
        private bool doSegwitField;
        
        private string viewKeyField;
        
        private string blkNetField;
        
        private string bTCBalField;
        
        private string bTCAddressField;
        
        private int hDIndexField;
        
        private string tXNLineIDField;
        
        /// <remarks/>
        public bool DoSegwit {
            get {
                return this.doSegwitField;
            }
            set {
                this.doSegwitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ViewKey {
            get {
                return this.viewKeyField;
            }
            set {
                this.viewKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BlkNet {
            get {
                return this.blkNetField;
            }
            set {
                this.blkNetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BTCBal {
            get {
                return this.bTCBalField;
            }
            set {
                this.bTCBalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BTCAddress {
            get {
                return this.bTCAddressField;
            }
            set {
                this.bTCAddressField = value;
            }
        }
        
        /// <remarks/>
        public int HDIndex {
            get {
                return this.hDIndexField;
            }
            set {
                this.hDIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TXNLineID {
            get {
                return this.tXNLineIDField;
            }
            set {
                this.tXNLineIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class NoxAddressReviewV3 {
        
        private NoxAddressReview[] adrReviewField;
        
        private NoxAddresses[] addressesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public NoxAddressReview[] AdrReview {
            get {
                return this.adrReviewField;
            }
            set {
                this.adrReviewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public NoxAddresses[] Addresses {
            get {
                return this.addressesField;
            }
            set {
                this.addressesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class NoxAddressReview {
        
        private string blkField;
        
        private int indexCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Blk {
            get {
                return this.blkField;
            }
            set {
                this.blkField = value;
            }
        }
        
        /// <remarks/>
        public int IndexCount {
            get {
                return this.indexCountField;
            }
            set {
                this.indexCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class WalletList {
        
        private string currencyField;
        
        private string balanceField;
        
        private string uSDField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string USD {
            get {
                return this.uSDField;
            }
            set {
                this.uSDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class OverviewTableViewModel {
        
        private WalletList[] walletsField;
        
        private string ethAddrField;
        
        private string btcRateField;
        
        private string knownTokensJsonField;
        
        /// <remarks/>
        public WalletList[] Wallets {
            get {
                return this.walletsField;
            }
            set {
                this.walletsField = value;
            }
        }
        
        /// <remarks/>
        public string EthAddr {
            get {
                return this.ethAddrField;
            }
            set {
                this.ethAddrField = value;
            }
        }
        
        /// <remarks/>
        public string BtcRate {
            get {
                return this.btcRateField;
            }
            set {
                this.btcRateField = value;
            }
        }
        
        /// <remarks/>
        public string KnownTokensJson {
            get {
                return this.knownTokensJsonField;
            }
            set {
                this.knownTokensJsonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://bitfi.com/dataservices/")]
    public partial class OverviewViewModel {
        
        private OverviewTableViewModel overviewTableViewModelField;
        
        private decimal totalUsdField;
        
        private decimal totalBtcField;
        
        /// <remarks/>
        public OverviewTableViewModel OverviewTableViewModel {
            get {
                return this.overviewTableViewModelField;
            }
            set {
                this.overviewTableViewModelField = value;
            }
        }
        
        /// <remarks/>
        public decimal TotalUsd {
            get {
                return this.totalUsdField;
            }
            set {
                this.totalUsdField = value;
            }
        }
        
        /// <remarks/>
        public decimal TotalBtc {
            get {
                return this.totalBtcField;
            }
            set {
                this.totalBtcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetMessageConfigCompletedEventHandler(object sender, GetMessageConfigCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMessageConfigCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMessageConfigCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NoxMessagesConfig Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NoxMessagesConfig)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetOverviewModelCompletedEventHandler(object sender, GetOverviewModelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOverviewModelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOverviewModelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OverviewViewModel Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OverviewViewModel)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetAddressIndexesCompletedEventHandler(object sender, GetAddressIndexesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAddressIndexesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAddressIndexesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NoxAddressReview[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NoxAddressReview[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetAddressIndexesV3CompletedEventHandler(object sender, GetAddressIndexesV3CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAddressIndexesV3CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAddressIndexesV3CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NoxAddressReviewV3 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NoxAddressReviewV3)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetSGATokenForSignInCompletedEventHandler(object sender, GetSGATokenForSignInCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSGATokenForSignInCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSGATokenForSignInCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetSGATokenCompletedEventHandler(object sender, GetSGATokenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSGATokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSGATokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetSGAMessageCompletedEventHandler(object sender, GetSGAMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSGAMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSGAMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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