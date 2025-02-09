
INCLUDE ../GlobalVariables.ink
//Testing Event Compiler

~temp condition = Player_Fitness == 0
{condition: -> event}
Testing3
=== event ===
//Check Conditions
{Player_Sanity}
    Hi!
    Test
        * Hello!
            ~Player_Sanity += 3
            A
        * ...
            ~Player_Sanity -= 2
    -Bye!
    {Player_Sanity}
-> END