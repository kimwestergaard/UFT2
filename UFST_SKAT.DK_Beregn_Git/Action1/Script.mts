Reporter.ReportEvent micDone, "Run Browsertype: "  & DataTable("Browser", dtGlobalSheet),"Run Details"

Browser("Skat.dk: Borger").Page("Skat.dk: Borger").Link("Indkomst og skatOm skat").Click @@ hightlight id_;_Browser("Skat.dk: Borger").Page("Skat.dk: Borger").Link("Indkomst og skatOm skat")_;_script infofile_;_ZIP::ssf1.xml_;_
Browser("Skat.dk: Borger").Page("Skat.dk: Indkomst og skat").Link("ForskudsopgørelseDin indkomst").Click @@ hightlight id_;_Browser("Skat.dk: Borger").Page("Skat.dk: Indkomst og skat").Link("ForskudsopgørelseDin indkomst")_;_script infofile_;_ZIP::ssf2.xml_;_
Browser("Skat.dk: Borger").Page("Skat.dk: Forskudsopgørelse").Link("Regn ud, hvad du får udbetaltH").Click @@ hightlight id_;_Browser("Skat.dk: Borger").Page("Skat.dk: Forskudsopgørelse").Link("Regn ud, hvad du får udbetaltH")_;_script infofile_;_ZIP::ssf3.xml_;_

Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebEdit("Skriv procent").Set DataTable("Procent", dtLocalSheet)
Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebEdit("Skriv beløb").Set DataTable("Amount", dtLocalSheet)
Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebButton("Fortsæt").Click

Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebList("select").Select DataTable("Type", dtLocalSheet)

If DataTable.Value("Hoved_Bikort", dtLocalSheet)= "Løn"   Then
Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebEdit("Skriv arbejdsgivers navn").Set DataTable("Arbejdsgiver", dtLocalSheet)
	If DataTable.Value("Udbetalingsfrekvens", dtLocalSheet) = "pr.måned"   Then
    	Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("pr. måned").Click 
	ElseIf DataTable.Value("Udbetalingsfrekvens", dtLocalSheet) = "hver anden uge" Then
		Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("hver anden uge").Click
	End If
End If

Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebEdit("Skriv beløb").Set DataTable("Inkomst", dtLocalSheet)
 
If DataTable.Value("Hoved_Bikort", dtLocalSheet) = "Bikort"   Then
    Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("Bikort").Click 
ElseIf DataTable.Value("Hoved_Bikort", dtLocalSheet) = "Hovedkort" Then
	Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("Hovedkort").Click
End If

Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebButton("Fortsæt").Click


Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("Resultat").Check CheckPoint("Resultat Check")
Resultat = (Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").WebElement("Resultat").GetROProperty("innertext"))
If DataTable.Value("Forventet_Udbetaling", dtLocalSheet) = Resultat Then
	Reporter.ReportEvent micPass, "Resultat Check Passed","Forventet " & DataTable.value("Forventet_Udbetaling", dtLocalSheet) & " Aktuel værdig " & Resultat & ""  	
Else
	Reporter.ReportEvent micFail, "Resultat Check Failed","Forventet " & DataTable.value("Forventet_Udbetaling", dtLocalSheet) & " Aktuel værdig " & Resultat & ""  	
End If 
	
Browser("Skat.dk: Borger").Page("Skat.dk: Regn ud, hvad").Link("Gå til forside").Click

