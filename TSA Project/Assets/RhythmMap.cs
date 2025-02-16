using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


public class RhythmEvent
{
    // Time in seconds when a note should be hit
    //so like if you want if you want a certain action to occur after x seconds
    //then timestamp is those x seconds 
    public float timeStamp; 

    // A certain action you want to occur
    public string action; 
}

public class RhythmMap : MonoBehaviour
{   
    public List<RhythmEvent> rhythmEvents;

    public Rhythm(string file)
    {
        rhythmEvents = new List<RhythmEvent>();
        LoadRhytmMap(file);
    }

    public void AddEvent(float timeStamp, string action)
    {
        rhythmEvents.Add(new RhythmEvent {
             timestamp = timeStamp, 
             action = action 
             }
             );
    }

    public void LoadRhythmMap(string file)
    {
        if (!File.Exists(file))
        {
            return "Rhythm map file cannot be located: " + file;
        }

        string fileContent = File.ReadAllText(file);

        try
        {
            rhythmEvents = JsonConvert.DeserializeObject<List<RhythmEvent>>(fileContent);
            Console.WriteLine("Rhythm map loaded successfully");
        }
        catch (Exception e)
        {
           return "Failed to read thorugh the rhythm map: " + e.Message;
        }
    }
}