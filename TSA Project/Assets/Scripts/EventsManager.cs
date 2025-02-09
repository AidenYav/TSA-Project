using UnityEngine;

public class EventsManager : MonoBehaviour
{


    public TextAsset[] selectedEvents;
    public TextAsset[] randomEvents;

    private EventsObject currentEvent;
    private PlayerStatus playerStatus;

    private int MAX_EVENT_RANDOMIZER = 5;
    private int randomEventCounter = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStatus = transform.gameObject.GetComponent<GameManager>().playerStatus;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TextAsset triggerSelectedEvent(int index){
        return selectedEvents[index];
    }

    public void setRandomEventCounter(int val){
        randomEventCounter = val;
    }
    public void incrementRandomEventCounter(){
        randomEventCounter++;
    }

    public TextAsset triggerRandomEvent(){
        
        if (MAX_EVENT_RANDOMIZER <= randomEventCounter){
            return null;
        }
        //Randomizes for a maximum number of times. Many random events likely will not trigger, 
        //so randomize a few times to *hopefully* trigger something. However, if nothing triggers 
        //within the number of randomization events, stop the loop to prevent infinite loops
        return randomEvents[Random.Range(0, randomEvents.Length)];
    }

    



}
