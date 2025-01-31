INCLUDE GlobalVariables.ink

//First one is for true, second is for false
{test : -> main | -> understand}


=== main ===
    This is how you call a Knot
    This is similar to a method, called a Knot.
    ->question

=== question ===
    Star/Astrix signs are used for decisions as well.
    Does that make sense?
            //If you see this # symbol, it is a tag that will activate certain things in code.
            //Talk to whoever is in charge of dialogue systems how they want certain actions to play out!
        * [Yes] #Test:"Hi!"

            ~ test = false
            Great! That is really wonderful. I need a really long string to test something!
            
        * [No]
        
            Oh.
            
    -Anyway have fun testing out Ink!
    //Colors can be written as HEX-colors or their names (names are pretty restrictive though)
    Oh and one more thing, you can use <color=orange> color tags </color>, <b>bold tags</b>, or <i>italic tags</i>. Just search up <color=\#ff00ff><b><i>Rich Text Tags </i></b></color> to see what else you can do with tags!
    
-> END

=== understand ===
    Glad you understood!
    But would you like to hear those instructions again?
    *[No]
    
        Great!
    *[Yes] 
        ~ test = true
        Perfect, just talk to me again!
    -Anyway, I'll be here if you need any help!
->END
