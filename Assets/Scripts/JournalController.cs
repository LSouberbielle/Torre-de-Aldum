using System;
using UnityEngine;
public class JournalController : MonoBehaviour
{
    private void OnTriggerStay(Collider collsion)
    {
        if (collsion.CompareTag("Player"));
        {
            throw new NotImplementedException();
        }
    }
}
