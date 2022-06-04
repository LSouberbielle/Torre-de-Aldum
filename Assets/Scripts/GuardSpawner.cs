
using UnityEngine;
using UnityEngine.Events;

public class GuardSpawner : MonoBehaviour
{
    [SerializeField] private UnityEvent spawnGuards;

    public GameObject guard1;
    public GameObject guard2;
    private UnityEvent _spawnGuards;

    public void SpawnGuards()
    {
        if (GameManager.Instance.playerInDinningRoom)
        {
            _spawnGuards = spawnGuards;
        }
    }

    private void Spawn()
    {
            guard1.SetActive(true);
            guard2.SetActive(true);
            Debug.Log("Dinning Room Trigger envio info al GameManager, el GameManager comunica al Script GuardSpawner asignado al objeto GuardsWaypoints");
    }
}
