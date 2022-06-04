using UnityEngine;
public class DinningRoomTrigger : GuardSpawner
{

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.playerInDinningRoom = true;
    }

    /* public void Spawn()
    {
        if (GameManager.Instance.playerInDinningRoom)
        { 
            GuardsSpawned?.Invoke();
            guard1.SetActive(true);
            guard2.SetActive(true);
            Debug.Log("GuardSpawner recibe que el jugador esta en el comedor. Se activan los guardias que patrullan");
        }
    } */
}
