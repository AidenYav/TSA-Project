INCLUDE ../GlobalVariables.ink

//Random Event Finding $20
~temp findingValue = 20
//Currently no known condition necessary
~temp condition = true
#RerollEvent:{not condition}

{condition: -> Finding_20 | -> Random_Event_Failed}

=== Finding_20 ===
    
    <i>Ooo you found <color=green>20 dollars</color>!<i>
    ~ Player_Finance += findingValue 
-> END

