﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VB6ComClient.OldHorse
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/C77AC58E-68D6-424D-9E7A-7D5F283ECFAA", ConfigurationName="VB6ComClient.OldHorse._PositionManagement", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface _PositionManagement
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/C77AC58E-68D6-424D-9E7A-7D5F283ECFAA/_PositionManagement/Updat" +
            "ePosition", ReplyAction="http://tempuri.org/C77AC58E-68D6-424D-9E7A-7D5F283ECFAA/_PositionManagement/Updat" +
            "ePositionResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        int UpdatePosition(string Ticker, int Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/C77AC58E-68D6-424D-9E7A-7D5F283ECFAA/_PositionManagement/GetQu" +
            "antity", ReplyAction="http://tempuri.org/C77AC58E-68D6-424D-9E7A-7D5F283ECFAA/_PositionManagement/GetQu" +
            "antityResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        int GetQuantity(string Ticker);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface _PositionManagementChannel : VB6ComClient.OldHorse._PositionManagement, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class _PositionManagementClient : System.ServiceModel.ClientBase<VB6ComClient.OldHorse._PositionManagement>, VB6ComClient.OldHorse._PositionManagement
    {
        
        public _PositionManagementClient()
        {
        }
        
        public _PositionManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public _PositionManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public _PositionManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public _PositionManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int UpdatePosition(string Ticker, int Quantity)
        {
            return base.Channel.UpdatePosition(Ticker, Quantity);
        }
        
        public int GetQuantity(string Ticker)
        {
            return base.Channel.GetQuantity(Ticker);
        }
    }
}