using System;
using UnityEngine;
using UnityEngine.Events;

public class GuardSpawner : MonoBehaviour
{
    [SerializeField] private UnityEvent spawnGuards;

    public GameObject guard1;
    public GameObject guard2;
    private UnityEvent _spawnGuards;


    private void Update()
    {
        CallSpawnGuards();
    }


    private void CallSpawnGuards()
    {
        if (GameManager.Instance.playerInDinningRoom)
        {
            Invoke("SpawnGuards", 2);
            Destroy(this,3);
        }
    }
    public void SpawnGuards()
    {
        Spawn();
    }

    private void Spawn()
    {
            guard1.SetActive(true);
            guard2.SetActive(true);
    }
}
