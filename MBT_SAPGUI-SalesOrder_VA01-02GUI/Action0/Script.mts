RunAction "Log On SAP", oneIteration
RunAction "VA01", oneIteration
RunAction "VA02", oneIteration, Parameter("VA01", "SalesOrderOutput")
