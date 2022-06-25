using UnityEngine;

public class JournalController2 : MonoBehaviour
{
    private bool playerOnTrigger;
    [SerializeField] private bool journalIsOpen = false;
    [SerializeField] private GameObject pressEToInteract;
    [SerializeField] private GameObject pressQToExit;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject journalCamera;
    [SerializeField] private GameObject firstJournalPage;

    private void Update()
    {
        AproachJournal();
        InteractWithJournal();
        IfCloseJournal();
    }

    private void InteractWithJournal()
    {
        if (firstJournalPage && journalIsOpen && Input.GetKeyDown(KeyCode.Z))
        {
            firstJournalPage.SetActive(false);
        }

    }

    private void ShowJournalPage1()
    {
        firstJournalPage.SetActive(true);
    }

    private void AproachJournal()
    {
        if (playerOnTrigger && Input.GetKeyDown(KeyCode.E))
        {
            playerCamera.SetActive(false);
            journalCamera.SetActive(true);
            Invoke(nameof(ShowJournalPage1), (float) 2.6);
            Invoke(nameof(CallJournalUI), (float) 2.6);
            Invoke(nameof(JournalAnimEnded), (float) 2.6);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player")) ;
        {
            pressEToInteract.SetActive(true);
            playerOnTrigger = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player")) ;
        {
            pressEToInteract.SetActive(false);
            playerOnTrigger = false;
        }
    }

    private void CloseJournal()
    {
        firstJournalPage.SetActive(false);
        journalCamera.SetActive(false);
        playerCamera.SetActive(true);
        pressQToExit.SetActive(false);
        journalIsOpen = false;
    }

    private void CallJournalUI()
    {
        pressQToExit.SetActive(true);
    }

    private void IfCloseJournal()
    {
        if (journalIsOpen && Input.GetKeyDown(KeyCode.Q))
        {
            CloseJournal();
            GameManager.Instance.journalIsClosed = true;
        }
    }

    private void JournalAnimEnded()
    {
        journalIsOpen = true;
    }
}