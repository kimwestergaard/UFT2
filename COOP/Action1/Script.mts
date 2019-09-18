
Device("Device").App("Coop").MobileLabel("Indkøbsliste").Tap
Device("Device").App("Coop").MobileButton("add_fab").Tap

Device("Device").App("Coop").MobileLabel("Bacon").Tap
Device("Device").App("Coop").MobileLabel("Fløde").Tap
Device("Device").App("Coop").MobileLabel("Mælk").Tap
Device("Device").App("Coop").MobileEdit("input_field").Set "Ostehaps"
Device("Device").App("Coop").MobileButton("Tilføj").Tap

Device("Device").App("Coop").MobileButton("Færdig").Tap

Device("Device").App("Coop").MobileCheckbox("MobileCheckbox").Set "Off"

Device("Device").App("Coop").MobileLabel("Vis indkøbte varer").Tap

Device("Device").App("Coop").MobileObject("toolbar_close_button_3").Tap
