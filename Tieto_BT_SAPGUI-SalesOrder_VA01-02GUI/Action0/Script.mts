RunAction "Log On SAP - Tieto", oneIteration
RunAction "VA01 - Tieto", oneIteration
RunAction "VA02 - Tieto", oneIteration, Parameter("VA01", "SalesOrderOutput")
