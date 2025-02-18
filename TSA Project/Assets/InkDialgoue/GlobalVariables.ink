//----Story Progression Variables----
//This will be true by default.
//True means the dialogue is active for the player
//False means the dialogue section is no longer used/player has already
//gone through the dialogue

VAR test = true

//Stat Multiplers Variables
VAR Multi_Fitness = 1
VAR Multi_Awakeness = 1
VAR Multi_Sanity = 1
VAR Multi_SelfEsteem = 1
VAR Multi_Finance = 1
VAR Multi_Illness = 1


//----Player Variables----
VAR roommate = "Tester"
//Player Stats
VAR Player_Fitness = 0
VAR Player_Awakeness = 0
VAR Player_Sanity = 0
VAR Player_SelfEsteem = 0
VAR Player_Finance = 0
VAR Player_Illness = 0

//Roommate Exp
VAR Sol_EXP = 0
VAR Rigel_EXP = 0
VAR Carina_EXP = 0
VAR Orion_EXP = 0
VAR Izar_EXP = 0

//Minigame Sucess
VAR game = 1

//Character Storyline
VAR OrionEvent=1
VAR SolEvent=1

=== Random_Event_Failed ===
   //#RerollEvent:true
-> END