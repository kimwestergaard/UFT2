
AIUtil.SetContext Browser("creationtime:=0")
AIUtil("text_box", "User").Type "rossim"
AIUtil("text_box", "Password").Type "Solman72"
AIUtil("button", "Log On").Click @@ script infofile_;_ZIP::ssf3.xml_;_
Browser("Logon").Page("Logon").WebList("Group Navigation").Select "Project and Process Management" @@ script infofile_;_ZIP::ssf5.xml_;_
Browser("Logon").Page("Logon").WebList("Group Navigation").Select "Change Management" @@ script infofile_;_ZIP::ssf6.xml_;_
Browser("Logon").Page("Logon").WebList("Group Navigation").Select "Focused Build - Business Analyst" @@ script infofile_;_ZIP::ssf7.xml_;_
Browser("Logon").Page("Logon").WebList("Group Navigation").Select "Focused Build - Conversion Project" @@ script infofile_;_ZIP::ssf8.xml_;_
Browser("Logon").Page("Logon").WebList("Group Navigation").Select "Project and Process Management" @@ script infofile_;_ZIP::ssf9.xml_;_
Browser("Logon").Page("Logon").SAPUITile("SAPUITile").Click @@ script infofile_;_ZIP::ssf10.xml_;_
Browser("Select a business role:").Page("Select a business role:").Link("/SALM/ARCHTC-Architect").Click @@ script infofile_;_ZIP::ssf11.xml_;_
Browser("Select a business role:").Page("Select a business role:").SAPFrame("Home - [SAP]").SAPEdit("SAPEdit").Set "microfocus" @@ script infofile_;_ZIP::ssf12.xml_;_
Browser("Select a business role:").Page("Select a business role:").SAPFrame("Home - [SAP]").WebElement("Go").Click
Browser("Select a business role:").Page("Select a business role:").SAPFrame("Search Result - [SAP]").WebElement("Incidents (0)").Check CheckPoint("Incidents (0)") @@ script infofile_;_ZIP::ssf13.xml_;_
SystemUtil.CloseProcessByName("chrome.exe") @@ script infofile_;_ZIP::ssf21.xml_;_
