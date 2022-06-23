SAPGuiSession("Session").SAPGuiWindow("SAP Easy Access").SAPGuiOKCode("OKCode").Set "va01" @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf4.xml_;_
SAPGuiSession("Session").SAPGuiWindow("SAP Easy Access").SendKey ENTER @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf4.xml_;_

SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SAPGuiEdit("*Order Type").Set "or" @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SAPGuiEdit("Sales Organization").Set "1710" @@ hightlight id_;_2_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SAPGuiEdit("Distribution Channel").Set Parameter("Dist_channel") @@ hightlight id_;_3_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SAPGuiEdit("Division").Set "00" @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SAPGuiEdit("Division").SetFocus @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Sales Documents").SendKey ENTER @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf5.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiEdit("Cust. Reference").Set DataTable("Cust.Reference", dtLocalSheet) @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiEdit("Sold-To Party").Set "17186001" @@ hightlight id_;_2_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiEdit("Ship-To Party").Set "17186001" @@ hightlight id_;_3_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiTable("All Items").SetCellData 1,"Material","tg11" @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiTable("All Items").SetCellData 1,"Order Quantity","50" @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiTable("All Items").SelectCell 1,"Order Quantity" @@ hightlight id_;_4_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SendKey F11 @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf6.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiStatusBar("StatusBar").Sync @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf7.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiStatusBar("StatusBar").Output CheckPoint("StatusBar") @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf8.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").SAPGuiStatusBar("StatusBar").Check CheckPoint("VA01 Passed Check") @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf9.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").Maximize @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf10.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Create Standard Order:").Close @@ hightlight id_;_0_;_script infofile_;_ZIP::ssf10.xml_;_
SAPGuiSession("Session").SAPGuiWindow("Log Off").SAPGuiButton("Yes").Click @@ hightlight id_;_1_;_script infofile_;_ZIP::ssf11.xml_;_

