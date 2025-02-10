using UnityEngine;
using System;
using System.Collections.Generic;
//there were a bunch of changes compared to the last push
//I expect all the Console.WriteLine() to be replaced with some GUI or you could just remove them
public class Relationship : MonoBehaviour
{
    private string character;
    private int relationshipValue;
    private int maxRelationship = 100;
    private Queue<string> eventQueue;

    public Relationship(string character)
    {
        this.character = character;
        this.relationshipValue = 0;
        this.eventQueue = new Queue<string>();
    }

    //the relationship value is made sure to be between 0 and 100
    public void SetRelationship(int value)
    {
        relationshipValue = Mathf.Clamp(value, 0, maxRelationship);
    }

    //adds to the relationship value as long as it does not surpas the max value
    public void AddRelationship(int value)
    {
        relationshipValue = Mathf.Min(relationshipValue + value, maxRelationship);
        Console.WriteLine($"{character} and you are now closer! Relationship: {relationshipValue}");
        CheckForUnlocks();
    }
    
    //assuming you hang out, your relationship increases
    public void HangOut()
    {
        int increase = GetRelationshipIncrease();
        AddRelationship(increase);
    }

    public void AddEvent(string newEvent)
    {
        //this adds an item to the end of a queue
        eventQueue.Enqueue(newEvent);
    }

    public string GetNextEvent()
    {
        //if an event exist in the queue then 
        //remove it and returns the first element of a queue
        if eventQueue.Count > 0:
            eventQueue.Dequeue();
        return null;
    }
    
    public bool HasNextEvent()
    {
        return eventQueue.Count > 0;
    }

    private int GetRelationshipIncrease()
    {
        if(character == "BestFriend"):
            return 5;
        else:
            return 3; 
    }

    private void CheckForUnlocks()
    {
        if (relationshipValue >= 50)
        {
            Console.WriteLine($"{character} is starting to trust you more. New events may be available.");
        }
        if (relationshipValue >= 75)
        {
            Console.WriteLine($"{character} and you are now very close! Special events unlocked.");
        }
    }
}
