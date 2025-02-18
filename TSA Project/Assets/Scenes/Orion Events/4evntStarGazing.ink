INCLUDE ../../InkDialgoue/GlobalVariables.ink
//Trigger:  Hang out with Orion 2 more times then hang out at night
//Condition: OrionEvent==4
//Setting: In a cold field flanked by road on each side.  The sky is filled with stars, quiet except for the hum of the city below.
Orion stops near a wanted poster, staring at it for a long moment before exhaling.
Orion: "I should probably tell you something."
Orion: “Can we head over to that field”
(You guys sit in the grass. For once, Orion looks... tired.) #OrionAnimate:Orion_Sad
Orion: "I’m the bounty hunter." #OrionAnimate:Orion_Talking
(Silence. The words hang between you and Orion, irreversible.) #SolAnima:Sol_Shocked
(Your breath catches as you watch them. You can tell how they’re waiting for you to react—to judge.)
Orion: "I wish I could quit though" #OrionAnimate:Orion_Talking

* Tell him to keep going
    You: "I think you should keep going, why do you want to quit?"#SolAnima:Sol_Talking
    Orion lets out a quiet breath, glancing at the stars.
    Orion: "Because I'm tired and it's dangerous" #OrionAnimate:Orion_Talking
    You: “I think you can do it, I will support you.” #SolAnima:Sol_Talking
    Orion: "Okay" #OrionAnimate:Orion_Sad
    ~OrionEvent=9
* Encourage them to quit
    You: "You should quit bounty hunting and get a normal job
    (Orion scoffs, shaking their head.)
    Orion: "A normal job?"
    Orion: "You really think I belong behind a register?"
    (They lean back, exhaling slowly.)
    Orion: "I don’t know… maybe you’re right."
    You: “I can help you try.”

    ~OrionEvent=8