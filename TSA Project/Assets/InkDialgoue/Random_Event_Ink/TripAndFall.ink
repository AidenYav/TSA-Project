INCLUDE ../GlobalVariables.ink

//Random Event Tripping and Falling
//Those with more SelfEsteem should have higher resiliency
//negative impacts.
~temp fallingValue = 20 / Multi_SelfEsteem
//Currently no known condition necessary
~temp condition = true
#RerollEvent:{not condition}


{condition: -> Tripping_Falling | -> Random_Event_Failed}

=== Tripping_Falling ===
    <i>Ouch!! You fell on your face… That was embarrassing!<i>
    ~ Player_SelfEsteem -= fallingValue 
-> END
