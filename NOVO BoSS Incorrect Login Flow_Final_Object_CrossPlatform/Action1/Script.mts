AIUtil.SetContext Device("device") 
Devicetype = Device("device").GetROProperty("ostype")

'Input Email and Password and try to log in. Set also device type and handle two different app interactions on iOS and Android
If Devicetype = "ANDROID" Then
    AppVersion = "BOSS Android"
    Device("device").App(AppVersion).MobileEdit("Email").Set DataTable("Username", dtLocalSheet) 
    Device("device").App(AppVersion).MobileEdit("Password").Set DataTable("Password", dtLocalSheet)
ElseIf Devicetype = "IOS" Then
    AppVersion = "BOSS"	
    Device("device").App(AppVersion).MobileEdit("Email").Set DataTable("Username", dtLocalSheet) 
    Device("device").App(AppVersion).MobileEdit("Password").Set ""
    Device("device").App(AppVersion).MobileEdit("Password").SetFocus
    Device("device").Enterkeys typeKey, DataTable("Password", dtLocalSheet) 
End If
'make a change here

If Environment.Value("ActionIteration") = 1 then 
Device("device").App(AppVersion).MobileButton("showPasswordIcon").Tap 
End If

Device("device").App(AppVersion).MobileButton("Login").Tap

'Check Correct Error Message is Displayed
CheckPointResult = Device("device").App(AppVersion).MobileLabel("Error Message").Check (CheckPoint("Incorrect email or password"))
If CheckPointResult = True Then
	Reporter.ReportEvent micPass, "Correct Error Message displayed", "Expected Message was correct : " & datatable("ErrorMsg", dtLocalSheet) & ""
	Else
	Reporter.ReportEvent micFail, "InCorrect Error Message displayed", "Message was not correct, Expected message was : " & datatable("ErrorMsg", dtLocalSheet) & ""
End If 

'Wait for countdown on multiple wrong login attempts
TimeCounter = 2
Do Until Device("device").App(AppVersion).MobileButton("Try again in xx:xx min").Exist(2) = False 
	Wait 5
	TimeCounter = TimeCounter + 5
Loop	

'Verify thay Login delay is correct as per specification
Reporter.ReportEvent micDone, "Expected delay vs Actual", "Expected Wait is " & datatable("Waittime", dtLocalSheet)  & " seconds" & vbcr & "Actual Wait was " & TimeCounter & " seconds"





