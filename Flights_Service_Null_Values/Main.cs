/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘Flights_Service_Null_Values.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence10 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence10");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.StServiceCallActivity6 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity6");
            _flow.StServiceCallActivity7 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity7");
            _flow.StServiceCallActivity8 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity8");
            _flow.StServiceCallActivity9 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity9");
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            _flow.StartActivity1.KafkaSSL = new HP.ST.Fwk.KafkaFWK.KafkaSSLProperties();
            _flow.StartActivity1.IsKafkaUsed = false;
            _flow.StartActivity1.KafkaSSL.StrEnableSSL = @"No";
            _flow.StartActivity1.KafkaSSL.SSLCALocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyStoreLocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyStorePassword = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyPassword = @"";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence10);
            this.Activities.Add (_flow.Loop2);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence10.Comment = @"";
            _flow.Sequence10.IconPath = @"";
            _flow.Sequence10.Name = @"Sequence10";
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity5);
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity6);
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity7);
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity8);
            _flow.Sequence10.Activities.Add (_flow.StServiceCallActivity9);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Economy</Class><CustomerName p1:nil=""true""></CustomerName><DepartureDate></DepartureDate><FlightNumber></FlightNumber><NumberOfTickets></NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>Zurich</DepartureCity><ArrivalCity>Zurich</ArrivalCity><FlightDate></FlightDate></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity5.InputEnvelope = StServiceCallActivity5_InputEnvelope_Document;
            _flow.StServiceCallActivity5.Comment = @"";
            _flow.StServiceCallActivity5.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity5.Name = @"GetFlights";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity5.Service = @"Flights_Service";
            _flow.StServiceCallActivity5.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity5.Operation = @"GetFlights";
            _flow.StServiceCallActivity5.IsOneWay = false;
            _flow.StServiceCallActivity5.SendRequestToService=true;
            _flow.StServiceCallActivity5.FaultExpected=false;
            _flow.StServiceCallActivity5.IsAsync=false;
            _flow.StServiceCallActivity5.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity5.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity6_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity6_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity6_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightOrders xmlns=""HP.SOAQ.SampleApp""><FlightsDetails><CustomerName p1:nil=""true""></CustomerName><FlightDate></FlightDate><OrderNumber></OrderNumber></FlightsDetails></GetFlightOrders></Body></Envelope>");
            _flow.StServiceCallActivity6.InputEnvelope = StServiceCallActivity6_InputEnvelope_Document;
            _flow.StServiceCallActivity6.Comment = @"";
            _flow.StServiceCallActivity6.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity6.Name = @"GetFlightOrders";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlightOrders";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity6.Service = @"Flights_Service";
            _flow.StServiceCallActivity6.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity6.Operation = @"GetFlightOrders";
            _flow.StServiceCallActivity6.IsOneWay = false;
            _flow.StServiceCallActivity6.SendRequestToService=true;
            _flow.StServiceCallActivity6.FaultExpected=false;
            _flow.StServiceCallActivity6.IsAsync=false;
            _flow.StServiceCallActivity6.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity6.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity6_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlightOrdersResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity6.ExpectedOutputProperties = StServiceCallActivity6_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity6.ExpectedFaultProperties = StServiceCallActivity6_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity6.ExpectedOutputAttachments = StServiceCallActivity6_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity6_checkpoints(_flow.StServiceCallActivity6);
            XmlDocument StServiceCallActivity7_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity7_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity7_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><UpdateFlightOrder xmlns=""HP.SOAQ.SampleApp""><UpdateFlightOrderDetails><Class>Economy</Class><CustomerName p1:nil=""true""></CustomerName><NumberOfTickets></NumberOfTickets><OrderNumber></OrderNumber></UpdateFlightOrderDetails></UpdateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity7.InputEnvelope = StServiceCallActivity7_InputEnvelope_Document;
            _flow.StServiceCallActivity7.Comment = @"";
            _flow.StServiceCallActivity7.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity7.Name = @"UpdateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/UpdateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity7.Service = @"Flights_Service";
            _flow.StServiceCallActivity7.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity7.Operation = @"UpdateFlightOrder";
            _flow.StServiceCallActivity7.IsOneWay = false;
            _flow.StServiceCallActivity7.SendRequestToService=true;
            _flow.StServiceCallActivity7.FaultExpected=false;
            _flow.StServiceCallActivity7.IsAsync=false;
            _flow.StServiceCallActivity7.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity7.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity7_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><UpdateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity7.ExpectedOutputProperties = StServiceCallActivity7_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity7.ExpectedFaultProperties = StServiceCallActivity7_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity7.ExpectedOutputAttachments = StServiceCallActivity7_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity7_checkpoints(_flow.StServiceCallActivity7);
            XmlDocument StServiceCallActivity8_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity8_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity8_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrder xmlns=""HP.SOAQ.SampleApp""><OrderNumber></OrderNumber></DeleteFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity8.InputEnvelope = StServiceCallActivity8_InputEnvelope_Document;
            _flow.StServiceCallActivity8.Comment = @"";
            _flow.StServiceCallActivity8.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity8.Name = @"DeleteFlightOrder";
            _flow.StServiceCallActivity8.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity8.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity8.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity8.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/DeleteFlightOrder";
            _flow.StServiceCallActivity8.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity8.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity8.Service = @"Flights_Service";
            _flow.StServiceCallActivity8.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity8.Operation = @"DeleteFlightOrder";
            _flow.StServiceCallActivity8.IsOneWay = false;
            _flow.StServiceCallActivity8.SendRequestToService=true;
            _flow.StServiceCallActivity8.FaultExpected=false;
            _flow.StServiceCallActivity8.IsAsync=false;
            _flow.StServiceCallActivity8.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity8.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity8_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity8_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity8_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity8.ExpectedOutputProperties = StServiceCallActivity8_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity8_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity8_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity8_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity8.ExpectedFaultProperties = StServiceCallActivity8_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity8_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity8_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity8_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity8.ExpectedOutputAttachments = StServiceCallActivity8_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity8_checkpoints(_flow.StServiceCallActivity8);
            XmlDocument StServiceCallActivity9_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity9_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity9_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteAllFlightOrders xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity9.InputEnvelope = StServiceCallActivity9_InputEnvelope_Document;
            _flow.StServiceCallActivity9.Comment = @"";
            _flow.StServiceCallActivity9.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity9.Name = @"DeleteAllFlightOrders";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/DeleteAllFlightOrders";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity9.Service = @"Flights_Service";
            _flow.StServiceCallActivity9.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity9.Operation = @"DeleteAllFlightOrders";
            _flow.StServiceCallActivity9.IsOneWay = false;
            _flow.StServiceCallActivity9.SendRequestToService=true;
            _flow.StServiceCallActivity9.FaultExpected=false;
            _flow.StServiceCallActivity9.IsAsync=false;
            _flow.StServiceCallActivity9.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity9.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity9_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteAllFlightOrdersResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity9.ExpectedOutputProperties = StServiceCallActivity9_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity9_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity9.ExpectedFaultProperties = StServiceCallActivity9_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity9_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity9.ExpectedOutputAttachments = StServiceCallActivity9_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity9_checkpoints(_flow.StServiceCallActivity9);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    