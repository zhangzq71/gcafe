﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcafeWebFox40.gcafePrnSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="gcafePrnSvc.IgcafePrn")]
    public interface IgcafePrn {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/PrintLiuTai", ReplyAction="http://tempuri.org/IgcafePrn/PrintLiuTaiResponse")]
        string PrintLiuTai(int orderId, int prnType, bool rePrint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/PrintHuaDan", ReplyAction="http://tempuri.org/IgcafePrn/PrintHuaDanResponse")]
        string PrintHuaDan(int orderId, int prnType, bool rePrint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/PrintChuPing", ReplyAction="http://tempuri.org/IgcafePrn/PrintChuPingResponse")]
        string PrintChuPing(int orderId, int prnType, bool rePrint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/OrderPrint", ReplyAction="http://tempuri.org/IgcafePrn/OrderPrintResponse")]
        string OrderPrint(int orderId, int prnType, bool rePrint);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/PrintChuPingCui", ReplyAction="http://tempuri.org/IgcafePrn/PrintChuPingCuiResponse")]
        string PrintChuPingCui(int orderId, int orderDetailId, int setmailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IgcafePrn/OpenTable", ReplyAction="http://tempuri.org/IgcafePrn/OpenTableResponse")]
        string OpenTable(string orderNum, string tableNum, string staffName, int customerNum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IgcafePrnChannel : gcafeWebFox40.gcafePrnSvc.IgcafePrn, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IgcafePrnClient : System.ServiceModel.ClientBase<gcafeWebFox40.gcafePrnSvc.IgcafePrn>, gcafeWebFox40.gcafePrnSvc.IgcafePrn {
        
        public IgcafePrnClient() {
        }
        
        public IgcafePrnClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IgcafePrnClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgcafePrnClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgcafePrnClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PrintLiuTai(int orderId, int prnType, bool rePrint) {
            return base.Channel.PrintLiuTai(orderId, prnType, rePrint);
        }
        
        public string PrintHuaDan(int orderId, int prnType, bool rePrint) {
            return base.Channel.PrintHuaDan(orderId, prnType, rePrint);
        }
        
        public string PrintChuPing(int orderId, int prnType, bool rePrint) {
            return base.Channel.PrintChuPing(orderId, prnType, rePrint);
        }
        
        public string OrderPrint(int orderId, int prnType, bool rePrint) {
            return base.Channel.OrderPrint(orderId, prnType, rePrint);
        }
        
        public string PrintChuPingCui(int orderId, int orderDetailId, int setmailId) {
            return base.Channel.PrintChuPingCui(orderId, orderDetailId, setmailId);
        }
        
        public string OpenTable(string orderNum, string tableNum, string staffName, int customerNum) {
            return base.Channel.OpenTable(orderNum, tableNum, staffName, customerNum);
        }
    }
}
