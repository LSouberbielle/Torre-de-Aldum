using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueTrigger : MonoBehaviour
{
    public DialogueTrigger trigger;
    [SerializeField] private GameObject pressRToTalk;
    [SerializeField] private bool playerOnDialogueTrigger;

    private void Update()
    {
        Talk();
    }

    private void Talk()
    {
        if (playerOnDialogueTrigger && Input.GetKeyDown(KeyCode.R))
        {
            trigger.TriggerDialogue();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pressRToTalk.SetActive(true);
            playerOnDialogueTrigger = true;
        }
    }

    /* private void OnTriggerEnter(Collider collision)
      {
          if (collision.gameObject.CompareTag("Player"));
          {
              pressRToTalk.SetActive(true);
              playerOnDialogueTrigger = true;
          }
      }
      
      
      private void OnTriggerExit(Collider collision)
      {
          if (collision.gameObject.CompareTag("Player")) ;
          {
              pressRToTalk.SetActive(false);
              playerOnDialogueTrigger = false;
          }
      } */
}
