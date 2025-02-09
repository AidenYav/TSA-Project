using UnityEngine;
using System;
using System.Collections.Generic;
//*IMPORANT*
//I am going to assume that you will replace the Console.WriteLine with some gui
//if you don't like some methods or want to change them, you can
//There is a relationship feature in the Player Class, you many want to figure out how to how to integerate them
public class Relationship : MonoBehaviour
{
    private Dictionary<string, int> relationshipStats;
    private List<string> knownCharacters;
    private int maxRelationship = 100;

    public Relationship()
    {
        relationshipStats = new Dictionary<string, int>();
        knownCharacters = new List<string>();

        foreach (var character in Player.characters)
        {
            string characterName = character.Key;
            relationshipStats[characterName] = 0;
            knownCharacters.Add(characterName);
        }
    }
    public void SetRelationship(string character, int value)
    {
            //Clamp is a method that only adds the number if it is from 0<=x<=100
            relationshipStats[character] = Mathf.Clamp(value, 0, maxRelationship);
    }

    public void AddRelationship(string character, int value)
    {
        if(relationshipStats.ContainsKey(character))
        {
            relationshipStats[character] += increase;
            //If relationshopStats > 100, then set relationship value to 100
            relationshipStats[character] = Mathf.Min(relationshipStats[character], maxRelationship);
            Console.WriteLine($"{character} and you are now closer! Relationship: {relationshipStats[character]}");
            CheckForUnlocks(character);
        } else
        {
            Console.WriteLine("You haven't meet this character yet.");
        }
    }
    public void HangOut(string character)
    {
        if (relationshipStats.ContainsKey(character))
        {
            int increase = GetRelationshipIncrease(character);
             AddRelationship(character, increase);
        }
        else
        {
            Console.WriteLine("You haven't met this character yet.");
        }
    }

    public void MeetNewCharacter(string newCharacter)
    {
        if (!relationshipStats.ContainsKey(newCharacter))
        {
            relationshipStats[newCharacter] = 0;
            knownCharacters.Add(newCharacter);
            Console.WriteLine($"You met {newCharacter}! You can now interact with them.");
        }
        else
        {
            Console.WriteLine($"You already know {newCharacter}.");
        }
    }

    public void SkipInteraction()
    {
        Console.WriteLine("You decided to do your own thing today.");
    }

    private int GetRelationshipIncrease(string character)
    {
        //you can change the numbers or even get rid of this method 
        if (character == "BestFriend")
            return 5;
        else
            return 3;
    }

    private void CheckForUnlocks(string character)
    {
        //you can manupliate the numbers or add more unlocked events
        if (relationshipStats[character] >= 50)
        {
            Console.WriteLine($"{character} is starting to trust you more. New events may be available.");
        }
        if (relationshipStats[character] >= 75)
        {
            Console.WriteLine($"{character} and you are now very close! Special events unlocked.");
        }
    }
}
