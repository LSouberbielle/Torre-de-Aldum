using UnityEngine;
public class DinningRoomTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.playerInDinningRoom = true;
        }
    }
    
}
