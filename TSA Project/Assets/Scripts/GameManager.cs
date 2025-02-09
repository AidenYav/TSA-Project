using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    public PlayerStatus playerStatus;
    public bool test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStatus = new PlayerStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
