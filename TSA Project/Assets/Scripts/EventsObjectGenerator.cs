using UnityEngine;

public class EventsObjectGenerator
{
    public static EventsObject createEvent(string eventName, TextAsset inkJson)
    {
        switch (eventName)
        {
            case "Event1":
                return new EventTest(eventName, inkJson);
            case "Event2":
                return new EventTest(eventName, inkJson);
            default:
                Debug.LogError("Invalid event type");
                break;
        }
        return new EventTest(eventName, inkJson);
        
    }
}
public abstract class EventsObject
{
    public string eventName{get; set;}
    public TextAsset inkJson;
    public EventsObject(string eventName, TextAsset inkJson)
    {
        this.eventName = eventName;
        this.inkJson = inkJson;
    }


    /// <summary>
    /// Triggers an event and affects the player's status.
    /// </summary>
    /// <param name="playerStatus">Player Status object</param>
    public abstract void triggerEvent(PlayerStatus playerStatus);

    /// <summary>
    /// Some events will be based on a condition, specfically on the player's status.
    /// This will be a custom made condition for 
    /// </summary>
    /// <param name="playerStatus">Player Status object</param>
    /// <returns>True or False if the specified player condition passes to trigger the event</returns>
    public abstract bool conditionCheck(PlayerStatus playerStatus);
}

public class EventTest : EventsObject
{

    public EventTest(string eventName, TextAsset inkJson) : base(eventName, inkJson){}

    public override void triggerEvent(PlayerStatus playerStatus)
    {
        if (!conditionCheck(playerStatus)){
            return;
        }
        //Do Something
    }
    public override bool conditionCheck(PlayerStatus playerStatus)
    {
        return true;
    }
}
