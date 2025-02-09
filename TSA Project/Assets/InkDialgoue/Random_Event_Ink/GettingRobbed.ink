INCLUDE ../GlobalVariables.ink

//Random Event Getting Robbed
~temp robbingValue = 30
~temp condition = Player_Finance >= robbingValue
#RerollEvent:{not condition}

{condition: -> Getting_Robbed | -> Random_Event_Failed}

=== Getting_Robbed ===
    [A robber pushes you down and steals your wallet]
    Hey get back here!
    Carina: Your stubby lets could never catch him
    <i>You look defeated as the robber gets farther and farther away<i>
    ~Player_Finance -= robbingValue
    //Finance does not make sense to drop below 0 here.
    //A robber cannot put you into debt!
    { Player_Finance < 0:
        ~Player_Finance = 0
    }
-> END