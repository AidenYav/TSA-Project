INCLUDE ../GlobalVariables.ink
//Testing Event Compiler

~temp condition = Player_Fitness == 0
{condition: -> event}

=== event ===
//Check Conditions
    SelfEsteem: {Player_SelfEsteem}
    Hi!
    Test
        * Hello!
            ~Player_SelfEsteem += 3
            A
        * ...
            ~Player_SelfEsteem  -= 2
    -Bye!
     SelfEsteem: {Player_SelfEsteem }
-> END