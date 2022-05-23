SAPGuiUtil.OpenConnection "S/4HANA 2020 FPS01"
SAPGuiSession("Session").SAPGuiWindow("SAP").Maximize @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SAPGuiEdit("Client").Set "100" @@ hightlight id_;_16_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SAPGuiEdit("*User").Set "S4H_TM_DEM" @@ hightlight id_;_14_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SAPGuiEdit("*Password").Set "Welcome1" @@ hightlight id_;_12_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SAPGuiEdit("Logon Language").Set "EN" @@ hightlight id_;_15_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SAPGuiEdit("*Password").SetFocus @@ hightlight id_;_12_;_script infofile_;_ZIP::ssf1.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP").SendKey ENTER @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf1.xml_;_

SAPGuiSession("Session").SAPGuiWindow("SAP Easy Access").SAPGuiOKCode("OKCode").Set "/nva02" @@ hightlight id_;_8_;_script infofile_;_ZIP::ssf2.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP Easy Access").SendKey ENTER @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf2.xml_;_

SAPGuiSession("Session").SAPGuiWindow("Change Sales Documents").SAPGuiEdit("Order").Set DataTable("OrderNr", dtGlobalSheet) @@ hightlight id_;_19_;_script infofile_;_ZIP::ssf3.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Change Sales Documents").SAPGuiButton("Search").Click @@ hightlight id_;_13_;_script infofile_;_ZIP::ssf3.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Change Standard Order").SAPGuiTable("All Items").SetCellData 1,"Order Quantity","150" @@ hightlight id_;_66_;_script infofile_;_ZIP::ssf4.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Change Standard Order").SAPGuiTable("All Items").SelectCell 1,"Order Quantity" @@ hightlight id_;_66_;_script infofile_;_ZIP::ssf4.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Change Standard Order").SAPGuiButton("Save").Click @@ hightlight id_;_-1_;_script infofile_;_ZIP::ssf4.xml_;_

SAPGuiSession("Session").SAPGuiWindow("Change Sales Documents").SAPGuiStatusBar("StatusBar").Sync @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Change Sales Documents").SAPGuiButton("Exit").Click @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP Easy Access").SAPGuiButton("Exit").Click @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf7.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Log Off").SAPGuiButton("Yes").Click @@ hightlight id_;_3_;_script infofile_;_ZIP::ssf8.xml_;_
