using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool cellsAreOpen;
    public bool playerInDinningRoom;
    [SerializeField] private UnityEvent playerReachedDinningRoom;
    private void Awake()
    {
        Instance = this;
    }
    
    //If the player arrives at the dinning room this happens
    public void PlayerInDinningRoom()
    {
        if(playerInDinningRoom)
            Debug.Log("The player is in the dinning room, se comunica al GameManager");
    }
}
