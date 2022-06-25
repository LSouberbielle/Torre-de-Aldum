using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunchTrigger : MonoBehaviour
{
    [SerializeField] private bool playerOnLunchTrigger;
    [SerializeField] private GameObject pressEToInteract;
    [SerializeField] private GameObject pressRToTalk;
    [SerializeField] private GameObject lunchCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pausemenu;

    private void Update()
    {
        AproachTable();
    }

    private void AproachTable()
    {
        if (playerOnLunchTrigger && Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            lunchCamera.SetActive(true);
            GameManager.Instance.playerSat = true;
            Destroy(pressEToInteract);
            Destroy(pressRToTalk);
            pausemenu.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pressEToInteract.SetActive(true);
            playerOnLunchTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pressEToInteract.SetActive(false);
            playerOnLunchTrigger = false;
        }
    }
}