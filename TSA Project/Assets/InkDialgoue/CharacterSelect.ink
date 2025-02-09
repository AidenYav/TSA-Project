INCLUDE GlobalVariables.ink

===Character_Selection===
    Please Select one of the following:
        *Sol
            #SetRoomate:Sol
            ~roommate="Sol"
            ~Multi_SelfEsteem = 2
            ~Multi_Illness = 2
        *Carina
            #SetRoomate:Carina
            ~roommate="Carina"
            ~Multi_Sanity = 2
            ~Multi_SelfEsteem = 0.5
        *Izar
            #SetRoomate:Izar
            ~roommate="Izar"
            ~Multi_Awakeness = 2
            ~Multi_Fitness = 0.5
        -Selected: {roommate}
->END
    